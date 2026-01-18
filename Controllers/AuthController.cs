using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyStoryTeamAPI.Models.Auth;
using MyStoryTeamAPI.Models.Db;
using MyStoryTeamAPI.Repository;

namespace MyStoryTeamAPI.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthRepository _authRepository;

        public AuthController(AuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public ActionResult<string> LoginUser(LoginUserRequest request)
        {
            try
            {
                DbUser user = this._authRepository.LoginUser(request);
                string accessToken = this._authRepository.GenerateJwtToken(user);
                return this.Ok(accessToken);
            }
            catch (Exception)
            {
                return this.Unauthorized();
            }
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public ActionResult<string> RegisterUser(RegisterUserRequest request)
        {
            int id = this._authRepository.RegisterUser(request);

            return this.Ok($"{id}");
        }
    }
}
