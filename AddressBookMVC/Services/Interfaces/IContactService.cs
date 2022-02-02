using AddressBookMVC.Models;

namespace AddressBookMVC.Services.Interfaces
{
    public interface IContactService
    {
        public Task<Contact> GetContactByIdAsync(int Id);
    }
}
