namespace BlogProject.SampleModels
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public int PostID { get; set; }
        public int UserID { get; set; }
    }
}