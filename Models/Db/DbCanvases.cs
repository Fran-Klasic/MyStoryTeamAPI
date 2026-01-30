using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("CANVAS_DATA")]
public class DbCanvases
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int User_Id { get; set; }

    [Required]
    public string Canvas_Name { get; set; } = string.Empty;

    [Required]
    public string Canvas_Data { get; set; } = string.Empty;

    [Required]
    public DateTime Created_At { get; set; }

    [Required]
    public DateTime Updated_At { get; set; }

    //0 = private, 1 = public
    [Required]
    public int Visibility { get; set; } = 0;
}
