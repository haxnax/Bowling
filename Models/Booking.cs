using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Bowling.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public int HoursToPlay { get; set; } = 1;
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public decimal PricePerHour
        {
            get
            {
                if (Customers.BookingCount % 5 ==0 && Customers.IsMember == true)
                {
                    return (90m * 0.8m);
                }
                else { return 90m; };
            }
            set;
        }
    }
}