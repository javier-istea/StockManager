using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StockManager.Data.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Productos");

            migrationBuilder.EnsureSchema(
                name: "Prendas");

            migrationBuilder.CreateTable(
                name: "TipsoDePrendas",
                schema: "Prendas",
                columns: table => new
                {
                    TipoDePrendaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipsoDePrendas", x => x.TipoDePrendaId);
                });

            migrationBuilder.CreateTable(
                name: "Prendas",
                schema: "Productos",
                columns: table => new
                {
                    PrendaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<string>(maxLength: 45, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false),
                    Talle = table.Column<string>(maxLength: 10, nullable: false),
                    TipoDePrendaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prendas", x => x.PrendaId);
                    table.ForeignKey(
                        name: "FK_Prendas_TipsoDePrendas_TipoDePrendaID",
                        column: x => x.TipoDePrendaID,
                        principalSchema: "Prendas",
                        principalTable: "TipsoDePrendas",
                        principalColumn: "TipoDePrendaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prendas_TipoDePrendaID",
                schema: "Productos",
                table: "Prendas",
                column: "TipoDePrendaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prendas",
                schema: "Productos");

            migrationBuilder.DropTable(
                name: "TipsoDePrendas",
                schema: "Prendas");
        }
    }
}
