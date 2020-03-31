using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcore.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore.Api.Controllers
{
    public class MessageController : ControllerBase
    {
        private readonly IMessageAppService _messageAppService;
        public MessageController(
            IMessageAppService messageAppService)
        {
            _messageAppService = messageAppService;
        }
        [HttpGet]
        [Route("message/list-all")]
        public IActionResult Get()
        
        
        {
            return Ok(_messageAppService.GetMessage());
        }
    }
}