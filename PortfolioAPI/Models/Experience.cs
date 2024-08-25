using System;
using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.Models
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }

        [Required]
        [MaxLength(100)]
        public string JobTitle { get; set; }

        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
