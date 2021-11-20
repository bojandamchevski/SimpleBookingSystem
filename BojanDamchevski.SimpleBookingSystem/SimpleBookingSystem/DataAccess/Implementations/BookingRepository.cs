using DataAccess.Interfaces;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Implementations
{
    public class BookingRepository : IBookingRepository
    {
        private AppDbContext _appDbContext;
        public BookingRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int GetLastBookingId()
        {
            List<Booking> bookings = _appDbContext.Bookings.ToList();
            Booking bookingDb = bookings.LastOrDefault();
            return bookingDb.Id;
        }

        public void Insert(Booking entity)
        {
            _appDbContext.Bookings.Add(entity);
            _appDbContext.SaveChanges();
        }
    }
}
