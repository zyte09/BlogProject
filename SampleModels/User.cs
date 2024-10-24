namespace BlogProject.SampleModels
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}