using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleManager
{
    public class CommentCreationDto
    {
        [Required]
        public string Content { get; set; }
        public int PostID { get; set; }
        public int UserID { get; set; }
    }

}
