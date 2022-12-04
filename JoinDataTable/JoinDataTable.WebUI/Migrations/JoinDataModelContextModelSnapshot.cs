﻿// <auto-generated />
using System;
using JoinDataTable.WebUI.Models.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JoinDataTable.WebUI.Migrations
{
    [DbContext(typeof(JoinDataModelContext))]
    partial class JoinDataModelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JoinDataTable.WebUI.Models.Model.About", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PdfUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("About", "dbo");
                });

            modelBuilder.Entity("JoinDataTable.WebUI.Models.Model.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PdfUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductCategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoCopyright")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoDesign")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoKeywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoReply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ProductCategoryID");

                    b.ToTable("Product", "dbo");
                });

            modelBuilder.Entity("JoinDataTable.WebUI.Models.Model.ProductCategory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoCopyright")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoDesign")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoKeywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoReply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seoTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ProductCategory", "dbo");
                });

            modelBuilder.Entity("JoinDataTable.WebUI.Models.Model.Product", b =>
                {
                    b.HasOne("JoinDataTable.WebUI.Models.Model.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("JoinDataTable.WebUI.Models.Model.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}