using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riget_Zoo_Adventures
{
    internal class Booking
    {
        public int RoomId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CreditCardNumber { get; set; }
    }
}
