using IdentityDataProtection.DbContext;
using IdentityDataProtection.Entities;
using IdentityDataProtection.Models;
using IdentityDataProtection.Protection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDataProtection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IdentityDbContext _context;
        private readonly DataProtection _dataProtection;

        public UserController(IdentityDbContext context, DataProtection dataProtection)
        {
            _context = context;
            _dataProtection = dataProtection;
        }


        [HttpPost]
        public async Task<IActionResult> AddUser(RegisterRequest request)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userEntity = new UserEntity
            {
                Email = request.Email,
                Password = _dataProtection.Protect(request.Password)

            };

            _context.Add(userEntity);
            _context.SaveChanges();

            return Ok(userEntity);
        }

    }
}
