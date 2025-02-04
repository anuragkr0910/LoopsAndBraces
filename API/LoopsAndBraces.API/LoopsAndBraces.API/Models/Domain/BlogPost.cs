namespace LoopsAndBraces.API.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }

        public int SerialNo { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Content { get; set; }

        public string FeaturedImageURL { get; set; }

        public string URLHandle { get; set; }

        public DateTime PublishedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string Author { get; set; }

        public bool IsVisible { get; set; }
    }
}
