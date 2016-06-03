using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreditBoard.Startup))]
namespace CreditBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
