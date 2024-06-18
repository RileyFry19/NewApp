﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PJ_Webapp.Models;

#nullable disable

namespace PJ_Webapp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("PJ_Webapp.Models.Resource", b =>
                {
                    b.Property<Guid>("resourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("amount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("type")
                        .HasColumnType("INTEGER");

                    b.HasKey("resourceId");

                    b.ToTable("resources");
                });

            modelBuilder.Entity("PJ_Webapp.Models.Skill", b =>
                {
                    b.Property<Guid>("skillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("name")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("soldierId")
                        .HasColumnType("TEXT");

                    b.HasKey("skillId");

                    b.HasIndex("soldierId");

                    b.ToTable("skills");
                });

            modelBuilder.Entity("PJ_Webapp.Models.Soldier", b =>
                {
                    b.Property<Guid>("soldierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("agility")
                        .HasColumnType("INTEGER");

                    b.Property<int>("aim")
                        .HasColumnType("INTEGER");

                    b.Property<int>("availableSkillPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("availableTalentPoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("characterSheetLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("currentHealth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("healthStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("loyalty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("maxHealth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("mental")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("playerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("power")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("roleAvailableForAssignment")
                        .HasColumnType("INTEGER");

                    b.Property<int>("soldierClass")
                        .HasColumnType("INTEGER");

                    b.Property<int>("soldierRace")
                        .HasColumnType("INTEGER");

                    b.Property<int>("toughness")
                        .HasColumnType("INTEGER");

                    b.Property<int>("will")
                        .HasColumnType("INTEGER");

                    b.HasKey("soldierId");

                    b.HasIndex("playerId");

                    b.ToTable("soldiers");
                });

            modelBuilder.Entity("PJ_Webapp.Models.User", b =>
                {
                    b.Property<Guid>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("hashedPassword")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("resetPassword")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("salt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("userID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("PJ_Webapp.Models.Skill", b =>
                {
                    b.HasOne("PJ_Webapp.Models.Soldier", "soldier")
                        .WithMany("skills")
                        .HasForeignKey("soldierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("soldier");
                });

            modelBuilder.Entity("PJ_Webapp.Models.Soldier", b =>
                {
                    b.HasOne("PJ_Webapp.Models.User", "playerOwned")
                        .WithMany("soldiers")
                        .HasForeignKey("playerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("playerOwned");
                });

            modelBuilder.Entity("PJ_Webapp.Models.Soldier", b =>
                {
                    b.Navigation("skills");
                });

            modelBuilder.Entity("PJ_Webapp.Models.User", b =>
                {
                    b.Navigation("soldiers");
                });
#pragma warning restore 612, 618
        }
    }
}
