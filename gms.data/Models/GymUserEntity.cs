using Microsoft.AspNetCore.Identity;

namespace gms.data.Models;
public class GymUserEntity : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int GenderId { get; set; }
    public DateOnly BirthDate { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
}
