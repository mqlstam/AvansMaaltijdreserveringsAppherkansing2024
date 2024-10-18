using Microsoft.AspNetCore.Identity;

namespace AvansMaaltijdreserveringsApp.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime DateOfBirth { get; set; }
        public string? StudentNumber { get; set; }
        public string? StudyCity { get; set; }
    }
}
