using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JeTestEF.DAL;

public class Ingredient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IngredientId { get; set; }

    public long Name    { get; set; }
    public float Kcal   { get; set; }

    public long PizzaId { get; set; }
    public Pizza Pizza  { get; set; }


}
