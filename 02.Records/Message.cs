namespace Records
{
    using System;

    internal record Message
    {
        public Message()
        {
        }

        public Message(string content, string author, DateTime creationTime)
        {
            this.Content = content;
            this.Author = author;
            this.CreationTime = creationTime;
        }

        public string Content { get; init; }

        public string Author { get; init; }

        public DateTime CreationTime { get; init; }
    }
}
