using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookCrossingBack.src.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookCrossingBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public User Get()
        {
            var testUser = new User() { Id = 0, FirstName = "Roman", LastName = "Ferents", MiddleName = "Andriyovych", Email = "ferencrman@gmail.com", Password = 1234};
            return testUser;
        }
    }
}
