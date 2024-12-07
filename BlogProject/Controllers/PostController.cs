using BlogProject.SampleModels;
using BlogProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogProject_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostManager _postManager;

        public PostController(IPostManager postManager)
        {
            _postManager = postManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _postManager.GetAllPostsAsync();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPost(int id)
        {
            var post = await _postManager.GetPostByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdPost = await _postManager.CreatePostAsync(post);
            return CreatedAtAction(nameof(GetPost), new { id = createdPost.PostID }, createdPost);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id, [FromBody] Post post)
        {
            if (id != post.PostID || !ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _postManager.UpdatePostAsync(post);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var result = await _postManager.DeletePostAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}