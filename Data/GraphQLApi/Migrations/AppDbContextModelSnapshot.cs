﻿// <auto-generated />
using System;
using GraphQLApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GraphQLApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GraphQLApi.Models.AcademyFacilityModel", b =>
                {
                    b.Property<Guid>("AcademyId")
                        .HasColumnType("uuid");

                    b.Property<int>("FacilitiesQuality")
                        .HasColumnType("integer");

                    b.Property<int>("ManagerQuality")
                        .HasColumnType("integer");

                    b.Property<string>("SecondTeamName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AcademyId");

                    b.ToTable("AcademyFacilities");
                });

            modelBuilder.Entity("GraphQLApi.Models.CalendarEventModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Day")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

                    b.Property<Guid?>("MatchId")
                        .HasColumnType("uuid");

                    b.Property<int>("Month")
                        .HasColumnType("integer");

                    b.Property<bool>("NotEditable")
                        .HasColumnType("boolean");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TeamModelId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TrainingId")
                        .HasColumnType("uuid");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("TeamModelId");

                    b.HasIndex("TrainingId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("GraphQLApi.Models.LeagueModel", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("GraphQLApi.Models.LogoModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("IconId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MainColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SecondaryColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Logos");
                });

            modelBuilder.Entity("GraphQLApi.Models.MatchModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("AwayScore")
                        .HasColumnType("integer");

                    b.Property<Guid>("AwayTeamId")
                        .HasColumnType("uuid");

                    b.Property<int?>("Ground")
                        .HasColumnType("integer");

                    b.Property<int?>("HomeScore")
                        .HasColumnType("integer");

                    b.Property<Guid>("HomeTeamId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("GraphQLApi.Models.PlayerModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int>("Condition")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ContractTo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Foot")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("InjuredTill")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsBenched")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsInAcademy")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("boolean");

                    b.Property<double>("MarketValue")
                        .HasColumnType("double precision");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PlayerNumber")
                        .HasColumnType("integer");

                    b.Property<int>("PlayerRating")
                        .HasColumnType("integer");

                    b.Property<int>("PositionType")
                        .HasColumnType("integer");

                    b.Property<int>("PotentialRating")
                        .HasColumnType("integer");

                    b.Property<int>("SquadPosition")
                        .HasColumnType("integer");

                    b.Property<bool>("Suspended")
                        .HasColumnType("boolean");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<double>("Wage")
                        .HasColumnType("double precision");

                    b.Property<bool>("YellowCard")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("GraphQLApi.Models.ProfitModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Season")
                        .HasColumnType("integer");

                    b.Property<double?>("Stadium")
                        .HasColumnType("double precision");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TeamModelId")
                        .HasColumnType("uuid");

                    b.Property<double?>("Transfers")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("TeamModelId");

                    b.ToTable("Profits");
                });

            modelBuilder.Entity("GraphQLApi.Models.ScoresModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Draws")
                        .HasColumnType("integer");

                    b.Property<string>("Form")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("LeagueId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("LeagueModelId")
                        .HasColumnType("uuid");

                    b.Property<int>("Lost")
                        .HasColumnType("integer");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<int>("Season")
                        .HasColumnType("integer");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<int>("Wins")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LeagueModelId");

                    b.HasIndex("TeamId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("GraphQLApi.Models.ShirtModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsSecond")
                        .HasColumnType("boolean");

                    b.Property<string>("MainColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SecondaryColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TeamModelId")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TeamModelId");

                    b.ToTable("Shirts");
                });

            modelBuilder.Entity("GraphQLApi.Models.SpendingModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double?>("Salaries")
                        .HasColumnType("double precision");

                    b.Property<int>("Season")
                        .HasColumnType("integer");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("TeamModelId")
                        .HasColumnType("uuid");

                    b.Property<double?>("Transfers")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("TeamModelId");

                    b.ToTable("Spendings");
                });

            modelBuilder.Entity("GraphQLApi.Models.StadiumModel", b =>
                {
                    b.Property<Guid>("StadiumId")
                        .HasColumnType("uuid");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<int>("FansExtrasQuality")
                        .HasColumnType("integer");

                    b.Property<int>("SeatQuality")
                        .HasColumnType("integer");

                    b.Property<string>("StadiumName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StadiumId");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("GraphQLApi.Models.TeamHistoryInfoModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("From")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("To")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamHistories");
                });

            modelBuilder.Entity("GraphQLApi.Models.TeamModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Budget")
                        .HasColumnType("double precision");

                    b.Property<int>("DayOfCreation")
                        .HasColumnType("integer");

                    b.Property<Guid>("LogoId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("LogoId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("GraphQLApi.Models.TrainingModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("TrainingType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("GraphQLApi.Models.UserPreferencesModel", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<bool>("BottomMenu")
                        .HasColumnType("boolean");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NavbarColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("UserPreferences");
                });

            modelBuilder.Entity("GraphQLApi.Models.CalendarEventModel", b =>
                {
                    b.HasOne("GraphQLApi.Models.MatchModel", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId");

                    b.HasOne("GraphQLApi.Models.TeamModel", null)
                        .WithMany("Calendar")
                        .HasForeignKey("TeamModelId");

                    b.HasOne("GraphQLApi.Models.TrainingModel", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingId");

                    b.Navigation("Match");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("GraphQLApi.Models.PlayerModel", b =>
                {
                    b.HasOne("GraphQLApi.Models.TeamModel", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("GraphQLApi.Models.ProfitModel", b =>
                {
                    b.HasOne("GraphQLApi.Models.TeamModel", null)
                        .WithMany("Profits")
                        .HasForeignKey("TeamModelId");
                });

            modelBuilder.Entity("GraphQLApi.Models.ScoresModel", b =>
                {
                    b.HasOne("GraphQLApi.Models.LeagueModel", null)
                        .WithMany("Scores")
                        .HasForeignKey("LeagueModelId");

                    b.HasOne("GraphQLApi.Models.TeamModel", "Team")
                        .WithMany("Scores")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("GraphQLApi.Models.ShirtModel", b =>
                {
                    b.HasOne("GraphQLApi.Models.TeamModel", null)
                        .WithMany("Shirts")
                        .HasForeignKey("TeamModelId");
                });

            modelBuilder.Entity("GraphQLApi.Models.SpendingModel", b =>
                {
                    b.HasOne("GraphQLApi.Models.TeamModel", null)
                        .WithMany("Spendings")
                        .HasForeignKey("TeamModelId");
                });

            modelBuilder.Entity("GraphQLApi.Models.TeamHistoryInfoModel", b =>
                {
                    b.HasOne("GraphQLApi.Models.PlayerModel", "Player")
                        .WithMany("TeamHistory")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraphQLApi.Models.TeamModel", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("GraphQLApi.Models.TeamModel", b =>
                {
                    b.HasOne("GraphQLApi.Models.LogoModel", "Logo")
                        .WithMany()
                        .HasForeignKey("LogoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Logo");
                });

            modelBuilder.Entity("GraphQLApi.Models.LeagueModel", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("GraphQLApi.Models.PlayerModel", b =>
                {
                    b.Navigation("TeamHistory");
                });

            modelBuilder.Entity("GraphQLApi.Models.TeamModel", b =>
                {
                    b.Navigation("Calendar");

                    b.Navigation("Players");

                    b.Navigation("Profits");

                    b.Navigation("Scores");

                    b.Navigation("Shirts");

                    b.Navigation("Spendings");
                });
#pragma warning restore 612, 618
        }
    }
}
