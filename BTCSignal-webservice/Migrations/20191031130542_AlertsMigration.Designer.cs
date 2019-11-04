﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using btcsignalwebservice.Model;

namespace btcsignalwebservice.Migrations
{
    [DbContext(typeof(AlertContext))]
    [Migration("20191031130542_AlertsMigration")]
    partial class AlertsMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("btcsignalwebservice.Model.Alert", b =>
                {
                    b.Property<int>("AlertId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Course");

                    b.Property<string>("Currency");

                    b.Property<string>("Exchange");

                    b.Property<int>("Status");

                    b.Property<int>("UserId");

                    b.HasKey("AlertId");

                    b.ToTable("Alerts");
                });
#pragma warning restore 612, 618
        }
    }
}
