using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinas.app.Persistencia.Migrations
{
    public partial class Entidades1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Covid1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_inicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dolor_de_cabeza = table.Column<bool>(type: "bit", nullable: false),
                    Fiebre = table.Column<bool>(type: "bit", nullable: false),
                    Tos = table.Column<bool>(type: "bit", nullable: false),
                    Diarrea = table.Column<bool>(type: "bit", nullable: false),
                    Vomito = table.Column<bool>(type: "bit", nullable: false),
                    Perdida_Ofalto = table.Column<bool>(type: "bit", nullable: false),
                    Perdida_Gusto = table.Column<bool>(type: "bit", nullable: false),
                    Fecha_final = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Covid1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oficinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aforo = table.Column<int>(type: "int", nullable: false),
                    Cant_Oficinas_Disponibles = table.Column<int>(type: "int", nullable: false),
                    Numero_personas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficinas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaboradas = table.Column<int>(type: "int", nullable: false),
                    Estado_covid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Asesor_Oficinas_visitadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oficinas_visitadas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Servicio_realizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unidad_visitada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Despacho = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Covid1");

            migrationBuilder.DropTable(
                name: "Oficinas");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Sedes");
        }
    }
}
