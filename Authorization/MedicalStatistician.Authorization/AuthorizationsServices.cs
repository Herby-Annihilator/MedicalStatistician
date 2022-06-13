using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Authorization
{
    public static class AuthorizationsServices
    {
        public static IServiceCollection AddServerAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization();
            return services;
        }
    }
}
