using HR.LeaveManagement.Application.Profies;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HR.LeaveManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services) 
        { 
            //The issue with this is that for every mapping you have, you will have to repeat this profile
            //services.AddAutoMapper(typeof(MappingProfile));

            //Why this work for every mapping profile
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
