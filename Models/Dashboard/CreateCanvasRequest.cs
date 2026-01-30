using System.ComponentModel.DataAnnotations;

namespace MyStoryTeamAPI.Models.Dashboard
{
    public class CreateCanvasRequest
    {
        [Required]
        public string? CanvasContent { get; set; }
    }
}
