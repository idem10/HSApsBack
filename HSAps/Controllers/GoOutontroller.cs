using HSAps.Business;
using HSAps.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HSAps.Controllers
{
    [Route("[controller]/[action]")]
    [ApiExplorerSettings(GroupName = "GoOut")]
    public class GoOutController : Controller
    {
        private readonly GoOutBL _go;
        public GoOutController(IGoOut go) => _go = new GoOutBL(go);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetGoOut()
        {
            try
            {
                return Ok(_go.GetGoOut());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
