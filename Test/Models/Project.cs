namespace Test.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }

        public string Thumbnail { get; set; }

        public Project(long id, string title, string description, string client, string thumbnail)
        {
            Id = id;
            Title = title;
            Description = description;
            Client = client;
            Thumbnail = thumbnail;
        }
    }
}
