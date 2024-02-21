namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public String Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
