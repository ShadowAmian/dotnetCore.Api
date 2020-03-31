using dotnetcore.Application.Interfaces;
using dotnetcore.Application.Services;
using dotnetcore.Core.Bus;
using dotnetcore.Data.Repository;
using dotnetcore.Domain.CommandHandlers;
using dotnetcore.Domain.Commands;
using dotnetcore.Domain.Interfaces;
using dotnetCore.Infra.Ioc;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCore.Api.Extensions
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
