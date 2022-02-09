using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.DataAccessLayer;

namespace WebApplication4.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var bio = _dbContext.Bios.SingleOrDefault();
            return View(bio);
        }
    }
}
