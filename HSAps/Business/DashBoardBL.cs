using HSAps.Interfaces;
using HSAps.Models.HSAps;

namespace HSAps.Business
{
    public class DashBoardBL
    {
        //
        private readonly IDashBoard _dsh;
        public DashBoardBL(IDashBoard dsh) => _dsh = dsh;
        public List<MktPost> GetAllPost()
        {
            try
            {
                return _dsh.GetAllPost();
            }
            catch
            {
                throw;
            }
        }
    }
}
