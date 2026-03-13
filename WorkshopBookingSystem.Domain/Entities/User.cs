namespace WorkshopBookingSystem.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public Guid ExternalId { get; set; }
    public string FirstName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}