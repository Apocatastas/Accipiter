namespace Accipiter.Models.Posts
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PostId { get; set; }
    }
}
