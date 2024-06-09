using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace kolokwium_apbd.Models;

public class Client
{
    [Key, Required] 
    public int IdClient  { get; set; }
    [Required, MaxLength(100)]  
    public string FirstName { get; set; }
    [Required, MaxLength(100)]  
    public string LastName { get; set; }
    [Required, MaxLength(100)]  
    public string Email { get; set; }

    [MaxLength(100)] 
    public string Telephone { get; set; } = null;
}