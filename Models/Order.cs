using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp2.Models;

public class Order
{
    public int Id { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }
    [StringLength(80)]
    public string Description { get; set; } = string.Empty;
   
    [StringLength(20)]
    public string Status { get; set; } = string.Empty;

    [Column(TypeName ="decimal(11,2)")]
    public decimal Total { get; set; }

    //FK
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }

}
