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

        public int GenerateTestContent(CreateTestReqeust reqeust)
        {
            DbUser user = this.GetCurrentUser();

            DbTest newContent = new DbTest
            {
                UserId = user.Id,
                TextContent = reqeust.TextContent,
            };

            this.DbContext.Tests.Add(newContent);
            this.DbContext.SaveChanges();

            return newContent.Id;
        }

        public DbTest[] GetAllContent()
        {
            DbUser user = this.GetCurrentUser();

            return this.DbContext.Tests.Where(t => t.UserId == user.Id).ToArray();
        }

        public DbTest? GetDetails(int id)
        {
            DbUser user = this.GetCurrentUser();

            return this.DbContext.Tests.Where(t => t.UserId == user.Id && t.Id == id).FirstOrDefault();
        }
    }
}
