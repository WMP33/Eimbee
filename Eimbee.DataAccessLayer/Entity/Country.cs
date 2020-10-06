﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eimbee.DataAccessLayer.Entity
{

    public class Country
    {
        [Key]
        public string Iso2 { get; set; }        
        public string Iso3 { get; set; }
        public string Capital { get; set; }
        public string CurrencyCode { get; set; }
        public string FipsCode { get; set; }
        public string Continent { get; set; }
        public string Name { get; set; }
        public int IsoNumeric { get; set; }
        public int PhonePrefix { get; set; }
        public int Population { get; set; }
        public List<City> Cities { get; set; }
    }
}

