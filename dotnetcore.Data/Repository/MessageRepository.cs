using dotnetcore.Data.Context;
using dotnetcore.Domain.Interfaces;
using dotnetcore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore.Data.Repository
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(DataContext context)
            : base(context)
        {
        }
        public string GetMessage()
        {
            return "helloworld";
        }

    }
}
