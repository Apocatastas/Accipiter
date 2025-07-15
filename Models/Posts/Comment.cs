using Accipiter.Models.Users;

namespace Accipiter.Models.Posts
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string AuthorId { get; set; }
        public User Author { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PostId { get; set; }
    }
}
