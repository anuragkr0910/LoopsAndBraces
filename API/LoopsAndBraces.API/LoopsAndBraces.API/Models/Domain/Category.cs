namespace LoopsAndBraces.API.Models.Domain
{
    public class Category
    {
        public Guid Id { get; set; }

        public int SerialNo { get; set; }

        public string Name { get; set; }

        public string URLHandle { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public bool IsActive { get; set; }
    }
}
