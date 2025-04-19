using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjectApp.Models.DataLayer;

public partial class Item
{
    [Key]
    [Column("ItemID")]
    public int ItemId { get; set; }

    [StringLength(50)]
    public string? ItemName { get; set; }

    [StringLength(50)]
    public string? Category { get; set; }

    public int? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    public int? Threshold { get; set; }

    [StringLength(50)]
    public string? StockLvl { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
