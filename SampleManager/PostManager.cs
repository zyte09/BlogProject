using BlogProject.SampleModels;
using Microsoft.EntityFrameworkCore;
using SampleManager;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public class PostManager : IPostManager
    {
        private readonly BlogDbContext _context;

        public PostManager(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await _context.Posts.Include(p => p.Author).Include(p => p.Comments).ToListAsync();
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            return await _context.Posts.Include(p => p.Author).Include(p => p.Comments).FirstOrDefaultAsync(p => p.PostID == id);
        }

        public async Task<Post> CreatePostAsync(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<bool> UpdatePostAsync(Post post)
        {
            var existingPost = await _context.Posts.FindAsync(post.PostID);
            if (existingPost == null)
            {
                return false;
            }

            existingPost.Title = post.Title;
            existingPost.Description = post.Description;
            existingPost.PublishDate = post.PublishDate;
            existingPost.AuthorID = post.AuthorID;
            existingPost.Author = post.Author;
            existingPost.TotalViews = post.TotalViews;
            existingPost.Comments = post.Comments;

            _context.Posts.Update(existingPost);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePostAsync(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return false;
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}