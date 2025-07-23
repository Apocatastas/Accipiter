using System;
using System.Collections.Generic;

namespace Accipiter.Models.Posts
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public List<int> PostTagsIds { get; set; }
        public List<int> PostCommentsIds { get; set; }

        public string GetTitle()
        {
            return Title;
        }

        public string GetSnippet()
        {
            return Content;
        }

        public List<int> GetComments()
        { 
            return PostCommentsIds; 
        }

        public List<int> GetTags()
        {
            return PostTagsIds;
        }

        public Post()
        {
            Id = new Guid();
            Title = "Новый заголовок";
            Content = "Было у отца три сына.";
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
            PostTagsIds = new List<int>();
            PostCommentsIds = new List<int>();
        }

    }
}
