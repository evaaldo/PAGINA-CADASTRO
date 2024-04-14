﻿// <auto-generated />
using System;
using InventarioTelefonia.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventarioTelefonia.Migrations
{
    [DbContext(typeof(InventarioTelefoniaContext))]
    partial class InventarioTelefoniaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InventarioTelefonia.Models.CentroCusto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("ClasseValor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CentrosCusto");
                });

            modelBuilder.Entity("InventarioTelefonia.Models.Contrato", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Contratado")
                        .HasColumnType("bit");

                    b.Property<string>("Contratante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroContrato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjetoContrato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("InventarioTelefonia.Models.InventarioAparelho", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DataAquisicao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDesativacao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Mantenedora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModeloAparelho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroSerie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("InventariosAparelho");
                });

            modelBuilder.Entity("InventarioTelefonia.Models.NotaFiscal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNF")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroNF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Soma")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("NotasFiscais");
                });

            modelBuilder.Entity("InventarioTelefonia.Models.NumeroCliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DataAtivacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDesativacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operadora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Virtual")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("NumerosClientes");
                });

            modelBuilder.Entity("InventarioTelefonia.Models.UsuarioTelefonia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartamentoPessoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ICCID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InventarioAparelho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operadora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pessoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("UsuariosTelefonia");
                });
#pragma warning restore 612, 618
        }
    }
}
