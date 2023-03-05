using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Models.Models
{
    public class Mailadres
    {
        [Required]
        public string mailadres { get; set; }
    }
}
