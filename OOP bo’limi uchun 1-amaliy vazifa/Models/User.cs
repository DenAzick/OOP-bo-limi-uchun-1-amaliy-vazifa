using System.ComponentModel.DataAnnotations;

namespace OOP_bo_limi_uchun_1_amaliy_vazifa.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Firstname { get; set; }

    [Required]
    [MaxLength (30)]
    public string Lastname { get; set; }

    public bool Sex { get; set; } // true male, false female

    [Range(0, 150)]
    public byte Age { get; set; }
}
