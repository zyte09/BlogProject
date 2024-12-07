namespace BlogProject.SampleModels
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; }
        public int PostID { get; set; }
        public Post? Post { get; set; } //null reference type and
        public User? User { get; set; } //null to avoid issue JSON 
        public int UserID { get; set; } 
    }
}