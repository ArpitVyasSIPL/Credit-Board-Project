using CreditBoard.DTO;

namespace CreditBoard.Shared
{
    public interface IProfilesRepository : IGenericRepository<Profile>
    {
        Profile GetById(int id);
    }
}
