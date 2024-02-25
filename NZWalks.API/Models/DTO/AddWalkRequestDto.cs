namespace NZWalks.API.Models.DTO
{
    public class AddWalkRequestDto
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public Double LengthInKm { get; set; }
        public String? WalkImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }
    }
}
