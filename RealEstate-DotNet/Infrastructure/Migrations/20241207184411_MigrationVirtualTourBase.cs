using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MigrationVirtualTourBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "VirtualTours",
                newName: "VirtualUrl");

            migrationBuilder.RenameColumn(
                name: "TourId",
                table: "VirtualTours",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VirtualUrl",
                table: "VirtualTours",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VirtualTours",
                newName: "TourId");
        }
    }
}
