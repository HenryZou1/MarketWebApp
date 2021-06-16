using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Market.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateDay",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DateMonth",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DateYear",
                table: "Item");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Item",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "DateDay",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DateMonth",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DateYear",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
