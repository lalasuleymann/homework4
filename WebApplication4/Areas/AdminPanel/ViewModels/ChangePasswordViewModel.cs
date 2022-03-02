using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Areas.AdminPanel.ViewModels
{
    public class ChangePasswordViewModel
    {

        [Required, DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
    }
}
