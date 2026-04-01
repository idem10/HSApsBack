using HSAps.Interfaces;
using HSAps.Models;
using HSAps.Models.HSAps;

namespace HSAps.Business
{
    public class DashBoardBL
    {
        //
        private readonly IDashBoard _dsh;
        public DashBoardBL(IDashBoard dsh) => _dsh = dsh;
        public List<PostAllDataClass> GetAllPost()
        {
            List<PostAllDataClass> padc = new List<PostAllDataClass>();
            try
            {
                var data = _dsh.GetAllPost();
                data.ForEach(p =>
                {
                    var coment = _dsh.GetCommentarios(p.Id);
                    var likes = _dsh.GetPostLikes(p.Id);
                    padc.Add(new PostAllDataClass
                    {
                        Id = p.Id,
                        UserId = p.UserId,
                        UserName = _dsh.GetUser(p.UserId)?.UserName,
                        Contenido = p.Contenido,
                        Imagen = p.Imagen,
                        VideoUrl = p.VideoUrl,
                        Estatus = p.Estatus,
                        FechaCreacion = p.FechaCreacion,
                        IsActive = p.IsActive,
                        Privacidad = p.Privacidad,
                        Comentarios = coment,
                        PostLikes = likes,
                    });
                });
                return padc.OrderByDescending(x => x.Id).ToList();
            }
            catch
            {
                throw;
            }
        }
        public MktPost SetNewPost(MktPost post)
        {
            try
            {
                return _dsh.SetNewPost(post);
            }
            catch
            {
                throw;
            }
        }
    }
}
