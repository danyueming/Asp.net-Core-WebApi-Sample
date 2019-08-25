﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZFS.EFCore.DbFile;

namespace ZFS.EFCore.Migrations
{
    [DbContext(typeof(ZfsDbContext))]
    [Migration("20190724142847_zfs")]
    partial class zfs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("ZFS.Core.Entity.Authorithitem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthorityName");

                    b.Property<string>("AuthorityValue");

                    b.HasKey("Id");

                    b.ToTable("Authorithitems");
                });

            modelBuilder.Entity("ZFS.Core.Entity.Dictionary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("DataCode");

                    b.Property<string>("EnglishName");

                    b.Property<DateTime>("LastUpdate");

                    b.Property<string>("LastUpdateBy");

                    b.Property<string>("NativeName");

                    b.Property<string>("TypeCode");

                    b.HasKey("Id");

                    b.ToTable("Dictionaries");
                });

            modelBuilder.Entity("ZFS.Core.Entity.DictionaryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TypeCode");

                    b.Property<string>("TypeName");

                    b.HasKey("Id");

                    b.ToTable("DictionaryTypes");
                });

            modelBuilder.Entity("ZFS.Core.Entity.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GroupCode");

                    b.Property<string>("GroupName");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ZFS.Core.Entity.GroupFunc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Authorities");

                    b.Property<string>("GroupCode");

                    b.Property<string>("MenuCode");

                    b.HasKey("Id");

                    b.ToTable("GroupFuncs");
                });

            modelBuilder.Entity("ZFS.Core.Entity.GroupUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account");

                    b.Property<string>("GroupCode");

                    b.HasKey("Id");

                    b.ToTable("GroupUsers");
                });

            modelBuilder.Entity("ZFS.Core.Entity.LoginLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account");

                    b.Property<DateTime>("CurrentTime");

                    b.HasKey("Id");

                    b.ToTable("LoginLogs");
                });

            modelBuilder.Entity("ZFS.Core.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MenuAuthorities");

                    b.Property<string>("MenuCaption");

                    b.Property<string>("MenuCode");

                    b.Property<string>("MenuName");

                    b.Property<string>("MenuNameSpace");

                    b.Property<string>("ParentName");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("ZFS.Core.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account");

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Email");

                    b.Property<char>("FlagAdmin");

                    b.Property<char>("FlagOnline");

                    b.Property<int>("IsLocked");

                    b.Property<DateTime>("LastLoginTime");

                    b.Property<DateTime>("LastLogouTime");

                    b.Property<int>("LoginCounter");

                    b.Property<string>("Password");

                    b.Property<string>("Tel");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
