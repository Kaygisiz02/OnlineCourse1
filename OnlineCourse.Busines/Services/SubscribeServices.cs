using OnlineCourse.Repository;
using OnlineCourse.Repository.Abstract;

namespace OnlineCourse.Busines
{
    public class SubscribeServices(ISubscribeRepository subscribeRepository, IMapper mapper) : ISubscribeService
    {
        readonly ISubscribeRepository _subscribeRepository = subscribeRepository;
        readonly IMapper _mapper = mapper;
        public bool AddSubscribe(SubscribeDto subscribeDto)
        {
            var addedSubscribe = _mapper.Map<Subscribe>(subscribeDto);
            return _subscribeRepository.Add(addedSubscribe);

        }

        public bool DeleteSubscribe(int id)
        {
            return _subscribeRepository.Remove(id);
        }

        public IEnumerable<SubscribeDto> GetAllSubscribe()
        {
            var getAllSubscribe = _subscribeRepository.GetAll();
            return _mapper.Map<IEnumerable<SubscribeDto>>(getAllSubscribe);
        }

        public SubscribeDto GetSubscribeById(int id)
        {
            var getById = _subscribeRepository.Get(id);
            return _mapper.Map<SubscribeDto>(getById);
        }

        public bool UpdateSubscribe(SubscribeDto subscribeDto)
        {
            var subscribeUpdate = _subscribeRepository.Get(subscribeDto.SubscribeId);
            if (subscribeUpdate == null)
            {
                return false;
            }
            _mapper.Map(subscribeDto, subscribeUpdate);
            return _subscribeRepository.Update(subscribeUpdate);
        }
    }
}
