namespace BlogProject.SampleModels
{
    public class TextPost
    {
        public int TextPostID { get; set; }
        public string Content { get; set; }
        public int PostID { get; set; }
        public int AuthorID { get; set; }
    }
}
