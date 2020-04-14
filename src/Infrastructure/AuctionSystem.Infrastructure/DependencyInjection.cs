﻿namespace AuctionSystem.Infrastructure
{
    using System.Reflection;
    using Application.Common.Interfaces;
    using Application.Common.Models;
    using Common;
    using Identity;
    using MediatR;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddScoped<IUserManager, UserManagerService>()
                .AddTransient<IDateTime, MachineDateTime>();

            return services;
        }
    }
}
