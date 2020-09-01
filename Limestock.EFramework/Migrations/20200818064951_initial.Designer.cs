﻿// <auto-generated />
using System;
using Limestock.EFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Limestock.EFramework.Migrations
{
    [DbContext(typeof(LimestockDbContext))]
    [Migration("20200818064951_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("Limestock.Domain.Models.Konsumen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlamatKonsumen")
                        .HasColumnType("TEXT")
                        .HasMaxLength(150);

                    b.Property<string>("NamaKonsumen")
                        .HasColumnType("TEXT")
                        .HasMaxLength(64);

                    b.Property<int>("TelpKonsumen")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Konsumen");
                });

            modelBuilder.Entity("Limestock.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KonsumenId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamaKonsumen")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TglOrder")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KonsumenId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Limestock.Domain.Models.Produk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("HargaProduk")
                        .HasColumnType("REAL")
                        .HasMaxLength(10);

                    b.Property<bool>("KetersediaanBarang")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamaProduk")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("SatuanBarang")
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("SimbolSatuan")
                        .HasColumnType("TEXT")
                        .HasMaxLength(5);

                    b.Property<int>("StokBarang")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Produk");
                });

            modelBuilder.Entity("Limestock.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamaLengkap")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(150);

                    b.Property<DateTime>("TanggalBerubah")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TanggalDibuat")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserMail")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("UserPass")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(16);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Limestock.Domain.Models.Order", b =>
                {
                    b.HasOne("Limestock.Domain.Models.Konsumen", "Konsumen")
                        .WithMany("Orders")
                        .HasForeignKey("KonsumenId");

                    b.HasOne("Limestock.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
