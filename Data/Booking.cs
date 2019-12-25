using System;
using System.Collections.Generic;
using System.Text;

namespace MertKaymaz_301Project.Data
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsSold { get; set; }
        public string HirePoint { get; set; }
        public string DropPoint { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
    }
}
