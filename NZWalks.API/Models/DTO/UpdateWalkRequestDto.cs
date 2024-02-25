using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTO
{
    public class UpdateWalkRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Name must not be less than 3 Characters")]
        [MaxLength(100, ErrorMessage = "Name must not be more than 100 Characters")]
        public String Name { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Description must not be less than 5 Characters")]
        [MaxLength(1000, ErrorMessage = "Description must not be more than 1000 Characters")]
        public String Description { get; set; }
        [Required]
        [Range(1, 50, ErrorMessage = "The length of the walk must be between 1 to 50 Kilometres")]

        public Double LengthInKm { get; set; }
        public String? WalkImageUrl { get; set; }
        [Required]
        public Guid DifficultyId { get; set; }
        [Required]
        public Guid RegionId { get; set; }
    }
}
