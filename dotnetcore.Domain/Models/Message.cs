using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore.Domain.Models
{
    public class Message
    {
        public Guid Id { get; protected set; }

        public string Name { get; set; }
        public string Content { get; set; }
    }
}
