using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Hotel Suite");
            try
            {
                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    "HotelSuits",
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 3)));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 2),
                    "HotelSuits",
                    new DateTime(2000, 1, 5),
                    new DateTime(2000, 1, 7)));

            }catch (Exception ex) { }

            

            IEnumerable<Reservation> reservations = hotel.GetReservationForUser("HotelUser");

            base.OnStartup(e);
        }
    }
}
