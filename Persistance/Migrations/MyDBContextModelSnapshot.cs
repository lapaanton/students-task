﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using students_task.Persistance;

namespace students_task.Persistance.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("students_task.Domain.Models.Dept", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedDate");

                    b.Property<int>("ProductId");

                    b.Property<int>("UserId");

                    b.HasKey("DeptId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Depts");
                });

            modelBuilder.Entity("students_task.Domain.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("students_task.Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("user_name")
                        .HasMaxLength(64);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("students_task.Domain.Models.Dept", b =>
                {
                    b.HasOne("students_task.Domain.Models.Product")
                        .WithMany("Depts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("students_task.Domain.Models.User")
                        .WithMany("Depts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
