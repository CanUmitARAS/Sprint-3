using System;
using System.ComponentModel.DataAnnotations;

namespace Sprint_3.Data.Entity
{
    public class PostComment
    {
        [Key] public int Id { get; set; }

        [Required] public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}
