using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Acudiente",
                columns: table => new
                {
                    acucodigo = table.Column<int>(name: "acu_codigo", type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    acunombreCompleto = table.Column<string>(name: "acu_nombreCompleto", type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    acutelefono = table.Column<string>(name: "acu_telefono", type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    acudireccion = table.Column<string>(name: "acu_direccion", type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acudiente", x => x.acucodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Consultorio",
                columns: table => new
                {
                    conscodigo = table.Column<int>(name: "cons_codigo", type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    constnombre = table.Column<string>(name: "const_nombre", type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultorio", x => x.conscodigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    espid = table.Column<int>(name: "esp_id", type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    espnombre = table.Column<string>(name: "esp_nombre", type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.espid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estado_cita",
                columns: table => new
                {
                    estcitaid = table.Column<int>(name: "estcita_id", type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    estcitanombre = table.Column<string>(name: "estcita_nombre", type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado_cita", x => x.estcitaid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    genid = table.Column<int>(name: "gen_id", type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    gennombre = table.Column<string>(name: "gen_nombre", type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    genabreviatura = table.Column<string>(name: "gen_abreviatura", type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.genid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipo_documento",
                columns: table => new
                {
                    tipdocid = table.Column<int>(name: "tipdoc_id", type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipdocnombre = table.Column<string>(name: "tipdoc_nombre", type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipdocabreviatura = table.Column<string>(name: "tipdoc_abreviatura", type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_documento", x => x.tipdocid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    mednroMatriculaProfecional = table.Column<int>(name: "med_nroMatriculaProfecional", type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mednombreCompleto = table.Column<string>(name: "med_nombreCompleto", type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    medconsultorio = table.Column<int>(name: "med_consultorio", type: "INT", nullable: false),
                    medespecialidad = table.Column<int>(name: "med_especialidad", type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.mednroMatriculaProfecional);
                    table.ForeignKey(
                        name: "FK_Medico_Consultorio_med_consultorio",
                        column: x => x.medconsultorio,
                        principalTable: "Consultorio",
                        principalColumn: "cons_codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidad_med_especialidad",
                        column: x => x.medespecialidad,
                        principalTable: "Especialidad",
                        principalColumn: "esp_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuid = table.Column<int>(name: "usu_id", type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usunombre = table.Column<string>(name: "usu_nombre", type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ususegundonombre = table.Column<string>(name: "usu_segundo_nombre", type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usuprimerapellidousuar = table.Column<string>(name: "usu_primer_apellido_usuar", type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ususegundoapellidousuar = table.Column<string>(name: "usu_segundo_apellido_usuar", type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usutelefono = table.Column<string>(name: "usu_telefono", type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usudireccion = table.Column<string>(name: "usu_direccion", type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usuemail = table.Column<string>(name: "usu_e-mail", type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usutipodoc = table.Column<int>(name: "usu_tipodoc", type: "INT", nullable: false),
                    usugenero = table.Column<int>(name: "usu_genero", type: "INT", nullable: false),
                    usuacudiente = table.Column<int>(name: "usu_acudiente", type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuid);
                    table.ForeignKey(
                        name: "FK_Usuario_Acudiente_usu_acudiente",
                        column: x => x.usuacudiente,
                        principalTable: "Acudiente",
                        principalColumn: "acu_codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Genero_usu_genero",
                        column: x => x.usugenero,
                        principalTable: "Genero",
                        principalColumn: "gen_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_Tipo_documento_usu_tipodoc",
                        column: x => x.usutipodoc,
                        principalTable: "Tipo_documento",
                        principalColumn: "tipdoc_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    citcodigo = table.Column<int>(name: "cit_codigo", type: "INT", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    citfecha = table.Column<DateTime>(name: "cit_fecha", type: "DATE", nullable: false),
                    citestadoCita = table.Column<int>(name: "cit_estadoCita", type: "INT", nullable: false),
                    citmedico = table.Column<int>(name: "cit_medico", type: "INT", nullable: false),
                    citdatosUsuario = table.Column<int>(name: "cit_datosUsuario", type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.citcodigo);
                    table.ForeignKey(
                        name: "FK_Cita_Estado_cita_cit_estadoCita",
                        column: x => x.citestadoCita,
                        principalTable: "Estado_cita",
                        principalColumn: "estcita_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cita_Medico_cit_medico",
                        column: x => x.citmedico,
                        principalTable: "Medico",
                        principalColumn: "med_nroMatriculaProfecional",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cita_Usuario_cit_datosUsuario",
                        column: x => x.citdatosUsuario,
                        principalTable: "Usuario",
                        principalColumn: "usu_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_cit_datosUsuario",
                table: "Cita",
                column: "cit_datosUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_cit_estadoCita",
                table: "Cita",
                column: "cit_estadoCita");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_cit_medico",
                table: "Cita",
                column: "cit_medico");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_med_consultorio",
                table: "Medico",
                column: "med_consultorio");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_med_especialidad",
                table: "Medico",
                column: "med_especialidad");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_usu_acudiente",
                table: "Usuario",
                column: "usu_acudiente");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_usu_genero",
                table: "Usuario",
                column: "usu_genero");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_usu_tipodoc",
                table: "Usuario",
                column: "usu_tipodoc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Estado_cita");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Consultorio");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Acudiente");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Tipo_documento");
        }
    }
}
