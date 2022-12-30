using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Child
{
    [Key] 
    public int id{ get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [Range(3, 6)]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
   // public List<Toy> Toys{ get; set; }
    public Child(){}
}