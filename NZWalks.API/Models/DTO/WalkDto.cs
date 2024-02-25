namespace NZWalks.API.Models.DTO
{
    public class WalkDto
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Double LengthInKm { get; set; }
        public String? WalkImageUrl { get; set; }

        // Removed region and difficulty Id because we already covering it in both Dto's properties
        public RegionDto Region { get; set; }
        public DifficultyDto Difficulty { get; set; }
    }
}
