namespace Test.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }

        public string Image { get; set; }

        public Project(long id, string title, string description, string client, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Client = client;
            Image = image;
        }
    }
}
