using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HSAps.Controllers
{
    [Route("[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "DashBoard")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetDashBoard()
        {
            try
            {
                return Ok("");
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
