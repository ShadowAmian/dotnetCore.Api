using dotnetcore.Core.Bus;
using dotnetcore.Domain.Commands;
using dotnetcore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dotnetcore.Domain.CommandHandlers
{
    public class MessageCommandHandler : IRequestHandler<NewMessageCommand, string>
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IMediatorHandler Bus;
        public Task<string> Handle(NewMessageCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                return Task.FromResult("");
            }
            return Task.FromResult(_messageRepository.GetMessage());
        }
    }
}
