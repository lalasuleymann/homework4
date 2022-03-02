using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WebApplication4.Areas.AdminPanel.ViewModels;
using WebApplication4.Data;
using WebApplication4.DataAccessLayer;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Areas.AdminPanel.Controllers
{
    public class UserController : Controller
    {

        private readonly AppDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(AppDbContext dbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
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
        public async Task<IActionResult> ChangePassword(string id)
        {
            var existUser = await _userManager.FindByIdAsync(id);
            if (existUser == null)
                return NotFound();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string id, ChangePasswordViewModel changePasswordViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Invalid Credential");
                return View(changePasswordViewModel);
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            var isCurrentPassword = await _userManager.CheckPasswordAsync(user, changePasswordViewModel.CurrentPassword);
            if (!isCurrentPassword)
                return BadRequest();

            var result = await _userManager.ChangePasswordAsync(user, changePasswordViewModel.CurrentPassword, changePasswordViewModel.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                    return View();
                }
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ChangeRole(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            var roles = await _userManager.GetRolesAsync(user);
            ViewBag.CurrentRoleName = roles.FirstOrDefault();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id, ChangeRoleViewModel changeRoleViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Invalid Credential");
                return View(changeRoleViewModel);
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            var currentRole = await _userManager.GetRolesAsync(user);
            foreach (var item in currentRole)
            {
                await _userManager.RemoveFromRoleAsync(user, item);
            }

            var newRole = _roleManager.Roles.FirstOrDefault(x => x.Id == changeRoleViewModel.RoleId);
            if (newRole == null)
            {
                ModelState.AddModelError("", "Choose correct Role");
                return View(changeRoleViewModel);
            }

            var result = await _userManager.AddToRoleAsync(user, newRole.Name);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(changeRoleViewModel);
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ChangeStatus(string id, bool status)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            user.IsActive = !status;

            await _userManager.UpdateAsync(user);

            return RedirectToAction("Index");
        }
    }
}
