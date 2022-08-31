using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HogarGestor.App.Persistencia.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ciudad",
                table: "personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "familiarId",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaNacimiento",
                table: "personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "historiaClinicaId",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "latitud",
                table: "personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "longitud",
                table: "personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "nutricionistaId",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pediatraId",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "historia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "patronCrecimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    tipoPatronC = table.Column<int>(type: "int", nullable: false),
                    Cls_BeneficiarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patronCrecimiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patronCrecimiento_personas_Cls_BeneficiarioId",
                        column: x => x.Cls_BeneficiarioId,
                        principalTable: "personas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "sugerencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cls_HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sugerencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sugerencia_historia_Cls_HistoriaId",
                        column: x => x.Cls_HistoriaId,
                        principalTable: "historia",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_personas_familiarId",
                table: "personas",
                column: "familiarId");

            migrationBuilder.CreateIndex(
                name: "IX_personas_historiaClinicaId",
                table: "personas",
                column: "historiaClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_personas_nutricionistaId",
                table: "personas",
                column: "nutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_personas_pediatraId",
                table: "personas",
                column: "pediatraId");

            migrationBuilder.CreateIndex(
                name: "IX_patronCrecimiento_Cls_BeneficiarioId",
                table: "patronCrecimiento",
                column: "Cls_BeneficiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_sugerencia_Cls_HistoriaId",
                table: "sugerencia",
                column: "Cls_HistoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_personas_historia_historiaClinicaId",
                table: "personas",
                column: "historiaClinicaId",
                principalTable: "historia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_personas_personas_familiarId",
                table: "personas",
                column: "familiarId",
                principalTable: "personas",
                principalColumn: "Id",
                //onDelete: ReferentialAction.Cascade);
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_personas_personas_nutricionistaId",
                table: "personas",
                column: "nutricionistaId",
                principalTable: "personas",
                principalColumn: "Id",
                //onDelete: ReferentialAction.Cascade);
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_personas_personas_pediatraId",
                table: "personas",
                column: "pediatraId",
                principalTable: "personas",
                principalColumn: "Id",
                //onDelete: ReferentialAction.Cascade);
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personas_historia_historiaClinicaId",
                table: "personas");

            migrationBuilder.DropForeignKey(
                name: "FK_personas_personas_familiarId",
                table: "personas");

            migrationBuilder.DropForeignKey(
                name: "FK_personas_personas_nutricionistaId",
                table: "personas");

            migrationBuilder.DropForeignKey(
                name: "FK_personas_personas_pediatraId",
                table: "personas");

            migrationBuilder.DropTable(
                name: "patronCrecimiento");

            migrationBuilder.DropTable(
                name: "sugerencia");

            migrationBuilder.DropTable(
                name: "historia");

            migrationBuilder.DropIndex(
                name: "IX_personas_familiarId",
                table: "personas");

            migrationBuilder.DropIndex(
                name: "IX_personas_historiaClinicaId",
                table: "personas");

            migrationBuilder.DropIndex(
                name: "IX_personas_nutricionistaId",
                table: "personas");

            migrationBuilder.DropIndex(
                name: "IX_personas_pediatraId",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "ciudad",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "familiarId",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "fechaNacimiento",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "historiaClinicaId",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "latitud",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "longitud",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "nutricionistaId",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "pediatraId",
                table: "personas");
        }
    }
}
