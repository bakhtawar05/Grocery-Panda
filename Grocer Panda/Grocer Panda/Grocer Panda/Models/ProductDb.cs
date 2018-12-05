using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Grocer_Panda.Models
{
    public class ProductDb
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        public string name { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> price { get; set; }
        public string image { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
        public string category { get; set; }
    }
}