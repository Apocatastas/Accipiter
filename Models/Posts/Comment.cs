using System;
using System.Collections.Generic;

namespace Accipiter.Models.Posts
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedAt { get; set; }

        public string GetSnippet()
        {
            return Content;
        }

        public Comment()
        {
            Id = new Guid();
            Content = "Новый комментарий.";
            CreatedAt = DateTime.Now;
        }
    }
}
