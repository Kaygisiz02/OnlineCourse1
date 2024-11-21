using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Busines
{
    public class SubscribeServices(ISubscribeRepository subscribeRepository, IMapper mapper) : ISubscribeService
    {
        private readonly ISubscribeRepository _subscribeRepository = subscribeRepository;
        private readonly IMapper _mapper = mapper;
        public bool AddSubscribe(SubscribeDto subscribeDto)
        {
            var subscribeAdd = _mapper.Map<Subscribe>(subscribeDto);
            return _subscribeRepository.Add(subscribeAdd);
        }

        public bool DeleteSubscribe(int id)
        {
            return _subscribeRepository.Remove(id);
        }

        public IEnumerable<SubscribeDto> GetAllSubscribe()
        {
            var getAll = _subscribeRepository.GetAll();
            return _mapper.Map<List<SubscribeDto>>(getAll);
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
            _mapper.Map(subscribeUpdate, subscribeDto);
            return _subscribeRepository.Update(subscribeUpdate);
        }
    }
}
