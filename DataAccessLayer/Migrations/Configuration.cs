namespace DataAccessLayer.Migrations
{
    using DataAccessLayer.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Models.OneGOV2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.Models.OneGOV2Context context)
        {
            // Add 10 sample Room entries
            //for (int i = 1; i <= 10; i++)
            //{
            //    context.Rooms.AddOrUpdate(
            //        new Models.Room
            //        {
            //            RoomNumber = i,
            //            RoomType = "SampleType" + i,
            //            AvailabilityStatus = "Available",
            //            ImageURL = "SampleImageURL" + i
            //        });
            //}

            // Save changes to the database
            //context.SaveChanges();

            //for (int i = 1; i <= 10; i++)
            //{
            //    context.UserBookings.AddOrUpdate(
            //        new Models.UserBooking
            //        {
            //            BookingID = i,
            //            RoomID = i,  // Assigning RoomID for the relationship
            //            CheckInDate = DateTime.Now.AddDays(i),
            //            CheckOutDate = DateTime.Now.AddDays(i + 3),
            //            TotalPrice = 100 * i,
            //            BookingStatus = "Confirmed"
            //        });
            //}

            // Save changes to the database
            //context.SaveChanges();
        }
    }
}
