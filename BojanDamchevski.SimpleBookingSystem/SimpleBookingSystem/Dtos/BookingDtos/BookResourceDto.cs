using System;

namespace Dtos.BookingDtos
{
    public class BookResourceDto
    {
        public int ResourceId { get; set; }
        public int Quantity { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }
}
