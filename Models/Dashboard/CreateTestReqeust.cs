using System.ComponentModel.DataAnnotations;

namespace MyStoryTeamAPI.Models.Dashboard
{
    public class CreateTestReqeust
    {
        [Required]
        public string? TextContent { get; set; }
    }
}
