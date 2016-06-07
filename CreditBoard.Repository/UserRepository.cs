using CreditBoard.DTO;
using CreditBoard.Shared;
using System.Data.Entity;
using System.Linq;

namespace CreditBoard.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context)
            : base(context)
        {

        }
        public User GetById(int id)
        {
            return FindBy(x => x.pkUserId == id).FirstOrDefault();
        }
    }
}
