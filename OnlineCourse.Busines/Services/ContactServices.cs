namespace OnlineCourse.Busines
{
    public class ContactServices(IContactRepository contactRepository, IMapper mapper) : IContactService
    {
        readonly IContactRepository _contactRepository = contactRepository;
        readonly IMapper _mapper = mapper;

        public bool AddContact(ContactDto contactDto)
        {
            var contact = _mapper.Map<Contact>(contactDto);
            return _contactRepository.Add(contact);
        }

        public bool DeleteContact(int id)
        {
            return _contactRepository.Remove(id);
        }

        public IEnumerable<ContactDto> GetAllContacts()
        {
            var contactAll = _contactRepository.GetAll();
            return _mapper.Map<List<ContactDto>>(contactAll);
        }

        public ContactDto GetContactById(int id)
        {
            var contactById = _contactRepository.Get(id);
            return _mapper.Map<ContactDto>(contactById);
        }

        public bool UpdateContact(ContactDto contactDto)
        {
            var contactUpdate=_contactRepository.Get(contactDto.ContactId);
            if (contactUpdate == null)
            {
                return false;
            }
            _mapper.Map(contactUpdate, contactDto);
            return _contactRepository.Update(contactUpdate);
        }
    }
}
