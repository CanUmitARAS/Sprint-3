using System.ComponentModel.DataAnnotations;

namespace Sprint_3.Data.Entity
{
    public class PostImage
    {
        [Key] public int Id { get; set; }
        [Required] public string ImageUrl { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }


    }
}
