using CreditBoard.DTO;
using CreditBoard.Shared;

namespace CreditBoard.Service
{
    public class UserService : EntityService<User>, IUserService
    {
        IUnitOfWork _unitOfWork;
        IUserRepository _userRepository;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepository)
            : base(unitOfWork, userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }        
        public User GetById(int Id)
        {
            return _userRepository.GetById(Id);
        }
    }
}
