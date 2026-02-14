using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Modals
{
    public class chair
    {
        public chair(string _Row,string _Number)
        {
            row = _Row;
            number = _Number;
            
        }


        public string row { get; set; } //abcd
        public string number { get; set; } // 123456
        public bool status { get; set; } //boş dolu

    }
}
