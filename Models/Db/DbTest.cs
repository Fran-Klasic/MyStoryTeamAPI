using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyStoryTeamAPI.Models.Db
{
    [Table("Test")]
    public class DbTest
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DbUser? User { get; set; }
        public string? TextContent { get; set; }
    }
}
