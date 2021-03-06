﻿// <auto-generated />
using Demo.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace Demo.EFCore.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    [Migration("20190613031147_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("NETCORE")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("Demo.Core.Entities.Student", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("USERID");

                    b.Property<string>("Name")
                        .HasColumnName("NAME")
                        .HasMaxLength(10);

                    b.HasKey("UserId");

                    b.ToTable("STUDENT");
                });
#pragma warning restore 612, 618
        }
    }
}
