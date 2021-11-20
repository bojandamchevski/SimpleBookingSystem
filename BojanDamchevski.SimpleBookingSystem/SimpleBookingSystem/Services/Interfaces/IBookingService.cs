using Dtos.BookingDtos;

namespace Services.Interfaces
{
    public interface IBookingService
    {
        bool BookAResource(BookResourceDto bookResourceDto);
        int GetBookingId();
    }
}
