﻿// <auto-generated />
using System;
using ArbitraryCollectionMgmt.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArbitraryCollectionMgmt.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240904090852_ApiToken_updated")]
    partial class ApiToken_updated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.ApiToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ApiTokens");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Collection", b =>
                {
                    b.Property<int>("CollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CollectionId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CollectionId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.CustomAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CollectionId")
                        .HasColumnType("int");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("CustomAttributes");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.CustomValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomAttributeId")
                        .HasColumnType("int");

                    b.Property<string>("FieldValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomAttributeId");

                    b.HasIndex("ItemId");

                    b.ToTable("CustomValues");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<int?>("CollectionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ItemId");

                    b.HasIndex("CollectionId");

                    b.HasIndex("OwnedBy");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.ItemTag", b =>
                {
                    b.Property<int>("ItemTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemTagId"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ItemTagId");

                    b.HasIndex("ItemId");

                    b.HasIndex("TagId");

                    b.ToTable("ItemTags");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Like", b =>
                {
                    b.Property<int>("LikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LikeId"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LikeId");

                    b.HasIndex("ItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.UserLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.ApiToken", b =>
                {
                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Collection", b =>
                {
                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.Category", "Category")
                        .WithMany("Collections")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.User", "User")
                        .WithMany("Collection")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Comment", b =>
                {
                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.Item", "Item")
                        .WithMany("Comments")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.CustomAttribute", b =>
                {
                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.Collection", "Collection")
                        .WithMany("CustomAttributes")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.CustomValue", b =>
                {
                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.CustomAttribute", "CustomAttribute")
                        .WithMany("CustomValues")
                        .HasForeignKey("CustomAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.Item", "Item")
                        .WithMany("CustomValues")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomAttribute");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Item", b =>
                {
                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.Collection", "Collection")
                        .WithMany("Items")
                        .HasForeignKey("CollectionId");

                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.User", "User")
                        .WithMany("Item")
                        .HasForeignKey("OwnedBy");

                    b.Navigation("Collection");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.ItemTag", b =>
                {
                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.Item", "Item")
                        .WithMany("ItemTags")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.Tag", "Tag")
                        .WithMany("ItemTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Like", b =>
                {
                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.Item", "Item")
                        .WithMany("Likes")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.User", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.UserLogin", b =>
                {
                    b.HasOne("ArbitraryCollectionMgmt.DAL.Models.User", "User")
                        .WithOne("UserLogin")
                        .HasForeignKey("ArbitraryCollectionMgmt.DAL.Models.UserLogin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Category", b =>
                {
                    b.Navigation("Collections");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Collection", b =>
                {
                    b.Navigation("CustomAttributes");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.CustomAttribute", b =>
                {
                    b.Navigation("CustomValues");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Item", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("CustomValues");

                    b.Navigation("ItemTags");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.Tag", b =>
                {
                    b.Navigation("ItemTags");
                });

            modelBuilder.Entity("ArbitraryCollectionMgmt.DAL.Models.User", b =>
                {
                    b.Navigation("Collection");

                    b.Navigation("Comments");

                    b.Navigation("Item");

                    b.Navigation("Likes");

                    b.Navigation("UserLogin")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
