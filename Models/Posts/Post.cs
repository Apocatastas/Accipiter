namespace Accipiter.Models.Posts
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<int> TagsIds { get; set; }
    }
}
