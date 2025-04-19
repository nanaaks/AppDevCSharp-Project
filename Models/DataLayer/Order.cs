using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProjectApp.Models.DataLayer;

public partial class Order
{
    [Key]
    public int OrderNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [StringLength(50)]
    public string? OrderType { get; set; }

    [StringLength(50)]
    public string? OrderStatus { get; set; }

    [Column("ItemID")]
    public int? ItemId { get; set; }

    [StringLength(50)]
    public string? ItemName { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("Orders")]
    public virtual Item? Item { get; set; }
}
