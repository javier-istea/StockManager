using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockManager.Data.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrendaId",
                schema: "dbo",
                table: "Prendas",
                newName: "PrendaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrendaID",
                schema: "dbo",
                table: "Prendas",
                newName: "PrendaId");
        }
    }
}
