using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JeTestEF.DAL;

public class Adresse
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //Clé primaire
    public int AdresseId { get; set; }

    public string Street { get; set; }

    public string City { get; set; }

    public string State { get; set; }
    
    public string Zip { get; set; }

    public string Country { get; set; }

    public ICollection<User> Users { get; set; }

    public ICollection<Order> Orders { get; set; }

}
