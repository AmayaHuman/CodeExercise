using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeExercise.Startup))]
namespace CodeExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
