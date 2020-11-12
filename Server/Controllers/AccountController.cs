using blazor_mysql2.Server;
using Microsoft.AspNetCore.Mvc;
using blazor_mysql2.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authentication;

[ApiController]
[Route("[controller]")]
public class AccountController : Controller
{
    private readonly AppDbContext db;

    public AccountController(AppDbContext db)
    {
        this.db = db; //Injeção de Dependência!!!
    }
    
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        private bool ValidateLogin(string userName, string password)
        {
            // For this sample, all logins are successful.
            return true;
        }

        
        [HttpPost("loginuser")]
        public async Task<ActionResult<User>> LoginUser(LoginDto loginDto)
        {
            User loggedInUser = await db.Users.Where(u => u.Email == loginDto.Email && u.Password == loginDto.Password).FirstOrDefaultAsync();

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }

