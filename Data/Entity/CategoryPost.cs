
using System.ComponentModel.DataAnnotations;

namespace Sprint_3.Data.Entity
{
    public class CategoryPost
    {

        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public int PostId { get; set; }
        public Post? Post { get; set; }
    }
}
