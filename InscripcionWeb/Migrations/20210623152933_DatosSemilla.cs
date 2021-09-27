using Microsoft.EntityFrameworkCore.Migrations;

namespace InscripcionWeb.Migrations
{
    public partial class DatosSemilla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AñoCursados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    CarreraId = table.Column<int>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AñoCursados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AñoCursados_Carreras_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carreras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    AñoCursadoId = table.Column<int>(nullable: false),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materias_AñoCursados_AñoCursadoId",
                        column: x => x.AñoCursadoId,
                        principalTable: "AñoCursados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "Apellido", "Dni", "Eliminado", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Valle", 37454714, false, "ivanvallesj@gmail.com", "Carlos Ivan ", 3498459297.0 },
                    { 2, "Colombo", 38584798, false, "juancolombosj@gmail.com", "Juan Pablo ", 3498459299.0 },
                    { 3, "Córdoba", 38957452, false, "rami@gmail.com", "Ramiro ", 3498459298.0 },
                    { 4, "Sabino", 39625852, false, "mati@gmail.com", "Matias ", 3498459295.0 },
                    { 5, "Mangini", 37154825, false, "jere@gmail.com", "Jeremias  ", 3498459294.0 },
                    { 6, " Paulon ", 37124896, false, "corado@gmail.com", "Conrado", 3498459293.0 },
                    { 7, " Gomez ", 38957412, false, "nahuel@gmail.com", "Nahuel", 3498459292.0 },
                    { 8, " Barreto", 39658745, false, "santi@gmail.com", "Santiago", 3498459291.0 }
                });

            migrationBuilder.InsertData(
                table: "Carreras",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 7, false, "Profesorado de Educación Secundaria en Economía" },
                    { 6, false, "Profesorado de Educación Inicial" },
                    { 5, false, "Profesorado de Educación Secundaria en Ciencias de la Administración" },
                    { 1, false, "Tecnicatura Superior en Desarrollo de Software" },
                    { 3, false, "Tecnicatura Superior en Gestion de las Organizaciones" },
                    { 2, false, "Tecnicatura Superior en Soporte de Infraestructura" },
                    { 8, false, "Profesorado de Educación Tecnológica" },
                    { 4, false, "Tecnicatura Superior en Enfermeria" },
                    { 9, false, "Licenciatura en Cooperativismo y Mutualismo" }
                });

            migrationBuilder.InsertData(
                table: "AñoCursados",
                columns: new[] { "Id", "CarreraId", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, false, "Primero" },
                    { 27, 8, false, "Tercero" },
                    { 26, 8, false, "Segundo" },
                    { 25, 8, false, "Primero" },
                    { 24, 7, false, "Cuarto" },
                    { 23, 7, false, "Tercero" },
                    { 22, 7, false, "Segundo" },
                    { 21, 7, false, "Primero" },
                    { 20, 6, false, "Cuarto" },
                    { 19, 6, false, "Tercero" },
                    { 18, 6, false, "Segundo" },
                    { 17, 6, false, "Primero" },
                    { 16, 5, false, "Cuarto" },
                    { 28, 8, false, "Cuarto" },
                    { 15, 5, false, "Tercero" },
                    { 13, 5, false, "Primero" },
                    { 12, 4, false, "Tercero" },
                    { 11, 4, false, "Segundo" },
                    { 10, 4, false, "Primero" },
                    { 9, 3, false, "Tercero" },
                    { 8, 3, false, "Segundo" },
                    { 7, 3, false, "Primero" },
                    { 6, 2, false, "Tercero" },
                    { 5, 2, false, "Segundo" },
                    { 4, 2, false, "Primero" },
                    { 3, 1, false, "Tercero" },
                    { 2, 1, false, "Segundo" },
                    { 14, 5, false, "Segundo" },
                    { 29, 9, false, "Primero" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AñoCursados_CarreraId",
                table: "AñoCursados",
                column: "CarreraId");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_AñoCursadoId",
                table: "Materias",
                column: "AñoCursadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "AñoCursados");

            migrationBuilder.DropTable(
                name: "Carreras");
        }
    }
}
