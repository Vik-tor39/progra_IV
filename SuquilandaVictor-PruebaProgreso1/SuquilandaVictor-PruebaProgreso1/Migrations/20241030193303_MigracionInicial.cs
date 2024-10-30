using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuquilandaVictor_PruebaProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VSuquilanda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Fondos = table.Column<double>(type: "float", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComproCelular = table.Column<bool>(type: "bit", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCelulares = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VSuquilanda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fabricando = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Anio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    IdVSuquilanda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Celular_VSuquilanda_IdVSuquilanda",
                        column: x => x.IdVSuquilanda,
                        principalTable: "VSuquilanda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Celular_IdVSuquilanda",
                table: "Celular",
                column: "IdVSuquilanda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Celular");

            migrationBuilder.DropTable(
                name: "VSuquilanda");
        }
    }
}
