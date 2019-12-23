using System;
using System.Collections.Generic;
using System.Text;

namespace MertKaymaz_301Project.Data
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public string Color { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsPreOwned { get; set; }
        public bool IsCrashed { get; set; }

        public int Year { get; set; }
        public string Country { get; set; }

    }
}
