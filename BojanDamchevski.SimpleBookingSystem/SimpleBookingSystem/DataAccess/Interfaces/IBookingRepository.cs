using Domain.Models;

namespace DataAccess.Interfaces
{
    public interface IBookingRepository
    {
        //CRUD
        void Insert(Booking entity);
        int GetLastBookingId();
    }
}
