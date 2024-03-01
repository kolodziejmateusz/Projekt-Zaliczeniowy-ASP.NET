﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240228171326_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("Data.Entities.AlbumEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Band")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Popularity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecordLabelId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrackList")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RecordLabelId");

                    b.ToTable("albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Band = "The Beatles",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "47:23",
                            Name = "Abbey Road",
                            Popularity = 3,
                            RecordLabelId = 1,
                            ReleaseDate = new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Come Together, Something, Maxwell's Silver Hammer, Oh! Darling, Octopus's Garden, I Want You (She's So Heavy), Here Comes The Sun, Because, You Never Give Me Your Money, Sun King, Mean Mr. Mustard, Polythene Pam, She Came In Through The Bathroom Window, Golden Slumbers, Carry That Weight, The End, Her Majesty."
                        },
                        new
                        {
                            Id = 2,
                            Band = "Pink Floyd",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "42:49",
                            Name = "The Dark Side of the Moon",
                            Popularity = 4,
                            RecordLabelId = 3,
                            ReleaseDate = new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Speak to Me, Breathe, On the Run, Time, The Great Gig in the Sky, Money, Us and Them, Any Colour You Like, Brain Damage, Eclipse."
                        },
                        new
                        {
                            Id = 3,
                            Band = "Papa Dance",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "57:03",
                            Name = "Nasza Ziemia Eden",
                            Popularity = 2,
                            RecordLabelId = 2,
                            ReleaseDate = new DateTime(1989, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Galaktyczny zwiad, Nasz Disneyland, Temat na clip, It's a simple song, Zły omen, Czas szaleństwa, Nietykalni, Ciało i talent..., Skajlajt, Twój ziemski Eden, The End"
                        },
                        new
                        {
                            Id = 4,
                            Band = "Lady Pank",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "41:27",
                            Name = "Zawsze Tam, Gdzie Ty",
                            Popularity = 3,
                            RecordLabelId = 3,
                            ReleaseDate = new DateTime(1994, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Dopóki da czas, Przerwa w trasie, Co mnie to obchodzi, Jak igła, Nie omijaj mnie, Niedokończona ulica, Nie wpychaj mnie w to dno, Zawsze tam gdzie ty, Zapłacę każdą cenę, Wiara we wroga"
                        },
                        new
                        {
                            Id = 5,
                            Band = "The Police",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "44:18",
                            Name = "Synchronicity",
                            Popularity = 4,
                            RecordLabelId = 4,
                            ReleaseDate = new DateTime(1983, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Synchronicity I, Walking in Your Footsteps, O My God, Mother, Miss Gradenko, Synchronicity II, Every Breath You Take, King of Pain, Wrapped Around Your Finger, Tea in the Sahara"
                        },
                        new
                        {
                            Id = 6,
                            Band = "Michael Jackson",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "42:19",
                            Name = "Thriller",
                            Popularity = 4,
                            RecordLabelId = 5,
                            ReleaseDate = new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Wanna Be Startin' Somethin', Baby Be Mine, The Girl Is Mine, Thriller, Beat It, Billie Jean, Human Nature, P.Y.T. (Pretty Young Thing), The Lady in My Life"
                        },
                        new
                        {
                            Id = 7,
                            Band = "AC/DC",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = "42:11",
                            Name = "Back in Black",
                            Popularity = 4,
                            RecordLabelId = 3,
                            ReleaseDate = new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TrackList = "Hells Bells, Shoot to Thrill, What Do You Do for Money Honey, Givin the Dog a Bone, Let Me Put My Love Into You, Back in Black, You Shook Me All Night Long, Have a Drink on Me, Shake a Leg, Rock and Roll Ain't Noise Pollution"
                        });
                });

            modelBuilder.Entity("Data.Entities.RecordLabelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Regon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("recordlabel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Starlight Records",
                            Nip = "987654321",
                            Regon = "123456789",
                            Website = "www.starlightrecords.com"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Echo Harmony Music",
                            Nip = "876543219",
                            Regon = "234567891",
                            Website = "www.echoharmonymusic.com"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Neon Beat Productions",
                            Nip = "765432198",
                            Regon = "345678912",
                            Website = "www.neonbeatpro.com"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Oceanwave Audio",
                            Nip = "654321987",
                            Regon = "456789123",
                            Website = "www.oceanwaveaudio.com"
                        },
                        new
                        {
                            Id = 5,
                            Name = "RetroSound Studios",
                            Nip = "543219876",
                            Regon = "567891234",
                            Website = "www.retrosoundstudios.com"
                        });
                });

            modelBuilder.Entity("Data.Entities.AlbumEntity", b =>
                {
                    b.HasOne("Data.Entities.RecordLabelEntity", "RecordLabel")
                        .WithMany("Albums")
                        .HasForeignKey("RecordLabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecordLabel");
                });

            modelBuilder.Entity("Data.Entities.RecordLabelEntity", b =>
                {
                    b.OwnsOne("Data.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<int>("RecordLabelEntityId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("ApartmentNumber")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("HouseNumber")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("State")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("RecordLabelEntityId");

                            b1.ToTable("recordlabel");

                            b1.WithOwner()
                                .HasForeignKey("RecordLabelEntityId");

                            b1.HasData(
                                new
                                {
                                    RecordLabelEntityId = 1,
                                    City = "Warszawa",
                                    Country = "Poland",
                                    HouseNumber = "27A",
                                    PostalCode = "00-639",
                                    State = "mazowieckie",
                                    Street = "Marszałkowska"
                                },
                                new
                                {
                                    RecordLabelEntityId = 2,
                                    City = "Gdańsk",
                                    Country = "Poland",
                                    HouseNumber = "45/6",
                                    PostalCode = "80-831",
                                    State = "pomorskie",
                                    Street = "Długa"
                                },
                                new
                                {
                                    RecordLabelEntityId = 3,
                                    City = "Wrocław",
                                    Country = "Poland",
                                    HouseNumber = "13",
                                    PostalCode = "50-101",
                                    State = "dolnośląskie",
                                    Street = "Rynek"
                                },
                                new
                                {
                                    RecordLabelEntityId = 4,
                                    City = "Kraków",
                                    Country = "Poland",
                                    HouseNumber = "39",
                                    PostalCode = "31-019",
                                    State = "małopolskie",
                                    Street = "Floriańska"
                                },
                                new
                                {
                                    RecordLabelEntityId = 5,
                                    City = "Poznań",
                                    Country = "Poland",
                                    HouseNumber = "80/82",
                                    PostalCode = "61-809",
                                    State = "wielkopolskie",
                                    Street = "Święty Marcin"
                                });
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Data.Entities.RecordLabelEntity", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}