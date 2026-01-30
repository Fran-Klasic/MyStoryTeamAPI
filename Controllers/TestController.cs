//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using MyStoryTeamAPI.Models.Dashboard;
//using MyStoryTeamAPI.Models.Db;
//using MyStoryTeamAPI.Repository;

//namespace MyStoryTeamAPI.Controllers
//{
//    [Authorize]
//    [ApiController]
//    [Route("api/test")]
//    public class TestController : ControllerBase
//    {
//        private readonly DashboardRepository dashboardRepository;

//        public TestController(DashboardRepository dashboardRepository)
//        {
//            this.dashboardRepository = dashboardRepository;
//        }

//        [Authorize]
//        [HttpPost]
//        public ActionResult<int> Create(CreateTestReqeust reqeust)
//        {
//            int id = this.dashboardRepository.GenerateTestContent(reqeust);
//            return this.Ok(id);
//        }

//        [Authorize]
//        [HttpGet]
//        public ActionResult<DbTest[]> GetItems()
//        {
//            var items = this.dashboardRepository.GetAllContent();
//            return this.Ok(items);
//        }

//        [Authorize]
//        [HttpGet("{id}")]
//        public ActionResult<DbTest> GetItemDetails(int id)
//        {
//            var details = this.dashboardRepository.GetDetails(id);

//            if (details == null)
//            {
//                return this.NotFound();
//            }

//            return this.Ok(details);
//        }
//    }
//}
