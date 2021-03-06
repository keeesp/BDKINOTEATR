// <auto-generated />
using System;
using DBKINOTEATR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBKINOTEATR.Migrations
{
    [DbContext(typeof(DBKINOTEATRContext))]
    partial class DBKINOTEATRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DBKINOTEATR.Models.DOLJNOSTI", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NAIMENOVANIE_DOLJNOSTI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OBYAZANOSTI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OKLAD")
                        .HasColumnType("int");

                    b.Property<string>("TREBOVANIYA")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DOLJNOSTI");
                });

            modelBuilder.Entity("DBKINOTEATR.Models.FILMS", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ACTERS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DLITELNOST")
                        .HasColumnType("bigint");

                    b.Property<int>("FIRMA_PROIZVODITEL")
                        .HasColumnType("int");

                    b.Property<string>("NAIMENOVANIE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPISANIE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STRANA_PROIZVODITEL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("VOZVRASTNIE_OGRANICHENIYA")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("FILMS");
                });

            modelBuilder.Entity("DBKINOTEATR.Models.JANRI", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NAIMENOVANIE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OPISANIE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("JANRI");
                });

            modelBuilder.Entity("DBKINOTEATR.Models.MESTA", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ZANYTOST")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MESTA");
                });

            modelBuilder.Entity("DBKINOTEATR.Models.REPERTUAR", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DATE")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Vremya_okonchaniya")
                        .HasColumnType("datetime2");

                    b.Property<long>("cena_bileta")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("vremya_nachala")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("REPERTUAR");
                });

            modelBuilder.Entity("DBKINOTEATR.Models.SOTRUDNIKI", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pasportnie_danie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("phone_number")
                        .HasColumnType("bigint");

                    b.Property<string>("pol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("vozrast")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.ToTable("SOTRUDNIKI");
                });
#pragma warning restore 612, 618
        }
    }
}
