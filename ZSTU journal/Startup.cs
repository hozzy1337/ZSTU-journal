using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZSTU_journal.Startup))]
namespace ZSTU_journal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
