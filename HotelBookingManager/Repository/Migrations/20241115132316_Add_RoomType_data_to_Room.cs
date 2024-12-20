using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingManager.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Add_RoomType_data_to_Room : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExtraBedAmount",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RoomTypeName",
                table: "Rooms",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraBedAmount",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomTypeName",
                table: "Rooms");
        }
    }
}
