﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ocean.Infrastructure.Context;

namespace Ocean.Infrastructure.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20200809055533_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ocean.Domain.Core.Events.StoredEvent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("AggregateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Data")
                        .HasColumnType("varchar(Max)");

                    b.Property<string>("MessageType")
                        .HasColumnName("MessageType")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("Timestamp")
                        .HasColumnType("DateTime");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("StoredEvent");
                });

            modelBuilder.Entity("Ocean.Domain.Hostility.Entity.HostilityEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("HostilityId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreateTime")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("HostilityLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostilityName")
                        .IsRequired()
                        .HasColumnName("HostilityName")
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsSurpass")
                        .HasColumnName("IsSurpass")
                        .HasColumnType("bit");

                    b.Property<int?>("MilitaryPower")
                        .IsRequired()
                        .HasColumnName("MilitaryPower")
                        .HasColumnType("int");

                    b.Property<string>("QQNumber")
                        .IsRequired()
                        .HasColumnName("QQNumber")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Remark")
                        .HasColumnName("Remark")
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("RoleLevel")
                        .HasColumnName("RoleLevel")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnName("UpdateBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Hostility");
                });

            modelBuilder.Entity("Ocean.Domain.Model.Relation.Entity.UserRoleRelation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("Id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("RoleId")
                        .HasColumnName("RoleId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserId")
                        .HasColumnName("UserId")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("SystemUserRoleRelation");
                });

            modelBuilder.Entity("Ocean.Domain.Model.Role.Entity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("Id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreateTime")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("RoleName")
                        .HasColumnName("RoleName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UpdateBy")
                        .HasColumnName("UpdateBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("SystemRole");
                });

            modelBuilder.Entity("Ocean.Domain.Model.User.Entity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("Id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnName("AccountName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CreateBy")
                        .HasColumnName("CreateBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreateTime")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("EmadilAddress")
                        .HasColumnName("EmadilAddress")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Enabled")
                        .HasColumnName("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nick")
                        .IsRequired()
                        .HasColumnName("Nick")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnName("PassWord")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("QQNumber")
                        .HasColumnName("QQNumber")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tel")
                        .HasColumnName("Tel")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UpdateBy")
                        .HasColumnName("UpdateBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnName("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("SystemUser");
                });

            modelBuilder.Entity("Ocean.Domain.Model.Relation.Entity.UserRoleRelation", b =>
                {
                    b.HasOne("Ocean.Domain.Model.Role.Entity.Role", "RoleInfo")
                        .WithMany("userRoleRelations")
                        .HasForeignKey("RoleId");

                    b.HasOne("Ocean.Domain.Model.User.Entity.User", "UserInfo")
                        .WithMany("userRoleRelations")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Ocean.Domain.Model.User.Entity.User", b =>
                {
                    b.OwnsOne("Ocean.Domain.Model.User.Entity.Address", "address", b1 =>
                        {
                            b1.Property<string>("UserId")
                                .HasColumnType("varchar(50)");

                            b1.Property<string>("City")
                                .HasColumnName("AddressCity")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Location")
                                .HasColumnName("AddressLocation")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Province")
                                .HasColumnName("AddressProvince")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("UserId");

                            b1.ToTable("SystemUser");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
