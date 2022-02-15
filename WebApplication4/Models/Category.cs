using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field must not be Empty"), MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
