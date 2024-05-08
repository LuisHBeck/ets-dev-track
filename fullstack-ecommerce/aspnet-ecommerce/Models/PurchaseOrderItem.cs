using System.ComponentModel.DataAnnotations;

namespace Models;

public class PurchaseOrderItem
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int ProductId { get; set; }

    [Required]
    public int ProductQuantity { get; set; }

    public virtual PurchaseOrder PurchaseOrder { get; set; } // 1:n with PurchaseOrder
}