using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Sprint_3.Data.Entity
{
    public class Post
    {
        [Key] public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        = string.Empty;

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<CategoryPost> CategoryPosts { get; set; }

        public List<PostImage> PostImages { get; set; }

        public List<PostComment> PostComments { get; set; }
    }
}
