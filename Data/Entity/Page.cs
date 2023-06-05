using System.ComponentModel.DataAnnotations;

namespace Sprint_3.Data.Entity
{
    public class Page
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }

        [Required] public string Content { get; set; }
    }
}
