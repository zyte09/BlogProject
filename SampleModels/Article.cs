namespace BlogProject.SampleModels
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string ArticleContent { get; set; }
        public int PostID { get; set; }
        public int AuthorID { get; set; }
    }
}