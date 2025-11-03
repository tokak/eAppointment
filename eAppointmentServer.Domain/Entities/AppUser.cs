using Microsoft.AspNetCore.Identity;

namespace eAppointmentServer.Domain.Entities
{
    public sealed class AppUser :IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Join(" ",FirstName,LastName);
    }
}
