namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(nullable: false),
                        RoomType = c.String(),
                        AvailabilityStatus = c.String(),
                        ImageURL = c.String(),
                        UserBooking_BookingID = c.Int(),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.UserBookings", t => t.UserBooking_BookingID)
                .Index(t => t.UserBooking_BookingID);
            
            CreateTable(
                "dbo.UserBookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        BookingStatus = c.String(),
                    })
                .PrimaryKey(t => t.BookingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "UserBooking_BookingID", "dbo.UserBookings");
            DropIndex("dbo.Rooms", new[] { "UserBooking_BookingID" });
            DropTable("dbo.UserBookings");
            DropTable("dbo.Rooms");
        }
    }
}
