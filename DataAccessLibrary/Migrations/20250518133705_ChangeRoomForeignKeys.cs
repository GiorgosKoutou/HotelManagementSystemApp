using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLibrary.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRoomForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_TypeCategories_RoomTypeId_RoomType",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "RoomTypeId",
                table: "Rooms",
                newName: "RoomTypeCategoryid");

            migrationBuilder.RenameColumn(
                name: "RoomType",
                table: "Rooms",
                newName: "RoomTypeCategoryType");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomTypeId_RoomType",
                table: "Rooms",
                newName: "IX_Rooms_RoomTypeCategoryid_RoomTypeCategoryType");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_TypeCategories_RoomTypeCategoryid_RoomTypeCategoryType",
                table: "Rooms",
                columns: new[] { "RoomTypeCategoryid", "RoomTypeCategoryType" },
                principalTable: "TypeCategories",
                principalColumns: new[] { "id", "Type" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_TypeCategories_RoomTypeCategoryid_RoomTypeCategoryType",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "RoomTypeCategoryid",
                table: "Rooms",
                newName: "RoomTypeId");

            migrationBuilder.RenameColumn(
                name: "RoomTypeCategoryType",
                table: "Rooms",
                newName: "RoomType");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomTypeCategoryid_RoomTypeCategoryType",
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
    }
}
