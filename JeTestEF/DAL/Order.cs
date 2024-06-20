using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JeTestEF.DAL;

public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int Status { get; set; }

    public int DeliveryAddressId { get; set; }
    public Adresse DeliveryAddresse { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }

    public ICollection<Product> Products { get; set; }

}
