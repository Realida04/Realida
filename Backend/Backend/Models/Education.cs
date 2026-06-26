using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

[Table("Education")]
public partial class Education
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Institution { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Degree { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Field { get; set; } = null!;

    public int StartYear { get; set; }

    [Column("User_id")]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Educations")]
    public virtual User User { get; set; } = null!;
}
