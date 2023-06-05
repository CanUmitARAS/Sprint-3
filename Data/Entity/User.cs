using System.ComponentModel.DataAnnotations;

namespace Sprint_3.Data.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required] public string Username { get; set; }

        [Required] string Password { get; set; }

        [Required] public string Email { get;set; }
    }
}
