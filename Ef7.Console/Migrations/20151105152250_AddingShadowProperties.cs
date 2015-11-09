using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Ef7.Console.Migrations
{
    public partial class AddingShadowProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Store",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Store",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DateCreated", table: "Store");
            migrationBuilder.DropColumn(name: "LastUpdated", table: "Store");
        }
    }
}
