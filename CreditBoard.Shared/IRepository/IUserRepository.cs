using CreditBoard.DTO;

namespace CreditBoard.Shared
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetById(int id);
    }
}
