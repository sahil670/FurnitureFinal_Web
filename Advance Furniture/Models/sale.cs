using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advance_Furniture.Models
{
    public class sale
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }



        [Display(Name = "Product Name")]
        public string PName { get; set; }

        [Display(Name = "Quantity")]
        public int Qty { get; set; }


        [Display(Name = "Price")]
        public int Price { get; set; }

        [Display(Name =" Date ")]
        public DateTime Billdate { get; set; }

public Furniture furniture { get; set; }

    }
}
