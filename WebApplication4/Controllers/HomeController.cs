using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.DataAccessLayer;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var sliderImage = _dbContext.SliderImages.ToList();
            var slider = _dbContext.Sliders.SingleOrDefault();
            var categories = _dbContext.Categories.ToList();
            //var products = _dbContext.Products.Include(x => x.Category).ToList();
            var about = _dbContext.Abouts.SingleOrDefault();
            var aboutImage = _dbContext.AboutImages.SingleOrDefault();
            var suggestions = _dbContext.Suggestions.ToList();
            var expertsTitle = _dbContext.ExpertsTitles.SingleOrDefault();
            var expertsImage = _dbContext.ExpertsImages.ToList();
            var banner = _dbContext.Banners.SingleOrDefault();
            var blogTitle = _dbContext.BlogTitles.SingleOrDefault();
            var blogItem = _dbContext.BlogItems.ToList();
            var carousel = _dbContext.Carousels.ToList();
            var social = _dbContext.Socials.ToList();
            return View( new HomeViewModel 
            {
                SliderImages = sliderImage,
                Sldier = slider,
                Categories = categories,
                //Products = products,
                About = about,
                AboutImages = aboutImage,
                Suggestions = suggestions,
                ExpetsTitles = expertsTitle,
                ExpertsImages = expertsImage,
                Banner = banner,
                BlogTitle = blogTitle,
                BlogItems = blogItem,
                Carousels = carousel,
                Socials = social
            });
        }
    }
}
