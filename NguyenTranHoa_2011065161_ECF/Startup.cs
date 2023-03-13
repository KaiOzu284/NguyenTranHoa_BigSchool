using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenTranHoa_2011065161_ECF.Startup))]
namespace NguyenTranHoa_2011065161_ECF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
