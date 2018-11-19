using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockManager.Data.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Prendas",
                schema: "Productos",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "TipsoDePrendas",
                schema: "Prendas",
                newSchema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Productos");

            migrationBuilder.EnsureSchema(
                name: "Prendas");

            migrationBuilder.RenameTable(
                name: "TipsoDePrendas",
                schema: "dbo",
                newSchema: "Prendas");

            migrationBuilder.RenameTable(
                name: "Prendas",
                schema: "dbo",
                newSchema: "Productos");
        }
    }
}
