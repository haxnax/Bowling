using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bowling.Data
{
    public class Bookings
    {
        public int Id { get; set; }
        [AllowedValues()]
        public DateTime BookingDate { get; set; } 

    }
}
