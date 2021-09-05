using System;
using KnowledgeUberization.Models;
using KnowledgeUberization.Providers;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeUberization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserProvider _provider;
        public UserController(IUserProvider provider)
        {
            this._provider = provider;
        }

        [HttpPost]
        public void AddUserModel(User user)
        {
            _provider.Add(new UserAddExt
            {
                Age = user.Age,
                Name = user.Name,
                Password = user.Password,
                Role = user.Role,
                CreatedAt = DateTime.Now
            });
        }
    }
}