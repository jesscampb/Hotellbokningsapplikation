using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingManager.Repository.Migrations
{
    /// <inheritdoc />
    public partial class RenameRoomTypeProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomTypeName",
                table: "Rooms",
                newName: "RoomType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomType",
                table: "Rooms",
                newName: "RoomTypeName");
        }
    }
}
