﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BlogProject.SampleModels
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}