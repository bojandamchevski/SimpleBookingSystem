using DataAccess.Interfaces;
using Domain.Models;
using Dtos.BookingDtos;
using Mappers;
using Services.Interfaces;
using System;

namespace Services.Implementations
{
    public class BookingService : IBookingService
    {
        private IResourceRepository _resourceRepository;
        private IBookingRepository _bookingRepository;
        public BookingService(IResourceRepository resourceRepository, IBookingRepository bookingRepository)
        {
            _resourceRepository = resourceRepository;
            _bookingRepository = bookingRepository;
        }
        public bool BookAResource(BookResourceDto bookResourceDto)
        {
            Resource resourceDb = _resourceRepository.GetById(bookResourceDto.ResourceId);
            Booking newBooking = new Booking();

            bool flag = false;

            if (resourceDb.Quantity > bookResourceDto.Quantity)
            {
                if (DateTime.Parse(bookResourceDto.DateFrom) < DateTime.Parse(bookResourceDto.DateTo))
                {
                    foreach (Booking b in resourceDb.Bookings)
                    {
                        if ((DateTime.Parse(bookResourceDto.DateFrom) <= b.DateTo && DateTime.Parse(bookResourceDto.DateFrom) >= b.DateFrom) ||
                            (b.DateFrom <= DateTime.Parse(bookResourceDto.DateTo) && b.DateFrom >= DateTime.Parse(bookResourceDto.DateFrom)))
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            flag = true;
                        };
                    }
                };
                if (flag)
                {
                    newBooking = bookResourceDto.ToBooking();
                    newBooking.Resource = resourceDb;
                    resourceDb.Quantity = resourceDb.Quantity - newBooking.BookedQuantity;
                    _resourceRepository.Update(resourceDb);
                    _bookingRepository.Insert(newBooking);
                }
            }
            return flag;
        }

        public int GetBookingId()
        {
            int id = _bookingRepository.GetLastBookingId();
            return id;
        }
    }
}
