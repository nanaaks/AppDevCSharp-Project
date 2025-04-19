using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjectApp.Models.DataLayer;

public partial class User
{
    [Key]
    [StringLength(50)]
    public string UserId { get; set; } = null!;

    [StringLength(50)]
    public string? Password { get; set; }

    [StringLength(50)]
    public string? Firstname { get; set; }

    [StringLength(50)]
    public string? Lastname { get; set; }

    [StringLength(50)]
    public string? Job { get; set; }
}
