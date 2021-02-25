namespace Test.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }

        public Article(long id, string title, string description, string thumbnail)
        {
            Id = id;
            Title = title;
            Description = description;
            Thumbnail = thumbnail;
        }
    }

}
