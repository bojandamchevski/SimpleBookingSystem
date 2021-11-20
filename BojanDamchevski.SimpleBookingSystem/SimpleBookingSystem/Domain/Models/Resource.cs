using System.Collections.Generic;

namespace Domain.Models
{
    public class Resource : BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public List<Booking> Bookings { get; set; }

        public Resource()
        {
            Bookings = new List<Booking>();
        }
    }
}
