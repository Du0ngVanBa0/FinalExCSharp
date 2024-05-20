using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalEx.Migrations
{
    /// <inheritdoc />
    public partial class updDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Departments");
        }
    }
}
