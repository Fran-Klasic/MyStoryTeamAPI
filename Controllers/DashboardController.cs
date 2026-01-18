using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyStoryTeamAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/dashboard")]
    public class DashboardController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> ProtecetedGet()
        {
            return this.Ok("Successfully accessed protected data....");
        }
    }
}
