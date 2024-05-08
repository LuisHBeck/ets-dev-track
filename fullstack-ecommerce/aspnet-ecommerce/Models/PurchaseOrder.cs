using System.ComponentModel.DataAnnotations;

namespace Models;

public class PurchaseOrder
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public int ClientId { get; set; }

    public virtual ICollection<PurchaseOrderItem> Items { get; set; } // n:1 with PurchaseOrderItem

}