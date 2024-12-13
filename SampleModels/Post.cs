using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.SampleModels
{
    public class Post
    {
        public int PostID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorID { get; set; }
        public User Author { get; set; }
        public int TotalViews { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}