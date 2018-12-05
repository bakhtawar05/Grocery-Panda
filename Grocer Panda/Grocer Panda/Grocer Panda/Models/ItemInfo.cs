using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grocer_Panda.Models
{
    public class ItemInfo
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string item_image { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<int> quantity { get; set; }
        public string category { get; set; }
    }
}