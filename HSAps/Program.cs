using HSAps.Data;
using HSAps.Interfaces;
using HSAps.Models;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

List<DashBoardDefinition> ddf = builder.Configuration.GetSection("DashBoard").Get<List<DashBoardDefinition>>();
IConfiguration configuration = builder.Configuration;
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddScoped<IDashBoard, DashBoardDL>();
builder.Services.AddCors(op => op.AddPolicy("AllowAll", policy =>
{
    policy.AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed(origin => true)
        .AllowCredentials();
}));

builder.Services.AddSwaggerGen(c =>
{
    foreach (var conf in ddf)
    {
        c.SwaggerDoc(conf.Name,
            new OpenApiInfo
            {
                Title = conf.Title,
                Version = conf.Version,
                Description = conf.Description,
                Contact = new OpenApiContact
                {
                    Name = conf.ContactName,
                    Url = new Uri(conf.UrlContactName)
                }
            });
    }
});
builder.Services.AddControllersWithViews().
                    AddJsonOptions(options =>
                    {
                        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                        options.JsonSerializerOptions.PropertyNamingPolicy = null;
                    });
var app = builder.Build();
app.UseCors("AllowAll");
string baseFolder = "..";
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    baseFolder = "";
}
app.UseSwagger();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseSwaggerUI(c =>
{
    foreach (var conf in ddf)
    {
        c.SwaggerEndpoint($"{baseFolder}/swagger/" + conf.Version + "/swagger.json", conf.Version);
    }
});

//sockets
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllers();

app.Run();