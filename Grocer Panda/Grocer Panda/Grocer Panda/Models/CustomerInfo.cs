using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grocer_Panda.Models
{
    public class CustomerInfo
    { 
        public string Customer_Name { get; set; }
        public string Pasword { get; set; }
        public string Email { get; set; }
        public Nullable<int> Phone_ { get; set; }
        public string city { get; set; }
    }
}