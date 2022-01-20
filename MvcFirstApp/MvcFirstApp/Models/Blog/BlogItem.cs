using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFirstApp.Models
{
    public class BlogItem
    {
        [Display(Name = "تیتر")]
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Titr { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "لینک")]
        [Required]
        public string Link { get; set; }
    }
}