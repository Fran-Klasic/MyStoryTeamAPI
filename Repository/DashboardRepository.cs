using MyStoryTeamAPI.Db;
using MyStoryTeamAPI.Models.Dashboard;
using MyStoryTeamAPI.Models.Db;

namespace MyStoryTeamAPI.Repository
{
    public class DashboardRepository : RepositoryBase
    {
        public DashboardRepository(AppDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext, httpContextAccessor)
        {
        }

        public int CreateDashborad(CreateCanvasRequest request)
        {
            DbUser user = this.GetCurrentUser();
            DbCanvases newCanvas = new DbCanvases
            {
                User_Id = user.Id,
                Canvas_Name = "Untitled",
                Canvas_Data = request.CanvasContent!,
                Created_At = DateTime.Now,
                Updated_At = DateTime.Now,
                Visibility = 0 //Private by default
            };
            this.DbContext.Canvases.Add(newCanvas);
            this.DbContext.SaveChanges();
            return newCanvas.Id;
        }

        public DashboardDetailsResponse? GetDashboardDetails(int id)
        {
            DbUser user = this.GetCurrentUser();
            DashboardDetailsResponse? canvasData = this.DbContext.Canvases
                .Where(c => (c.User_Id == user.Id && c.Id == id) || (c.Visibility == 1))
                .Select(c => new DashboardDetailsResponse(c))
                .FirstOrDefault();
           
            return canvasData;
        }

        //#region TEST
        //public int GenerateTestContent(CreateTestReqeust reqeust)
        //{
        //    DbUser user = this.GetCurrentUser();

        //    DbTest newContent = new DbTest
        //    {
        //        UserId = user.Id,
        //        TextContent = reqeust.TextContent,
        //    };

        //    this.DbContext.Tests.Add(newContent);
        //    this.DbContext.SaveChanges();

        //    return newContent.Id;
        //}

        //public DbTest[] GetAllContent()
        //{
        //    DbUser user = this.GetCurrentUser();

        //    return this.DbContext.Tests.Where(t => t.UserId == user.Id).ToArray();
        //}

        //public DbTest? GetDetails(int id)
        //{
        //    DbUser user = this.GetCurrentUser();

        //    return this.DbContext.Tests.Where(t => t.UserId == user.Id && t.Id == id).FirstOrDefault();
        //}
        //#endregion
    }
}
