using System.ComponentModel.DataAnnotations;

namespace MyStoryTeamAPI.Models.Dashboard
{
    public class UpdateCanvasRequest
    {
        [Required]
        public int? CanvasId { get; set; }
        [Required]
        public string? CanvasContent { get; set; }
        [Required]
        public string? CanvasName { get; set; }
    }
}
