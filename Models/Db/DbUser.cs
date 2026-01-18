using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyStoryTeamAPI.Models.Db
{
    [Table("USERS")]
    public class DbUser
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
