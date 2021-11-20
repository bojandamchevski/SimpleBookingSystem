using Dtos.BookingDtos;
using Dtos.ResourceDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBookingSystemApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("book-resource")]
        public IActionResult BookAResource([FromBody] BookResourceDto bookResourceDto)
        {
            try
            {
                bool flag = _bookingService.BookAResource(bookResourceDto);
                if (flag)
                {
                    return StatusCode(StatusCodes.Status201Created, "Resource booked");
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Can not book resource");
                }
            }
            catch (BookingException)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Sorry can't book that resource");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured");
            }
        }

        [HttpGet("get-booking-id")]
        public ActionResult<int> GetBookingId()
        {
            try
            {
                int id = _bookingService.GetBookingId();
                return StatusCode(StatusCodes.Status200OK, id);
            }
            catch (BookingException)
            {
                return StatusCode(StatusCodes.Status400BadRequest, "Sorry can't get the booking Id");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured");
            }
        }
    }
}
