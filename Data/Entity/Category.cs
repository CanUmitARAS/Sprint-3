using System.ComponentModel.DataAnnotations;                                                                                                            


namespace Sprint_3.Data.Entity

{
    public class Category
    {
        [Key] public int Id { get; set; }

        [Required] public string? Name { get; set; }
    }
}
