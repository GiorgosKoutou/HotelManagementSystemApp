using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLibrary.Migrations
{
    /// <inheritdoc />
    public partial class ChangeStaff_lastnamePropertyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Staff",
                newName: "LastName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Staff",
                newName: "lastName");
        }
    }
}
