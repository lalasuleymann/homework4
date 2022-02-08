using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class HomeViewModel
    {
        public List<SliderImage> SliderImages { get; set; }
        public Slider Sldier { get; set; }
        public List<Product> Products { get; set; }

        public List<Category> Categories { get; set; }
        public About About { get; set; }
        public AboutImage AboutImages { get; set; }
        public List<Suggestions> Suggestions { get; set; }
        public ExpertsTitle ExpetsTitles { get; set; }
        public List<ExpertsImage> ExpertsImages { get; set; }
        public Banner Banner { get; set; }
        public BlogTitle BlogTitle { get; set; }
        public List<BlogItem> BlogItems { get; set; }
        public List<Carousel> Carousels { get; set; }
        public List<Social> Socials { get; set; }

    }
}
