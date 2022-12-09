using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NoticeBoard.Models;

public class Notice
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "The max length of Name is 100 characters!")]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    
    //[DisplayName("")]
}
