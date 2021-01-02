namespace Records
{
    using System;
    
    internal record Message
    {
        public Message()
        {
        }

        public Message(string content, string author, DateTime creationTime, DateTime? lastModifiedTime = null)
        {
            this.Content = content;
            this.Author = author;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
        }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModifiedTime { get; set; }
    }
}
