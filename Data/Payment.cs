using System;
using System.Collections.Generic;
using System.Text;

namespace MertKaymaz_301Project.Data
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool HasInstallment { get; set; }
        public int InstallmentNumber { get; set; }
        public string PaymentMethod { get; set; }
    }
}
