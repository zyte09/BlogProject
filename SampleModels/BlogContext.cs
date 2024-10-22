using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.SampleModels;
using Microsoft.EntityFrameworkCore;
namespace SampleModels
{
    public class BlogContext : DbContext
    {
        public DbSet<TextPost> TextPosts { get; set; }
        public DbSet<ImagePost> ImagePosts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }
    }
}
