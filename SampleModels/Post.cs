namespace BlogProject.SampleModels
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; } = string.Empty; //not  null
        public string Description { get; set; } = string.Empty; //null
        public DateTime PublishDate { get; set; }
        public int AuthorID { get; set; }
        public User Author { get; set; } = new User(); //not null
        public int TotalViews { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>(); // null
    }
}