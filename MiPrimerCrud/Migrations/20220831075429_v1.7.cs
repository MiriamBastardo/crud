using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiPrimerCrud.Migrations
{
    public partial class v17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlumnoCurso",
                columns: table => new
                {
                    AlumnosId = table.Column<long>(type: "bigint", nullable: false),
                    CursosId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumnoCurso", x => new { x.AlumnosId, x.CursosId });
                    table.ForeignKey(
                        name: "FK_AlumnoCurso_Alumnos_AlumnosId",
                        column: x => x.AlumnosId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlumnoCurso_Cursos_CursosId",
                        column: x => x.CursosId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoCurso_CursosId",
                table: "AlumnoCurso",
                column: "CursosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumnoCurso");
        }
    }
}
