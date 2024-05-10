using System.ComponentModel.DataAnnotations;

namespace Models;

public class PurchaseOrderItem
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int PurchaseOrderId { get; set; }
    
    public virtual PurchaseOrder PurchaseOrder { get; set; } // 1:n with PurchaseOrder

    [Required]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; } // 1:n with Product

    [Required]
    public int ProductQuantity { get; set; }
}