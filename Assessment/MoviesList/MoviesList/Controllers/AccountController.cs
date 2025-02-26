using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using MoviesList.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MoviesList.Controllers
{

    //[Route("Account")]
    public class AccountController : Controller
    {
        [HttpGet]

        //[Route("Login/{ReturnUrl}")]
        public IActionResult Login(string ReturnUrl)
        {
            ViewData.Add("ReturnUrl", ReturnUrl);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserDetails user, string ReturnUrl)
        {
            if (user.Username == "admin" && user.Password == "admin123")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username)
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity));
                return Redirect(ReturnUrl);
            } else {
                ViewData.Add("ReturnUrl", ReturnUrl);
                ViewData.Add("Message", "Invalid Username/Password");
                return View(user);
            }
            
        }

        public IActionResult Denied()
        {
            return View();
        }
    }
}
