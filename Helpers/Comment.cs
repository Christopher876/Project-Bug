using System;

namespace ProjectBug.Helpers
{
    public class Comment
    {
        public User Commenter { get; set; }
        public string Content { get; set; }
        public DateTime CommentTime { get; set; }
    }
}