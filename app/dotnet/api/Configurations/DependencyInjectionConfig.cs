using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace api.Configurations
{
     public class DependencyInjectionAttribute : Attribute
    {
        public readonly ServiceLifetime ServiceLifetime;

        public DependencyInjectionAttribute(ServiceLifetime serviceLifetime)
        {
            ServiceLifetime = serviceLifetime;
        }
    }
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            var implementedTypes = GetTypesWith<DependencyInjectionAttribute>(true);

            foreach (var implementedType in implementedTypes)
            {
                var types = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.GetInterfaces().Contains(implementedType));

                foreach (var type in types)
                {
                    var attribute = implementedType.GetCustomAttribute<DependencyInjectionAttribute>();
                    if (attribute != null)
                        services.Add(new ServiceDescriptor(implementedType, type, attribute.ServiceLifetime));
                }
            }

            return services;
        }

        private static IEnumerable<Type> GetTypesWith<TAttribute>(bool inherit) where TAttribute : Attribute
        {
            return from a in AppDomain.CurrentDomain.GetAssemblies()
                   from t in a.GetTypes()
                   where t.IsDefined(typeof(TAttribute), inherit)
                   select t;
        }
    }
}