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
    }
}
