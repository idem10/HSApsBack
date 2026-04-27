using HSAps.Interfaces;
using HSAps.Models;
using HSAps.Models.HSAps;

namespace HSAps.Data
{
    public class DashBoardDL : IDashBoard
    {
        private readonly MapappContext _mkt = new MapappContext();
        //login 
        public MktUserClass GetLogin(LoginClass login)
        {
            try
            {
                MktUserClass u = new MktUserClass();
                var usr = _mkt.MktUsers
                                .Where(x => x.UserName == login.User
                                    && x.Password == login.Pwd
                                        && x.App == login.App)
                                    .FirstOrDefault();
                if (usr != null)
                {
                    u.Id = usr.Id;
                    u.UserName = usr.UserName;
                    u.Email = usr.Email;
                    u.Nombre = usr.Nombre;
                    u.Apellidos = usr.Apellidos;
                    u.IsActive = usr.IsActive;
                    u.Rol = usr.Rol;
                    u.Imagen = usr.Imagen;
                    u.LastUpdate = usr.LastUpdate;
                    u.UsuarioExiste = true;
                    u.Matricula = usr.Matricula;
                    u.Grado = usr.Grado;
                    u.Seccion = usr.Seccion;
                }
                else
                {
                    u.UsuarioExiste = false;
                }
                return u;
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
                var qry = _mkt.MktUsers
                                .Where(x => x.UserName == user.UserName || x.Email == user.Email)
                                    .FirstOrDefault();
                using (var insupt = _mkt)
                {
                    if (qry == null)
                    {
                        insupt.MktUsers.Add(user);
                    }
                    insupt.SaveChanges();
                }
                return user;
            }
            catch
            {
                throw;
            }
        }
        //
        public List<MktPost> GetAllPost()
        {
            try
            {
                return _mkt.MktPosts
                                .Where(x => x.IsActive == 1)
                                    .ToList();
            }
            catch
            {
                throw;
            }
        }
        public MktUser GetUser(int Id)
        {
            try
            {
                return _mkt.MktUsers
                                .Where(x => x.Id == Id)
                                    .FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
        public List<MktComment> GetCommentarios(int Id)
        {
            try
            {
                return _mkt.MktComments
                                .Where(x => x.PostId == Id)
                                    .ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<MktPostLike> GetPostLikes(int Id)
        {
            try
            {
                return _mkt.MktPostLikes
                                .Where(x => x.PostId == Id)
                                    .ToList();
            }
            catch
            {
                throw;
            }
        }
        //
        public MktPost SetNewPost(MktPost post)
        {
            try
            {
                var qry = _mkt.MktPosts
                                .Where(x => x.Id == post.Id)
                                    .FirstOrDefault();
                using (var insupt = _mkt)
                {
                    if (qry == null)
                    {
                        insupt.MktPosts.Add(post);
                    }
                    else
                    {
                        qry.Contenido = post.Contenido;
                        qry.Imagen = post.Imagen;
                        qry.VideoUrl = post.VideoUrl;
                        qry.Estatus = post.Estatus;
                        qry.IsActive = post.IsActive;
                        qry.Privacidad = post.Privacidad;
                    }
                    insupt.SaveChanges();
                }
                return post;
            }
            catch
            {
                throw;
            }
        }
        public List<DmHorario> GetHorario(int id)
        {
            try
            {
                return _mkt.DmHorarios
                                .Where(x => x.IdUser == id)
                                    .ToList();
            }
            catch
            {
                throw;
            }
        }
        //
        public DmHorario SetHorario(DmHorario hr)
        {
            try
            {
                var qry = _mkt.DmHorarios
                                    .Where(x => x.Id == hr.Id)
                                        .FirstOrDefault();
                using (var insupt = _mkt)
                {
                    if (qry == null)
                    {
                        insupt.DmHorarios.Add(hr);
                    }
                    else
                    {
                        qry.Hora = hr.Hora;
                        qry.Dia = hr.Dia;
                        qry.Materia = hr.Materia;
                        qry.Edificio = hr.Edificio;
                        qry.Salon = hr.Salon;
                        qry.Eliminar = hr.Eliminar;
                    }
                    insupt.SaveChanges();
                }
                return hr;
            }
            catch
            {
                throw;
            }
        }

        public MktUser UpdateUserImage(UpdateImageClass data)
        {
            try
            {
                var usr = _mkt.MktUsers
                                .Where(x => x.UserName == data.UserName)
                                    .FirstOrDefault();
                if (usr != null)
                {
                    usr.Imagen = data.Imagen;
                    _mkt.SaveChanges();
                }
                return usr;
            }
            catch
            {
                throw;
            }
        }

    }
}
