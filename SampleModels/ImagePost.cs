namespace BlogProject.SampleModels
{
    public class ImagePost
    {
        public int ImagePostID { get; set; }
        public string ImageURL { get; set; }
        public string Caption { get; set; }
        public int PostID { get; set; }
        public int AuthorID { get; set; }
    }
}