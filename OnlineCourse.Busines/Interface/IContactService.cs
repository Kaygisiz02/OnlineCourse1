namespace OnlineCourse.Busines
{
    public interface IContactService
    {
        ContactDto GetContactById(int id);
        IEnumerable<ContactDto> GetAllContacts();
        bool AddContact(ContactDto contactDto);
        bool UpdateContact(ContactDto contactDto);
        bool DeleteContact(int id);
    }
}
