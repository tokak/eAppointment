namespace eAppointmentServer.Domain.Entities
{
    public sealed class Patient
    {
        public Patient()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Join(" ", FirstName, LastName);

        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string FullAddress { get; set; }
    }
}
