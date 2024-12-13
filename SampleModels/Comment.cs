using System;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.SampleModels
{
    public class Comment
    {
        public int CommentID { get; set; }
        [Required]
        public string Content { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; }
        public int PostID { get; set; }
        public Post? Post { get; set; }
        public User? User { get; set; }
        public int UserID { get; set; }
    }
}