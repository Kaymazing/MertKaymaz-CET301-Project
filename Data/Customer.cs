using System;
using System.Collections.Generic;
using System.Text;

namespace MertKaymaz_301Project.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool HasLicence { get; set; }
        public DateTime LicenceEndDate { get; set; }
        public bool HasCriminalRecord { get; set; }



    }
}
