﻿// <auto-generated />
using System;
using BankDbConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BankDbConnection.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20240120134342_FixRations")]
    partial class FixRations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("account_number");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<Guid>("CurrencyIdAmount")
                        .HasColumnType("uuid")
                        .HasColumnName("currency_id");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CurrencyIdAmount");

                    b.ToTable("account");
                });

            modelBuilder.Entity("Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<bool>("InBlackList")
                        .HasColumnType("boolean")
                        .HasColumnName("in_black_list");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("number_phone");

                    b.Property<Guid>("PassportId")
                        .HasColumnType("uuid")
                        .HasColumnName("passport_id");

                    b.HasKey("Id");

                    b.HasIndex("PassportId")
                        .IsUnique();

                    b.ToTable("client");
                });

            modelBuilder.Entity("Models.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("adress");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("employee_id");

                    b.Property<string>("MailIndex")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("mail_index");

                    b.Property<string>("MainContract")
                        .HasColumnType("text")
                        .HasColumnName("main_contract");

                    b.Property<string>("NameCompany")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name_company");

                    b.Property<string>("OtherCondition")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("other_condition");

                    b.Property<string>("WorkTime")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("work_time");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("contract");
                });

            modelBuilder.Entity("Models.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("TypeCurrency")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type_currency");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("currency");
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<Guid>("CurrencyIdSalary")
                        .HasColumnType("uuid")
                        .HasColumnName("currency_id");

                    b.Property<DateTime>("EndContractDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("end_contract_date");

                    b.Property<bool>("InBlackList")
                        .HasColumnType("boolean")
                        .HasColumnName("in_black_list");

                    b.Property<string>("JobPositionType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("job_position_type");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("number_phone");

                    b.Property<Guid>("PassportId")
                        .HasColumnType("uuid")
                        .HasColumnName("passport_id");

                    b.Property<DateTime>("StartWorkDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_work_date");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyIdSalary");

                    b.HasIndex("PassportId")
                        .IsUnique();

                    b.ToTable("employee");
                });

            modelBuilder.Entity("Models.Passport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateBorn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_born");

                    b.Property<DateTime>("DateGivePassport")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_give_passport");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("LocationResidence")
                        .HasColumnType("text")
                        .HasColumnName("location_residence");

                    b.Property<string>("NumberPassport")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("number_passport");

                    b.Property<string>("PlaceBorn")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("place_born");

                    b.Property<string>("PlaceGivePassport")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("place_give_passport");

                    b.Property<string>("SecondName")
                        .HasColumnType("text")
                        .HasColumnName("second_name");

                    b.HasKey("Id");

                    b.ToTable("passport");
                });

            modelBuilder.Entity("Models.Account", b =>
                {
                    b.HasOne("Models.Client", "Client")
                        .WithMany("Accounts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyIdAmount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("Models.Client", b =>
                {
                    b.HasOne("Models.Passport", "Passport")
                        .WithOne("Client")
                        .HasForeignKey("Models.Client", "PassportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passport");
                });

            modelBuilder.Entity("Models.Contract", b =>
                {
                    b.HasOne("Models.Employee", "Employee")
                        .WithOne("Contract")
                        .HasForeignKey("Models.Contract", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.HasOne("Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyIdSalary")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Passport", "Passport")
                        .WithOne("Employee")
                        .HasForeignKey("Models.Employee", "PassportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("Passport");
                });

            modelBuilder.Entity("Models.Client", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.Navigation("Contract");
                });

            modelBuilder.Entity("Models.Passport", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
