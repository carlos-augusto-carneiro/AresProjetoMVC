﻿// <auto-generated />
using System;
using AresProjeto.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AresProjeto.Persistence.Migrations
{
    [DbContext(typeof(UserTaskContext))]
    partial class UserTaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AresProjeto.Domain.Entitys.Taskt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id")
                        .HasColumnOrder(1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("Description")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("EndDate")
                        .HasColumnOrder(5);

                    b.Property<Guid>("IdUser")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("StartDate")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("StartTime")
                        .HasColumnOrder(6);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Title")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Taskts");
                });

            modelBuilder.Entity("AresProjeto.Domain.Entitys.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id")
                        .HasColumnOrder(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("Name")
                        .HasColumnOrder(2);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Password")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AresProjeto.Domain.Entitys.Taskt", b =>
                {
                    b.HasOne("AresProjeto.Domain.Entitys.User", "User")
                        .WithMany("Taskts")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AresProjeto.Domain.Entitys.User", b =>
                {
                    b.Navigation("Taskts");
                });
#pragma warning restore 612, 618
        }
    }
}
