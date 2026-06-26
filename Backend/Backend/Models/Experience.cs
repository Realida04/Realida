using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

[Table("Experience")]
public partial class Experience
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Company { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Position { get; set; } = null!;

    [Column("startDate")]
    public int StartDate { get; set; }

    public int EndDate { get; set; }

    [Column("User_id")]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Experiences")]
    public virtual User User { get; set; } = null!;
}
