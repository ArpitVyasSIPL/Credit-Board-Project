using CreditBoard.DTO;

namespace CreditBoard.Shared
{
   public interface IProfilesService : IEntityService<Profile>
    {
        Profile GetById(int Id);
    }
}
