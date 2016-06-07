using CreditBoard.DTO;
using CreditBoard.Shared;

namespace CreditBoard.Service
{
  public class ProfilesService : EntityService<Profile>, IProfilesService
    {
        IUnitOfWork _unitOfWork;
        IProfilesRepository _profilesRepository;

        public ProfilesService(IUnitOfWork unitOfWork, IProfilesRepository profilesRepository)
            : base(unitOfWork, profilesRepository)
        {
            _unitOfWork = unitOfWork;
            _profilesRepository = profilesRepository;
        }
        public Profile GetById(int Id)
        {
            return _profilesRepository.GetById(Id);
        }
    }
}
