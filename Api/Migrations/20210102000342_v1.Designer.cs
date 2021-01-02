﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteDotnet.Data;

namespace TesteDotnet.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210102000342_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Api.Models.Developer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id", "CPF");

                    b.ToTable("Developer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "54011152021",
                            Email = "leonardo@gmail.com",
                            Name = "Leonardo",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 2,
                            CPF = "83336894000",
                            Email = "abc1@gmail.com",
                            Name = "Maria",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 3,
                            CPF = "07426071006",
                            Email = "abc2@gmail.com",
                            Name = "José",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 4,
                            CPF = "01928079008",
                            Email = "abc3@gmail.com",
                            Name = "Leonardo2",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 5,
                            CPF = "13757262000",
                            Email = "abc4@gmail.com",
                            Name = "Maria2",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 6,
                            CPF = "70610579045",
                            Email = "abc5@gmail.com",
                            Name = "José2",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 7,
                            CPF = "05827793086",
                            Email = "abc6@gmail.com",
                            Name = "Leonardo3",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 8,
                            CPF = "65451565007",
                            Email = "abc7@gmail.com",
                            Name = "Maria3",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 9,
                            CPF = "40687197058",
                            Email = "abc8@gmail.com",
                            Name = "José3",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 10,
                            CPF = "28596429000",
                            Email = "abc9@gmail.com",
                            Name = "Leonardo4",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 11,
                            CPF = "54621768050",
                            Email = "abc10@gmail.com",
                            Name = "Maria4",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 12,
                            CPF = "55705968019",
                            Email = "abc11@gmail.com",
                            Name = "José4",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("Api.Models.DeveloperProject", b =>
                {
                    b.Property<int>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("DeveloperCPF")
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("DeveloperId1")
                        .HasColumnType("int");

                    b.HasKey("DeveloperId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("DeveloperId1", "DeveloperCPF");

                    b.ToTable("DeveloperProject");

                    b.HasData(
                        new
                        {
                            DeveloperId = 1,
                            ProjectId = 1
                        },
                        new
                        {
                            DeveloperId = 2,
                            ProjectId = 2
                        });
                });

            modelBuilder.Entity("Api.Models.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DeveloperCPF")
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<int?>("DeveloperId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("DeveloperId1", "DeveloperCPF");

                    b.ToTable("Entry");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeveloperId = 1,
                            EndDate = new DateTime(2021, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            DeveloperId = 1,
                            EndDate = new DateTime(2021, 1, 16, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 3,
                            DeveloperId = 1,
                            EndDate = new DateTime(2021, 1, 17, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 17, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 4,
                            DeveloperId = 1,
                            EndDate = new DateTime(2021, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 18, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 5,
                            DeveloperId = 1,
                            EndDate = new DateTime(2021, 1, 19, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 19, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 7,
                            DeveloperId = 2,
                            EndDate = new DateTime(2021, 1, 16, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 16, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 8,
                            DeveloperId = 2,
                            EndDate = new DateTime(2021, 1, 17, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 17, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 9,
                            DeveloperId = 2,
                            EndDate = new DateTime(2021, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 18, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 10,
                            DeveloperId = 2,
                            EndDate = new DateTime(2021, 1, 19, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 19, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 11,
                            DeveloperId = 3,
                            EndDate = new DateTime(2021, 1, 18, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 18, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 12,
                            DeveloperId = 3,
                            EndDate = new DateTime(2021, 1, 19, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 19, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 13,
                            DeveloperId = 3,
                            EndDate = new DateTime(2021, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 20, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 14,
                            DeveloperId = 4,
                            EndDate = new DateTime(2021, 1, 19, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 19, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 15,
                            DeveloperId = 4,
                            EndDate = new DateTime(2021, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 20, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 16,
                            DeveloperId = 5,
                            EndDate = new DateTime(2021, 1, 19, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 19, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 17,
                            DeveloperId = 5,
                            EndDate = new DateTime(2021, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 20, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 18,
                            DeveloperId = 6,
                            EndDate = new DateTime(2021, 1, 20, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InitialDate = new DateTime(2021, 1, 20, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectId = 3
                        });
                });

            modelBuilder.Entity("Api.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Web App"
                        },
                        new
                        {
                            Id = 2,
                            Name = "API"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Database"
                        });
                });

            modelBuilder.Entity("TesteDotnet.Models.ViewModels.WorkedHoursRank", b =>
                {
                    b.Property<int>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<int>("WorkedHours")
                        .HasColumnType("int");

                    b.ToTable("WorkedHoursRank");
                });

            modelBuilder.Entity("Api.Models.DeveloperProject", b =>
                {
                    b.HasOne("Api.Models.Project", "Project")
                        .WithMany("DeveloperProject")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Models.Developer", "Developer")
                        .WithMany("DeveloperProject")
                        .HasForeignKey("DeveloperId1", "DeveloperCPF");

                    b.Navigation("Developer");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Api.Models.Entry", b =>
                {
                    b.HasOne("Api.Models.Project", "Project")
                        .WithMany("Entries")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Models.Developer", "Developer")
                        .WithMany("Entries")
                        .HasForeignKey("DeveloperId1", "DeveloperCPF");

                    b.Navigation("Developer");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Api.Models.Developer", b =>
                {
                    b.Navigation("DeveloperProject");

                    b.Navigation("Entries");
                });

            modelBuilder.Entity("Api.Models.Project", b =>
                {
                    b.Navigation("DeveloperProject");

                    b.Navigation("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}