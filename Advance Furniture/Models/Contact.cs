using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advance_Furniture.Models
{
    public class Contact
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }



        [Display(Name = "Email")]
        public string PName { get; set; }

        [Display(Name = "Message")]
        public string Msg { get; set; }


        [Display(Name = " Date ")]
        public DateTime Msgdate { get; set; }
    }
}
