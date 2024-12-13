using Microsoft.EntityFrameworkCore;
using BlogProject.SampleModels;

namespace SampleManager
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<TextPost> TextPosts { get; set; }
        public DbSet<ImagePost> ImagePosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}