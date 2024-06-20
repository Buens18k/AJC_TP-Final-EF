using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JeTestEF.DAL;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public long UserId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Phone { get; set; }
    public string Mail { get; set; }

    public int AdresseId { get; set; }
    public Adresse Adresse { get; set; }

    public ICollection<Order> Orders { get; set; }
}
