using dotnetcore.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcore.Core.Bus
{
   public interface IMediatorHandler
    {
        Task<string> SendCommand<T>(T command) where T : Command;
    }
}
