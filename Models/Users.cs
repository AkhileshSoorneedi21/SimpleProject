using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Users
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string firstname { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        public int mobileNumber { get; set; }

        public Users()
        {

        }
    }
}
