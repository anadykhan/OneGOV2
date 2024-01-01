using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataAccessFactory
    {
        public static IRepo<Room, int, Room> RoomData ()
        {
            return new RoomRepo();
        }

        public static IRepo<UserBooking, int, UserBooking> UserBookingData ()
        {
            return new UserBookingRepo();
        }

        public static IRepo<Like, int, Like> LikeData()
        {
            return new LikeRepo();
        }

        public static IRepo<Cart, int, Cart> CartData()
        {
            return new CartRepo();
        }
    }
}
