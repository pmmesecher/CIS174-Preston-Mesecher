using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGamesMesecher.Models
{
    public class CountryViewModel
    {
        public Country Country { get; set; }
        public string ActiveGm { get; set; } = "all";
        public string ActiveCtgy { get; set; } = "all";
    }
}
