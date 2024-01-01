namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumnFromRooms : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rooms", "UserBooking_BookingID", "dbo.UserBookings");
            DropIndex("dbo.Rooms", new[] { "UserBooking_BookingID" });
            DropColumn("dbo.Rooms", "UserBooking_BookingID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "UserBooking_BookingID", c => c.Int());
            CreateIndex("dbo.Rooms", "UserBooking_BookingID");
            AddForeignKey("dbo.Rooms", "UserBooking_BookingID", "dbo.UserBookings", "BookingID");
        }
    }
}
