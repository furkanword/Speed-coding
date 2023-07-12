﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(InventarioContext))]
    partial class InventarioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("core.Entities.Acudiente", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("acu_codigo");

                    b.Property<string>("Direccion")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("acu_direccion");

                    b.Property<string>("Nombre_completo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("acu_nombreCompleto");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("acu_telefono");

                    b.HasKey("Codigo");

                    b.ToTable("Acudiente", (string)null);
                });

            modelBuilder.Entity("core.Entities.Cita", b =>
                {
                    b.Property<int>("cita_codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("cit_codigo");

                    b.Property<int?>("Estado_CitasEstado_cita_Id")
                        .HasColumnType("INT");

                    b.Property<int?>("MedicoMed_numero_matricula_postal")
                        .HasColumnType("INT");

                    b.Property<int?>("UsuariosId")
                        .HasColumnType("INT");

                    b.Property<int>("cita_datos_Usuario_id")
                        .HasColumnType("INT")
                        .HasColumnName("cit_datosUsuario");

                    b.Property<int>("cita_estado_id")
                        .HasColumnType("INT")
                        .HasColumnName("cit_estadoCita");

                    b.Property<DateTime>("cita_fecha")
                        .HasColumnType("DATE")
                        .HasColumnName("cit_fecha");

                    b.Property<int>("cita_medico_id")
                        .HasColumnType("INT")
                        .HasColumnName("cit_medico");

                    b.HasKey("cita_codigo");

                    b.HasIndex("Estado_CitasEstado_cita_Id");

                    b.HasIndex("MedicoMed_numero_matricula_postal");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Cita", (string)null);
                });

            modelBuilder.Entity("core.Entities.Consultorio", b =>
                {
                    b.Property<int>("Consultorio_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("cons_codigo");

                    b.Property<string>("Consultorio_Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("const_nombre");

                    b.HasKey("Consultorio_Id");

                    b.ToTable("Consultorio", (string)null);
                });

            modelBuilder.Entity("core.Entities.Especialidad", b =>
                {
                    b.Property<int>("Especialidad_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("esp_id");

                    b.Property<int?>("Especialidad_Id1")
                        .HasColumnType("INT");

                    b.Property<string>("Especialidad_Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("esp_nombre");

                    b.HasKey("Especialidad_Id");

                    b.HasIndex("Especialidad_Id1");

                    b.ToTable("Especialidad", (string)null);
                });

            modelBuilder.Entity("core.Entities.Estado_cita", b =>
                {
                    b.Property<int>("Estado_cita_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("estcita_id");

                    b.Property<string>("Estado_cita_Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("estcita_nombre");

                    b.HasKey("Estado_cita_Id");

                    b.ToTable("Estado_cita", (string)null);
                });

            modelBuilder.Entity("core.Entities.Genero", b =>
                {
                    b.Property<int>("genero_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("gen_id");

                    b.Property<string>("genero_abreviatura")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("gen_abreviatura");

                    b.Property<string>("genero_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("gen_nombre");

                    b.HasKey("genero_Id");

                    b.ToTable("Genero", (string)null);
                });

            modelBuilder.Entity("core.Entities.Medico", b =>
                {
                    b.Property<int>("Med_numero_matricula_postal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("med_nroMatriculaProfecional");

                    b.Property<int?>("ConsultoriosConsultorio_Id")
                        .HasColumnType("INT");

                    b.Property<int>("Med_consultorio_id")
                        .HasColumnType("INT")
                        .HasColumnName("med_consultorio");

                    b.Property<int>("Med_especialidad_id")
                        .HasColumnType("INT")
                        .HasColumnName("med_especialidad");

                    b.Property<string>("Med_nombre_completo")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)")
                        .HasColumnName("med_nombreCompleto");

                    b.Property<int?>("MedicosMed_numero_matricula_postal")
                        .HasColumnType("INT");

                    b.HasKey("Med_numero_matricula_postal");

                    b.HasIndex("ConsultoriosConsultorio_Id");

                    b.HasIndex("MedicosMed_numero_matricula_postal");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("core.Entities.Tipo_documento", b =>
                {
                    b.Property<int>("id_tipo_documento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("tipdoc_id");

                    b.Property<string>("tipo_documento_abreviatura")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("tipdoc_abreviatura");

                    b.Property<string>("tipo_documento_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("tipdoc_nombre");

                    b.HasKey("id_tipo_documento");

                    b.ToTable("Tipo_documento", (string)null);
                });

            modelBuilder.Entity("core.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("usu_id");

                    b.Property<int?>("AcudienteCodigo")
                        .HasColumnType("INT");

                    b.Property<int>("Acudiente_id")
                        .HasColumnType("INT")
                        .HasColumnName("usu_acudiente");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("usu_primer_apellido_usuar");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("usu_direccion");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("usu_e-mail");

                    b.Property<int>("Genero_id")
                        .HasColumnType("INT")
                        .HasColumnName("usu_genero");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("usu_nombre");

                    b.Property<string>("Segundo_apellido")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("usu_segundo_apellido_usuar");

                    b.Property<string>("Segundo_nombre")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("usu_segundo_nombre");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("usu_telefono");

                    b.Property<int>("Tipo_documento_id")
                        .HasColumnType("INT")
                        .HasColumnName("usu_tipodoc");

                    b.Property<int?>("Tipo_documentoid_tipo_documento")
                        .HasColumnType("INT");

                    b.Property<int?>("genero_Id")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("AcudienteCodigo");

                    b.HasIndex("Tipo_documentoid_tipo_documento");

                    b.HasIndex("genero_Id");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("core.Entities.Cita", b =>
                {
                    b.HasOne("core.Entities.Estado_cita", "Estado_Citas")
                        .WithMany("citas")
                        .HasForeignKey("Estado_CitasEstado_cita_Id");

                    b.HasOne("core.Entities.Medico", "Medico")
                        .WithMany("citas")
                        .HasForeignKey("MedicoMed_numero_matricula_postal");

                    b.HasOne("core.Entities.Usuario", "Usuarios")
                        .WithMany("citas")
                        .HasForeignKey("UsuariosId");

                    b.Navigation("Estado_Citas");

                    b.Navigation("Medico");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("core.Entities.Especialidad", b =>
                {
                    b.HasOne("core.Entities.Especialidad", null)
                        .WithMany("Especialidades")
                        .HasForeignKey("Especialidad_Id1");
                });

            modelBuilder.Entity("core.Entities.Medico", b =>
                {
                    b.HasOne("core.Entities.Consultorio", "Consultorios")
                        .WithMany()
                        .HasForeignKey("ConsultoriosConsultorio_Id");

                    b.HasOne("core.Entities.Medico", "Medicos")
                        .WithMany()
                        .HasForeignKey("MedicosMed_numero_matricula_postal");

                    b.Navigation("Consultorios");

                    b.Navigation("Medicos");
                });

            modelBuilder.Entity("core.Entities.Usuario", b =>
                {
                    b.HasOne("core.Entities.Acudiente", "Acudiente")
                        .WithMany("usuarios")
                        .HasForeignKey("AcudienteCodigo");

                    b.HasOne("core.Entities.Tipo_documento", "Tipo_documento")
                        .WithMany("usuarios")
                        .HasForeignKey("Tipo_documentoid_tipo_documento");

                    b.HasOne("core.Entities.Genero", "Genero")
                        .WithMany("usuarios")
                        .HasForeignKey("genero_Id");

                    b.Navigation("Acudiente");

                    b.Navigation("Genero");

                    b.Navigation("Tipo_documento");
                });

            modelBuilder.Entity("core.Entities.Acudiente", b =>
                {
                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("core.Entities.Especialidad", b =>
                {
                    b.Navigation("Especialidades");
                });

            modelBuilder.Entity("core.Entities.Estado_cita", b =>
                {
                    b.Navigation("citas");
                });

            modelBuilder.Entity("core.Entities.Genero", b =>
                {
                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("core.Entities.Medico", b =>
                {
                    b.Navigation("citas");
                });

            modelBuilder.Entity("core.Entities.Tipo_documento", b =>
                {
                    b.Navigation("usuarios");
                });

            modelBuilder.Entity("core.Entities.Usuario", b =>
                {
                    b.Navigation("citas");
                });
#pragma warning restore 612, 618
        }
    }
}
