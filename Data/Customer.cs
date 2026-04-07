using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling.Data
{
    public class Customer
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int BookingCount { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
