﻿// <auto-generated />
using BusinessLogic.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BusinessLogic.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240109091317_AddNameColumn")]
    partial class AddNameColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Shared.Monster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ArmorClass")
                        .HasColumnType("integer");

                    b.Property<int>("AttackModifier")
                        .HasColumnType("integer");

                    b.Property<int>("AttackPerRound")
                        .HasColumnType("integer");

                    b.Property<string>("Damage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DamageModifier")
                        .HasColumnType("integer");

                    b.Property<int>("HitPoints")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Weapon")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Monsters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArmorClass = 13,
                            AttackModifier = -2,
                            AttackPerRound = 1,
                            Damage = "3d4",
                            DamageModifier = 2,
                            HitPoints = 10,
                            Name = "Imp",
                            Weapon = 1
                        },
                        new
                        {
                            Id = 2,
                            ArmorClass = 13,
                            AttackModifier = 2,
                            AttackPerRound = 1,
                            Damage = "5d8",
                            DamageModifier = 2,
                            HitPoints = 27,
                            Name = "Kysh",
                            Weapon = 1
                        },
                        new
                        {
                            Id = 3,
                            ArmorClass = 12,
                            AttackModifier = 0,
                            AttackPerRound = 1,
                            Damage = "3d8",
                            DamageModifier = 2,
                            HitPoints = 19,
                            Name = "Creeper",
                            Weapon = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
