using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Backend.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Fullname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? Bio { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("phone")]
    [StringLength(20)]
    [Unicode(false)]
    public string Phone { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    [InverseProperty("User")]
    public virtual ICollection<Education> Educations { get; set; } = new List<Education>();

    [InverseProperty("User")]
    public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();

    [InverseProperty("User")]
    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    [InverseProperty("User")]
    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
