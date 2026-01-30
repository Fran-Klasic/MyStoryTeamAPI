namespace MyStoryTeamAPI.Models.Dashboard
{
    public class DashboardDetailsResponse
    {
        public int Id { get; }
        public int UserId { get; }
        public string CanvasName { get; }
        public string CanvasData { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; }
        public int Visibility { get; }

        public DashboardDetailsResponse(DbCanvases dbCanvas_Data)
        {
            Id = dbCanvas_Data.Id;
            UserId = dbCanvas_Data.User_Id;
            CanvasName = dbCanvas_Data.Canvas_Name;
            CanvasData = dbCanvas_Data.Canvas_Data;
            CreatedAt = dbCanvas_Data.Created_At;
            UpdatedAt = dbCanvas_Data.Updated_At;
            Visibility = dbCanvas_Data.Visibility;
        }
    }
}
