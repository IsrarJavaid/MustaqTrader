using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MushtaqTraders.Startup))]
namespace MushtaqTraders
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
