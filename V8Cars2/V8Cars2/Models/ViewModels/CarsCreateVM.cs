using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace V8Cars2.Models.ViewModels
{
    public class CarsCreateVM
    {
        [Required]
        [Display(Name ="Make")]
        public string Brand { get; set; }
        [Required]
        [Range(2,4)]
        public int Doors { get; set; }
        [Required]
        [Range(0,300)]
        public int TopSpeed { get; set; }
    }
}
