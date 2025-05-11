using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLibrary.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRoomTypeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_TypeCategories_RoomTypeid_RoomTypeType",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "RoomTypeid",
                table: "Rooms",
                newName: "RoomTypeId");

            migrationBuilder.RenameColumn(
                name: "RoomTypeType",
                table: "Rooms",
                newName: "RoomType");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomTypeid_RoomTypeType",
                table: "Rooms",
                newName: "IX_Rooms_RoomTypeId_RoomType");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_TypeCategories_RoomTypeId_RoomType",
                table: "Rooms",
                columns: new[] { "RoomTypeId", "RoomType" },
                principalTable: "TypeCategories",
                principalColumns: new[] { "id", "Type" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_TypeCategories_RoomTypeId_RoomType",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "RoomTypeId",
                table: "Rooms",
                newName: "RoomTypeid");

            migrationBuilder.RenameColumn(
                name: "RoomType",
                table: "Rooms",
                newName: "RoomTypeType");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomTypeId_RoomType",
                table: "Rooms",
                newName: "IX_Rooms_RoomTypeid_RoomTypeType");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_TypeCategories_RoomTypeid_RoomTypeType",
                table: "Rooms",
                columns: new[] { "RoomTypeid", "RoomTypeType" },
                principalTable: "TypeCategories",
                principalColumns: new[] { "id", "Type" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
