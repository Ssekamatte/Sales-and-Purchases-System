using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sales.Data;
using Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sales.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAPIController : ControllerBase
    {
        private SalesPurchasesContext db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public LoginAPIController(SignInManager<IdentityUser> signInManager,
           UserManager<IdentityUser> userManager, SalesPurchasesContext _db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            db = _db;
        }
        // GET: api/<LoginAPIController>
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return new string[] { "Success" };
            }
            catch (Exception ex)
            {
                return new string[] { ex.ToString() };
            }
        }

        // GET api/<LoginAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginAPIController>
        [HttpPost]
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Post([FromBody] LoginModel Logindetails)
        {
            var result = await _signInManager.PasswordSignInAsync(Logindetails.Email, Logindetails.Password, Logindetails.RememberMe, lockoutOnFailure: false);
            return result;
        }

        // PUT api/<LoginAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
