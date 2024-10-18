namespace BlogProject.SampleModels
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorID { get; set; }
        public int TotalViews { get; set; }
    }
}