using HSAps.Interfaces;
using HSAps.Models.HSAps;

namespace HSAps.Data
{
    public class DashBoardDL : IDashBoard
    {
        private readonly MapappContext _mkt = new MapappContext();
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
    }
}
