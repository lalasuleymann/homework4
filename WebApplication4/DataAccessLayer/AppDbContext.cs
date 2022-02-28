using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.DataAccessLayer
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
        public DbSet<Suggestions> Suggestions { get; set; }
        public DbSet<ExpertsTitle> ExpertsTitles { get; set; }
        public DbSet<ExpertsImage> ExpertsImages { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BlogTitle> BlogTitles { get; set; }
        public DbSet<BlogItem> BlogItems { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Bio> Bios { get; set; }
    }
}
