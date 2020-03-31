using dotnetcore.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore.Domain.Commands
{
    public class NewMessageCommand : Command
    {
        public override bool IsValid()
        {
            return true;
        }
    }
}
