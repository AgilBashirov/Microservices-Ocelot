﻿using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBookingNumber(int number)
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(100),
                BookingNumber = number,
                Amount = (new Random()).Next(10000),
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37),
                BookingDate = DateTime.Now,
            };
        }
    }
}
