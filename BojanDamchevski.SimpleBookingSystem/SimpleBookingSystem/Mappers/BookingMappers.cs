using Domain.Models;
using Dtos.BookingDtos;
using System;

namespace Mappers
{
    public static class BookingMappers
    {
        public static Booking ToBooking(this BookResourceDto bookResourceDto)
        {
            return new Booking()
            {
                BookedQuantity = bookResourceDto.Quantity,
                DateFrom = DateTime.Parse(bookResourceDto.DateFrom),
                DateTo = DateTime.Parse(bookResourceDto.DateTo),
                ResourceId = bookResourceDto.ResourceId
            };
        }
    }
}
