namespace OnlineCourse.Busines
{
    public class MessageServices(IMessageRepository messageRepository, IMapper mapper) : IMessageService
    {
        readonly IMessageRepository _messageRepository = messageRepository;
        readonly IMapper _mapper = mapper;
        public bool AddMessage(MessageDto messageDto)
        {
            var added = _mapper.Map<Message>(messageDto);
            return _messageRepository.Add(added);

        }

        public bool DeleteMessage(int id)
        {
            return _messageRepository.Remove(id);
        }

        public IEnumerable<MessageDto> GetAllMessage()
        {
            var getAll = _messageRepository.GetAll();
            return _mapper.Map<IEnumerable<MessageDto>>(getAll);
        }

        public MessageDto GetMessageById(int id)
        {
            var getById = _messageRepository.Get(id);
            return _mapper.Map<MessageDto>(getById);
        }

        public bool UpdateMessage(MessageDto messageDto)
        {
            var messageUpdate = _messageRepository.Get(messageDto.MesageId);
            if (messageUpdate == null)
            {
                return false;
            }
            _mapper.Map(messageUpdate, messageDto );
            return _messageRepository.Update(messageUpdate);
        }
    }
}
