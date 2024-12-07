using BlogProject.SampleModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public interface IPostManager
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<Post> GetPostByIdAsync(int id);
        Task<Post> CreatePostAsync(Post post);
        Task<bool> UpdatePostAsync(Post post);
        Task<bool> DeletePostAsync(int id);
    }
}