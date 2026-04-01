using HSAps.Business;
using HSAps.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HSAps.Controllers
{
    [Route("[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "DashBoard")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
        private readonly DashBoardBL _dsh;
        public DashBoardController(IDashBoard dsh) => _dsh = new DashBoardBL(dsh);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllPost()
        {
            try
            {
                return Ok(_dsh.GetAllPost());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
