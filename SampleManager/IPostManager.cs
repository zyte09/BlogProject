using BlogProject.SampleModels;
using SampleManager;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogProject.Services
{
    public interface IPostManager
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<Post> GetPostByIdAsync(int id);
        Task<Post> CreatePostAsync(PostCreationDto postDto, int authorId); 
        Task<bool> UpdatePostAsync(Post post);
        Task<bool> DeletePostAsync(int id);
    }
}
