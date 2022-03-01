using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WebApplication4.DataAccessLayer;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Areas.AdminPanel.Controllers
{
    public class UserController : Controller
    {

        private readonly AppDbContext _dbContext;
        private readonly UserManager<User> _userManager;


        public UserController(AppDbContext dbContext, UserManager<User> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        [Area("AdminPanel")]
        public IActionResult Index()
        {
            var users = _dbContext.Users.ToList();
            return View(users);
        }
        public IActionResult Details()
        {
            var users = _dbContext.Users.ToList();
            if (users == null)
                return NotFound();

            return View(users);
        }
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ChangePassword(AccountViewModel account)
        {
            var user = await _userManager.FindByEmailAsync(account.Email);
            if (user == null)
                return BadRequest();

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            string link = Url.Action(nameof(ResetPassword), "Account", new { email = user.Email, token }, Request.Scheme, Request.Host.ToString());

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("codep320@gmail.com", "Fiorello");
            msg.To.Add(user.Email);

            string body = string.Empty;
            using (StreamReader reader = new StreamReader("wwwroot/assets/template/verifyemail.html"))
            {
                body = reader.ReadToEnd();
            }

            msg.Body = $"<a href= \"{link}\">Click for Reset Password</a>";
            msg.Subject = "ResetPassword";
            msg.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("codep320@gmail.com", "codeacademyp320");
            smtp.Send(msg);

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ResetPassword(string email, string token)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return BadRequest();
            var account = new AccountViewModel()
            {
                Token = token,
            };
            return View(account);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> ResetPassword(AccountViewModel account)
        {
            if (!ModelState.IsValid)
                return View(account);

            var user = _userManager.FindByEmailAsync(account.Email);
            if (user == null)
                return NotFound();

            var user1 = new User
            {
                Email = account.Email,
                UserName = account.Username,
                FullName = account.Fullname
            };

            var result = await _userManager.ResetPasswordAsync(user1, account.Token, account.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(account);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
