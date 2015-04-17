using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using LifeLine.Core.Interfaces;
using LifeLine.Infrastructure;

namespace LifeLine.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
           // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IBloodDonorRepository, BloodDonorRepository>();            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}