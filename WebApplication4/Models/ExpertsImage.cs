using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class ExpertsImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
