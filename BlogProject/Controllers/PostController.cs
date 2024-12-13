using BlogProject.SampleModels;
using BlogProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleManager;
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.Extensions.Logging;

namespace BlogProject_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IPostManager _postManager;
        private readonly IUserManager _userManager;
        private readonly ILogger<PostController> _logger;

        public PostController(IPostManager postManager, IUserManager userManager, ILogger<PostController> logger)
        {
            _postManager = postManager;
            _userManager = userManager;
            _logger = logger;
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
        public async Task<IActionResult> CreatePost([FromBody] PostCreationDto postDto, [FromHeader(Name = "userId")] int userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _logger.LogInformation("Received request to create post for user ID: {UserId}", userId);

            var user = await _userManager.GetUserByIdAsync(userId);
            if (user == null)
            {
                _logger.LogWarning("User with ID {UserId} not found", userId);
                return Unauthorized("Invalid user.");
            }

            _logger.LogInformation("User with ID {UserId} found: {UserName}", userId, user.UserName);

            var createdPost = await _postManager.CreatePostAsync(postDto, user.UserID);
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
