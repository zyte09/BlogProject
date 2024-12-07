using BlogProject.SampleModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public class PostManager : IPostManager
    {
        private readonly List<Post> _posts = new List<Post>();

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await Task.FromResult(_posts);
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            var post = _posts.Find(p => p.PostID == id);
            return await Task.FromResult(post);
        }

        public async Task<Post> CreatePostAsync(Post post)
        {
            post.PostID = _posts.Count + 1;
            _posts.Add(post);
            return await Task.FromResult(post);
        }

        public async Task<bool> UpdatePostAsync(Post post)
        {
            var existingPost = _posts.Find(p => p.PostID == post.PostID);
            if (existingPost == null)
            {
                return await Task.FromResult(false);
            }

            existingPost.Title = post.Title;
            existingPost.Description = post.Description;
            existingPost.PublishDate = post.PublishDate;
            existingPost.AuthorID = post.AuthorID;
            existingPost.Author = post.Author;
            existingPost.TotalViews = post.TotalViews;
            existingPost.Comments = post.Comments;

            return await Task.FromResult(true);
        }

        public async Task<bool> DeletePostAsync(int id)
        {
            var post = _posts.Find(p => p.PostID == id);
            if (post == null)
            {
                return await Task.FromResult(false);
            }

            _posts.Remove(post);
            return await Task.FromResult(true);
        }
    }
}