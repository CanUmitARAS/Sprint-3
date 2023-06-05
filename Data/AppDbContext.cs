using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;

using Sprint_3.Data.Entity;

namespace Sprint_3.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<CategoryPost> CategoryPosts { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Sprint3;Trusted_Connection=True;");
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connectionString = ("DefaultConnection"); //ne yapmalıyız ?
        //    optionsBuilder.UseSqlServer(connectionString);
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Sprint;Trusted_Connection=True;");
        //    // burda ne yapılıyor? Nereye bağlayacağız?
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   // burada ne yaptım tam bilmiyorum ama                   Microsoft.Data.SqlClient.SqlException: 'Introducing FOREIGN KEY constraint 'FK_CategoryPosts_Posts_PostId' on table 'CategoryPosts' may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints. hatasını çözdüm
            modelBuilder.Entity<CategoryPost>()
        .HasOne(cp => cp.Post)
        .WithMany()    
        .HasForeignKey(cp => cp.PostId)
        .OnDelete(DeleteBehavior.Restrict);
            // Fluent API veya Data Annotations ile ek model kurallarını burada nasıl yapılandırırız?
        }

    }
}
