using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.DataAccessLayer;
using WebApplication4.Models;
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
            HttpContext.Session.SetString("session","WebApp6");

            Response.Cookies.Append("cookie", "WebbApp");
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
        public async Task<IActionResult> Basket() 
        {
            //var session = HttpContext.Session.GetString("session");
            //var cookie = Request.Cookies["cookie"];
            //return Content(session + "-" + cookie);
            var basket = Request.Cookies["basket"];
            if (string.IsNullOrEmpty(basket))
            {
                return Content("Empty");
            }

            var basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(basket);

            var newBasket = new List<BasketViewModel>();
            foreach (var basketViewModel in basketViewModels)
            {
                var product = await _dbContext.Products.FindAsync(basketViewModel.Id);
                if (product == null)
                    continue;
                newBasket.Add(new BasketViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Image = product.Image,
                    Count = basketViewModel.Count
                });
            }
            basket = JsonConvert.SerializeObject(basketViewModels);
            Response.Cookies.Append("basket", basket);

            return Json(newBasket);
        }
        public async Task<IActionResult> AddToBasket(int? id) 
        {
            if (id == null)
                return BadRequest();

            var product = await _dbContext.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            List<BasketViewModel> basketViewModels;
            var existBasket = Request.Cookies["basket"];
            if (string.IsNullOrEmpty(existBasket))
            {
                basketViewModels = new List<BasketViewModel>();
            }
            else
            {
                basketViewModels = JsonConvert.DeserializeObject<List<BasketViewModel>>(existBasket);
            }
            var existBasketViewModel = basketViewModels.FirstOrDefault(x => x.Id == id);
            if (basketViewModels == null)
            {
                existBasketViewModel = new BasketViewModel
                {
                    Id = product.Id,
                };
                basketViewModels.Add(existBasketViewModel);
            }
            else
            {
                existBasketViewModel.Count++;
            }

            var basket = JsonConvert.SerializeObject(basketViewModels);
            Response.Cookies.Append("basket", basket);
            return RedirectToAction(nameof(Index));
        }
    }
}
