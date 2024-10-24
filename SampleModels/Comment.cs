namespace BlogProject.SampleModels
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public int PostID { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
    }
}