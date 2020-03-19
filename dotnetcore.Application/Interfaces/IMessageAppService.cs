using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcore.Application.Interfaces
{
   public  interface IMessageAppService
    {
        Task<string> GetMessage();
    }
}
