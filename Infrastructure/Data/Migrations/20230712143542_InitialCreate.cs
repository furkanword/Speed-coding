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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EspecialidadId1 = table.Column<int>(name: "Especialidad_Id1", type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.espid);
                    table.ForeignKey(
                        name: "FK_Especialidad_Especialidad_Especialidad_Id1",
                        column: x => x.EspecialidadId1,
                        principalTable: "Especialidad",
                        principalColumn: "esp_id");
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
                    ConsultoriosConsultorioId = table.Column<int>(name: "ConsultoriosConsultorio_Id", type: "INT", nullable: true),
                    medespecialidad = table.Column<int>(name: "med_especialidad", type: "INT", nullable: false),
                    MedicosMednumeromatriculapostal = table.Column<int>(name: "MedicosMed_numero_matricula_postal", type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.mednroMatriculaProfecional);
                    table.ForeignKey(
                        name: "FK_Medico_Consultorio_ConsultoriosConsultorio_Id",
                        column: x => x.ConsultoriosConsultorioId,
                        principalTable: "Consultorio",
                        principalColumn: "cons_codigo");
                    table.ForeignKey(
                        name: "FK_Medico_Medico_MedicosMed_numero_matricula_postal",
                        column: x => x.MedicosMednumeromatriculapostal,
                        principalTable: "Medico",
                        principalColumn: "med_nroMatriculaProfecional");
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
                    Tipodocumentoidtipodocumento = table.Column<int>(name: "Tipo_documentoid_tipo_documento", type: "INT", nullable: true),
                    usugenero = table.Column<int>(name: "usu_genero", type: "INT", nullable: false),
                    generoId = table.Column<int>(name: "genero_Id", type: "INT", nullable: true),
                    usuacudiente = table.Column<int>(name: "usu_acudiente", type: "INT", nullable: false),
                    AcudienteCodigo = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuid);
                    table.ForeignKey(
                        name: "FK_Usuario_Acudiente_AcudienteCodigo",
                        column: x => x.AcudienteCodigo,
                        principalTable: "Acudiente",
                        principalColumn: "acu_codigo");
                    table.ForeignKey(
                        name: "FK_Usuario_Genero_genero_Id",
                        column: x => x.generoId,
                        principalTable: "Genero",
                        principalColumn: "gen_id");
                    table.ForeignKey(
                        name: "FK_Usuario_Tipo_documento_Tipo_documentoid_tipo_documento",
                        column: x => x.Tipodocumentoidtipodocumento,
                        principalTable: "Tipo_documento",
                        principalColumn: "tipdoc_id");
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
                    EstadoCitasEstadocitaId = table.Column<int>(name: "Estado_CitasEstado_cita_Id", type: "INT", nullable: true),
                    citmedico = table.Column<int>(name: "cit_medico", type: "INT", nullable: false),
                    MedicoMednumeromatriculapostal = table.Column<int>(name: "MedicoMed_numero_matricula_postal", type: "INT", nullable: true),
                    citdatosUsuario = table.Column<int>(name: "cit_datosUsuario", type: "INT", nullable: false),
                    UsuariosId = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.citcodigo);
                    table.ForeignKey(
                        name: "FK_Cita_Estado_cita_Estado_CitasEstado_cita_Id",
                        column: x => x.EstadoCitasEstadocitaId,
                        principalTable: "Estado_cita",
                        principalColumn: "estcita_id");
                    table.ForeignKey(
                        name: "FK_Cita_Medico_MedicoMed_numero_matricula_postal",
                        column: x => x.MedicoMednumeromatriculapostal,
                        principalTable: "Medico",
                        principalColumn: "med_nroMatriculaProfecional");
                    table.ForeignKey(
                        name: "FK_Cita_Usuario_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuario",
                        principalColumn: "usu_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_Estado_CitasEstado_cita_Id",
                table: "Cita",
                column: "Estado_CitasEstado_cita_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_MedicoMed_numero_matricula_postal",
                table: "Cita",
                column: "MedicoMed_numero_matricula_postal");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_UsuariosId",
                table: "Cita",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Especialidad_Especialidad_Id1",
                table: "Especialidad",
                column: "Especialidad_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_ConsultoriosConsultorio_Id",
                table: "Medico",
                column: "ConsultoriosConsultorio_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_MedicosMed_numero_matricula_postal",
                table: "Medico",
                column: "MedicosMed_numero_matricula_postal");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AcudienteCodigo",
                table: "Usuario",
                column: "AcudienteCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_genero_Id",
                table: "Usuario",
                column: "genero_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Tipo_documentoid_tipo_documento",
                table: "Usuario",
                column: "Tipo_documentoid_tipo_documento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Estado_cita");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Consultorio");

            migrationBuilder.DropTable(
                name: "Acudiente");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Tipo_documento");
        }
    }
}
