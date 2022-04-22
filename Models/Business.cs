using System;

namespace BusinessLookup.Models
{
  public class Business
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Zip { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Web { get; set; }
    public string Price { get; set; }
    public string Category { get; set; }
    public string Subcategory { get; set; }
  }
}
