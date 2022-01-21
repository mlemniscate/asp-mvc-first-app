 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFirstApp.Models
{
    public class BlogItem
    {
        public int Id { get; set; }
        [Display(Name = "تیتر")]
        [Required(ErrorMessage = "برای فیلد یک مقدار وارد کنید.")]
        [StringLength(20, MinimumLength = 6)]
        public string Titr { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "لینک")]
        [Required(ErrorMessage = "برای فیلد یک مقدار وارد کنید.")]
        public string Link { get; set; }
    }
}