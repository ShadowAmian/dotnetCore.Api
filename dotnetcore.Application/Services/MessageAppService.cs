using dotnetcore.Application.Interfaces;
using dotnetcore.Core.Bus;
using dotnetcore.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcore.Application.Services
{
    public class MessageAppService : IMessageAppService
    {
        private readonly IMediatorHandler Bus;
        public async Task<string> GetMessage()
        {
            var response = await Bus.SendCommand(new NewMessageCommand());

            return response;
        }
    }
}
