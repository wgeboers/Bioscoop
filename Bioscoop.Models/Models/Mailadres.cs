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
#pragma warning disable CS8618 // Non-nullable property 'mailadres' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string mailadres { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'mailadres' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}
