using Microsoft.EntityFrameworkCore;
using BlogProject.SampleModels;

namespace BlogProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TextPost> TextPosts { get; set; }
        public DbSet<ImagePost> ImagePosts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}