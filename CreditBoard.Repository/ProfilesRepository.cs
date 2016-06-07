using CreditBoard.DTO;
using CreditBoard.Shared;
using System.Data.Entity;
using System.Linq;

namespace CreditBoard.Repository
{
    public class ProfilesRepository : GenericRepository<Profile>, IProfilesRepository
    {
        public ProfilesRepository(DbContext context)
            : base(context)
        {

        }
        public Profile GetById(int id)
        {
            return FindBy(x => x.pkProfileId == id).FirstOrDefault();
        }
    }
}
