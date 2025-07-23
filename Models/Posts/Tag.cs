using System;

namespace Accipiter.Models.Posts
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
      
        public Tag()
        {
            Id = new Guid();
            Content = "Новый тэг.";
        }
    }
}
