﻿using LoginChecker.Application.Service.Logins;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginCheker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LogInController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public Task<string> Login(string email, string password)
        {
           return _loginService.SendMessage(email, password);
        }
    }
}
