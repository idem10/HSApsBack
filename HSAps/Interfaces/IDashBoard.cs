using HSAps.Models;
using HSAps.Models.HSAps;

namespace HSAps.Interfaces
{
    public interface IDashBoard
    {
        //
        MktUserClass GetLogin(LoginClass login);
        //
        List<MktPost> GetAllPost();
        MktUser GetUser(int Id);
        List<MktComment> GetCommentarios(int Id);
        List<MktPostLike> GetPostLikes(int Id);
        //
        MktPost SetNewPost(MktPost post);
    }
}
