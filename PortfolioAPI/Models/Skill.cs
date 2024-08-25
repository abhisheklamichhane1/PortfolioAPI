using System.ComponentModel.DataAnnotations;

public class Skill
{
    [Key]
    public int SkillId { get; set; }

    [Required]
    [MaxLength(100)]
    public string SkillName { get; set; } // Non-nullable

    public string Description { get; set; } // Nullable

    public int? Proficiency { get; set; } // Nullable

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
