using DotVVM.Framework.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DotvvmApplication1.Services;

namespace DotvvmApplication1
{
	public class ServiceConfigurator : IDotvvmServiceConfigurator
    {
        public void ConfigureServices(IDotvvmServiceCollection options)
        {
            options.Services.AddTransient(typeof(StudentService));
            options.Services.AddTransient(typeof(UserService));
        }
    }
}

