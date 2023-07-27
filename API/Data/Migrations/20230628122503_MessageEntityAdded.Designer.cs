﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230628122503_MessageEntityAdded")]
    partial class MessageEntityAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder builder)
        {
#pragma warning disable 612, 618
            builder.HasAnnotation("ProductVersion", "7.0.5");

            // builder.Entity("API.Entities.AppUser", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd()
            //             .HasColumnType("INTEGER");

            //         b.Property<byte[]>("PasswordHash")
            //             .HasColumnType("BLOB");

            //         b.Property<byte[]>("PasswordSalt")
            //             .HasColumnType("BLOB");

            //         b.Property<string>("UserName")
            //             .HasColumnType("TEXT");

            //         b.HasKey("Id");

            //         b.ToTable("Users");
            //     });

            builder.Entity("API.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MessageSent")
                        .HasColumnType("TEXT");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RecipientUsername")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SenderUsername")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            builder.Entity("API.Entities.Message", b =>
                {
                    b.HasOne("API.Entities.AppUser", "Recipient")
                        .WithMany("MessageReceived")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "Sender")
                        .WithMany("MessageSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            builder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("MessageReceived");

                    b.Navigation("MessageSent");
                });
#pragma warning restore 612, 618
        }
    }
}