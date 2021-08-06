using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advance_Furniture.Models
{
    public class Furniture
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        public int Price{ get; set; }

        [Display(Name = " Specification")]
        public string description { get; set; }


    }
}
