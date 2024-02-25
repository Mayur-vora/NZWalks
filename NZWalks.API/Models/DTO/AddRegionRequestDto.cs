using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTO
{
    public class AddRegionRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Code must not be more than 3 Characters")]
        [MaxLength(3, ErrorMessage = "Code must not be more than 3 Characters")]
        public String Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name must not be more than 100 Characters")]
        public String Name { get; set; }
        public String? RegionImageUrl { get; set; }
    }
}
