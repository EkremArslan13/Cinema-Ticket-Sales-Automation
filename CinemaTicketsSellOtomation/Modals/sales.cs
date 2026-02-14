using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Modals
{
    public class sales : BaseClass
    {
        public sales()
        {
            creationDate = DateTime.Now.ToString();
        }
        public string creationDate { get; set; }
        public decimal totalPrice { get; set; }
        public int count { get; set; }

        public string sessionTime { get; set; }

        public override string ToString() // polymorpihsm
        {
            return $"{movieName} adlı filmin {sessionTime} seansına {count} adet bilet kesilmiştir. Toplam tutar = {totalPrice} tl | satın alınma tarihi = {creationDate}";
        }
    }
}
