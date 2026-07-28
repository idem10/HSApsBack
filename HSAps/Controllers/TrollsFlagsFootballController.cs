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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ni"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SetIntegrante([FromBody] TffIntegrante ni)
        {
            try
            {
                return Ok(_tff.SetIntegrante(ni));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult SetPago([FromBody] TffPago pago)
        {
            try
            {
                return Ok(_tff.SetPago(pago));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult SetAsistencia([FromBody] TffAsistencium asis)
        {
            try
            {
                return Ok(_tff.SetAsistencia(asis));
            }
            catch
            {
                return BadRequest();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ni"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelIntegrante([FromBody] TffIntegrante ni)
        {
            try
            {
                return Ok(_tff.DelIntegrante(ni));
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pago"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelPago([FromBody] TffPago pago)
        {
            try
            {
                return Ok(_tff.DelPago(pago));
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="asis"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelAsistencia([FromBody] TffAsistencium asis)
        {
            try
            {
                return Ok(_tff.DelAsistencia(asis));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
