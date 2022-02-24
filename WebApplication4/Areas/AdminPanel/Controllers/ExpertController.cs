using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Areas.AdminPanel.Data;
using WebApplication4.DataAccessLayer;
using WebApplication4.Models;

namespace WebApplication4.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ExpertController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IWebHostEnvironment _environment;

        public ExpertController(AppDbContext dbContext, IWebHostEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            var expertImages = await _dbContext.ExpertsImages.ToListAsync();
            return View(expertImages);
        }

        //public IActionResult Create() 
        //{
        //    return View();
        //}

        //public async Task<IActionResult> Create(ExpertsImage expertsImage) 
        //{
        //    if (!ModelState.IsValid)
        //        return View();

        //    if (expertsImage.Photo.IsImage()) 
        //    {
        //        ModelState.AddModelError("Photo", "File should be Image");
        //        return View();
        //    }

        //    if (expertsImage.Photo.IsAllowedSize(1))
        //    {
        //        ModelState.AddModelError("Photo", "File should not be Bigger than 1Mb");
        //        return View();
        //    }

        //    var fileName = await expertsImage.Photo.GenetareFile(Constants.ImageFolderPath);

        //    expertsImage.Name = fileName;
        //    await _dbContext.ExpertsImages.AddAsync(expertsImage);
        //    await _dbContext.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index));
        //}

        public async Task<IActionResult> Update(int? id) 
        {
            if (id == null)
                return NotFound();

            var expertImage = await _dbContext.ExpertsImages.FindAsync(id);
            if (expertImage == null)
                return NotFound();

            return View(expertImage);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Update(int? id, ExpertsImage expertsImage) 
        {
            if (id == null)
                return NotFound();

            if(id != expertsImage.Id)
                return BadRequest();

            var existExpertImage = await _dbContext.ExpertsImages.FindAsync(id);
            if (existExpertImage == null)
                return NotFound();

            if(!ModelState.IsValid)
                return View();

            if (expertsImage.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "File should be Image");
                return View();
            }

            if (expertsImage.Photo.IsAllowedSize(1))
            {
                ModelState.AddModelError("Photo", "File should not be Bigger than 1Mb");
                return View();
            }

            var path = Path.Combine(Constants.ImageFolderPath, existExpertImage.Name);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            var fileName = await expertsImage.Photo.GenetareFile(Constants.ImageFolderPath);
            existExpertImage.Name = fileName;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var expertImage = await _dbContext.ExpertsImages.FindAsync(id);
            if (expertImage == null)
                return NotFound();

            return View(expertImage);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteItem(int? id) 
        {
            if (id == null)
                return NotFound();

            var existExpertImage = await _dbContext.ExpertsImages.FindAsync(id);
            if (existExpertImage == null)
                return NotFound();

            if (!ModelState.IsValid)
                return View();

            var path = Path.Combine(Constants.ImageFolderPath, existExpertImage.Name);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _dbContext.ExpertsImages.Remove(existExpertImage);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Create(ExpertsImage expertsImage)
        {
            if (!ModelState.IsValid)
                return View();
            foreach (var photo in expertsImage.Photos)
            {
            if (photo.IsImage())
            {
                ModelState.AddModelError("Photo", $"{photo.FileName} - File should be Image");
                return View();
            }

            if (photo.IsAllowedSize(1))
            {
                ModelState.AddModelError("Photo", $"{photo.FileName} - File should not be Bigger than 1Mb");
                return View();
            }

            var fileName = await photo.GenetareFile(Constants.ImageFolderPath);

                var newExpertImage = new ExpertsImage { Name = fileName };
                await _dbContext.ExpertsImages.AddAsync(newExpertImage);
                await _dbContext.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }
    }
}
