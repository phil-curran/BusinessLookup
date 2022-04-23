using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLookup.Models
{
  [Table("Business")]
  public class Business
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public int Zip { get; set; }
    [Required]
    public string Phone { get; set; }
    [Required]
    public string Email { get; set; }
    public string Web { get; set; }
    public string Price { get; set; }
    [Required]
    public string Category { get; set; }
    [Required]
    public string Subcategory { get; set; }
  }
}
