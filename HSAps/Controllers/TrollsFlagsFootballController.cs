using HSAps.Business;
using HSAps.Interfaces;
using HSAps.Models.HSAps;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSAps.Controllers
{
    [Route("[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "TrollsFlagsFootball")]
    [ApiController]
    public class TrollsFlagsFootballController : ControllerBase
    {
        private readonly TrollsFlagsFootballBL _tff;
        public TrollsFlagsFootballController(ITrollsFlagsFootball tff)
        {
            _tff = new TrollsFlagsFootballBL(tff);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetDashBoard()
        {
            try
            {
                return Ok(_tff.GetDashBoard());
            }
            catch
            {
                return BadRequest();
            }
        }        
    }
}
