using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStoryTeamAPI.Models.Dashboard;
using MyStoryTeamAPI.Repository;

namespace MyStoryTeamAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/dashboard")]
    public class DashboardController : ControllerBase
    {
        private readonly DashboardRepository dashboardRepository;

        public DashboardController(DashboardRepository dashboardRepository)
        {
            this.dashboardRepository = dashboardRepository;
        }

        [Authorize]
        [HttpPost]
        public ActionResult<int> CreateCanvas(CreateCanvasRequest createCanvasRequest)
        {
            int id = dashboardRepository.CreateDashborad(createCanvasRequest);
            return this.Ok(id);
        }

        [Authorize]
        [HttpPut]
        public ActionResult<int> UpdateCanvas(UpdateCanvasRequest updateCanvasRequest)
        {
            return this.Ok("Update");
        }

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult<int> DeleteCanvas(int id)
        {
            return this.Ok($"Delete {id}");
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<DashboardDetailsResponse> GetCanvasDetails(int id)
        {
            DashboardDetailsResponse? dashboardDetailsResponse = dashboardRepository.GetDashboardDetails(id);
            return this.Ok(dashboardDetailsResponse);
        }

        [Authorize]
        [HttpGet]
        public ActionResult<DashboardDetailsResponse[]> GetUserCanvasList()
        {
            return this.Ok("GetAll");
        }
    }
}
