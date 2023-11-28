
namespace PacificPrint.Shop.Core.Models
{
    public class UserDTO
    {
        public Guid Id {get; set;}
        public string FirstName {get; set;}
        public string? OptionalName {get; set;}
        public string? MiddleName {get; set;}
        public string? LastName {get; set;}
        public string Email {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}
        public int Role {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    }
}
