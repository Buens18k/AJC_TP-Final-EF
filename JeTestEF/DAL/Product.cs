using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JeTestEF.DAL;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public long ProductId { get; set; }

    public string Name { get; set; }
    public decimal Price { get; set; }

    public ICollection<Order> Orders { get; set; }

}
