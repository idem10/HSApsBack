using HSAps.Models;
using HSAps.Models.HSAps;

namespace HSAps.Interfaces
{
    public interface IDashBoard
    {
        //
        MktUserClass GetLogin(LoginClass login);
        MktUser SetNewUser(MktUser user);
        //torneos
        List<TurTorneo> GetTorneos();
        List<TurEquipo> GetEquipos();
        TurListaTorneo SetListaTorneo(TurListaTorneo tl);
        //
        List<MktPost> GetAllPost();
        MktUser GetUser(int Id);
        List<MktComment> GetCommentarios(int Id);
        List<MktPostLike> GetPostLikes(int Id);
        //
        MktPost SetNewPost(MktPost post);
        // dragon map
        List<DmHorario> GetHorario(int id);
        DmHorario SetHorario(DmHorario hr);
        MktUser UpdateUserImage(UpdateImageClass data);
    }
}
