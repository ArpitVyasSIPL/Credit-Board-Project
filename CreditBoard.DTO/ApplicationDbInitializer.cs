using System.Data.Entity.Migrations;
using System.Data.Entity.SqlServer;

namespace CreditBoard.DTO
{
    class ApplicationDbInitializer : DbMigrationsConfiguration<CreditBoardContext>
    {
        public ApplicationDbInitializer()
        {
            SetSqlGenerator("System.Data.SqlClient", new SqlServerMigrationSqlGenerator());
        }
        protected override void Seed(CreditBoardContext context)
        {
            InitializeIdentityForEF(context);
            base.Seed(context);
        }
        //Create User=Admin@Admin.com with password=Admin@123456 in the Admin role        
        public void InitializeIdentityForEF(CreditBoardContext db)
        {
        }
    }
}
