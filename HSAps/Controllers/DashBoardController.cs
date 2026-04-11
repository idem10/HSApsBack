using HSAps.Business;
using HSAps.Interfaces;
using HSAps.Models;
using HSAps.Models.HSAps;
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
        //
        [HttpPost]
        public IActionResult GetLogin([FromBody] LoginClass login)
        {
            try
            {
                return Ok(_dsh.GetLogin(login));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet]
        public IActionResult GetLogin(string User, string Pwd, string App)
        {
            try
            {
                LoginClass login = new LoginClass() { User = User, Pwd = Pwd, App = App };
                return Ok(_dsh.GetLogin(login));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult SetNewUser([FromBody] MktUser user)
        {
            try
            {
                return Ok(_dsh.SetNewUser(user));
            }
            catch
            {
                return BadRequest();
            }
        }
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SetNewPost([FromBody] MktPost post)
        {
            try
            {
                return Ok(_dsh.SetNewPost(post));
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetHorario(int id)
        {
            try
            {
                return Ok(_dsh.GetHorario(id));
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dm"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SetHorario([FromBody] DmHorario dm)
        {
            try
            {
                return Ok(_dsh.SetHorario(dm));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
