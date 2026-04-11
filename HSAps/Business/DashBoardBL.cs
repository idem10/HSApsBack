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
        //
        public MktUserClass GetLogin(LoginClass login)
        {
            try
            {
                return _dsh.GetLogin(login);
            }
            catch
            {
                throw;
            }
        }
        public MktUser SetNewUser(MktUser user)
        {
            try
            {
                return _dsh.SetNewUser(user);
            }
            catch
            {
                throw;
            }
        }
        //
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
                        UserImagen = _dsh.GetUser(p.UserId).Imagen,
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
        //
        public List<DmHorario> GetHorario(int id)
        {
            try
            {
                return _dsh.GetHorario(id);
            }
            catch
            {
                throw;
            }
        }
        public DmHorario SetHorario(DmHorario hr)
        {
            try
            {
                return _dsh.SetHorario(hr);
            }
            catch
            {
                throw;
            }
        }
    }
}
