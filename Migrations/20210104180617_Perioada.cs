using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ardelean_Diana_Proiect1.Migrations
{
    public partial class Perioada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Buget",
                table: "Plancs",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Perioada",
                table: "Plancs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Buget",
                table: "Plancs");

            migrationBuilder.DropColumn(
                name: "Perioada",
                table: "Plancs");
        }
    }
}
