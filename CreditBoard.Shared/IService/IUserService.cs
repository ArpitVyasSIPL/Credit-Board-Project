using CreditBoard.DTO;

namespace CreditBoard.Shared
{
    public interface IUserService : IEntityService<User>
    {
        User GetById(int Id);
    }
}
