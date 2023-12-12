using SharedLibrary.Models;

namespace SharedLibrary.Interfaces
{
    public interface ICustomer : IContactPerson
    {
         string Email { get; set; }
         string Adress { get; set; }
         Guid Id { get; set; }
    }
}