using dotnetcore.Application.Interfaces;
using dotnetcore.Application.Services;
using dotnetcore.Core.Bus;
using dotnetcore.Data.Context;
using dotnetcore.Data.Repository;
using dotnetcore.Domain.CommandHandlers;
using dotnetcore.Domain.Commands;
using dotnetcore.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetCore.Infra.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Application
            services.AddScoped<IMessageAppService, MessageAppService>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<NewMessageCommand, string>, MessageCommandHandler>();

            //Data - Repository
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<DataContext>();
        }
    }
}
