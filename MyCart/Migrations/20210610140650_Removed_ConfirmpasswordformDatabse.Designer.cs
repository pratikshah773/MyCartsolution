// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCart_ClientLayer.Data;

namespace MyCart_ClientLayer.Migrations
{
    [DbContext(typeof(Datacontext))]
    [Migration("20210610140650_Removed_ConfirmpasswordformDatabse")]
    partial class Removed_ConfirmpasswordformDatabse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyCart_ClientLayer.Data.Data_Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("data_Carts");
                });

            modelBuilder.Entity("MyCart_ClientLayer.Data.Data_Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<int>("productPrice")
                        .HasColumnType("int");

                    b.HasKey("productId");

                    b.ToTable("data_Products");
                });

            modelBuilder.Entity("MyCart_ClientLayer.Data.Data_User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CartID")
                        .IsUnique()
                        .HasFilter("[CartID] IS NOT NULL");

                    b.ToTable("data_Users");
                });

            modelBuilder.Entity("MyCart_ClientLayer.Data.Data_User", b =>
                {
                    b.HasOne("MyCart_ClientLayer.Data.Data_Cart", "CartId")
                        .WithOne("User")
                        .HasForeignKey("MyCart_ClientLayer.Data.Data_User", "CartID");

                    b.Navigation("CartId");
                });

            modelBuilder.Entity("MyCart_ClientLayer.Data.Data_Cart", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
