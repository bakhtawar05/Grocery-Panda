using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Grocer_Panda.Models
{
    public class Admin
    {
        public int id { get; set; }
        [Display(Name ="Username")]
        [DataType(DataType.Text)]
        public string name { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="At 6 characters")]
        public string password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("password",ErrorMessage ="password doesnot match")]
        public string confirmPassword { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact")]
        public Nullable<int> contact { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name ="Store Name")]
        public string storeName { get; set; }
    }
}