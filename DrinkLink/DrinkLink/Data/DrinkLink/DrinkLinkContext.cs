﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace DrinkLink.Data.DrinkLink
{
    public partial class DrinkLinkContext : DbContext
    {
        public DrinkLinkContext()
        {
        }
        public IConfiguration Configuration { get; }

        public DrinkLinkContext(DbContextOptions<DrinkLinkContext> options)
            : base(options)
        {
        }
     

        public virtual DbSet<DrinkLinkContacts> DrinkLinkContacts { get; set; }
        public virtual DbSet<DrinkLinkOrder> DrinkLinkOrder { get; set; }
        public virtual DbSet<DrinkLinkProductCategory> DrinkLinkProductCategory { get; set; }
        public virtual DbSet<DrinkLinkProductQuantity> DrinkLinkProductQuantity { get; set; }
        public virtual DbSet<DrinkLinkProducts> DrinkLinkProducts { get; set; }

        public virtual DbSet<DrinkLinkOrderCurrentCustomer> DrinkLinkCurrentOrderCustomer { get; set; }

        public virtual DbSet<DrinkLinkOrderCurrentProduct> DrinkLinkCurrentOrderProduct { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                if (!optionsBuilder.IsConfigured)
            {
                var connString = Configuration.GetConnectionString("DefaultConnection");
                optionsBuilder
                    
                    .EnableSensitiveDataLogging(false)
                    .UseSqlServer(connString, options => options.MaxBatchSize(150));
            }
            base.OnConfiguring(optionsBuilder);
        }


   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

       

            modelBuilder.Entity<DrinkLinkContacts>(entity =>
            {
                entity.HasKey(e => e.DlContactEmail)
                    .HasName("DlContact_PK");

                entity.HasIndex(e => e.DlContactId)
                    .HasName("UQ__DrinkLin__524BF877B58973A6")
                    .IsUnique();

                entity.Property(e => e.DlContactEmail)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DlContactAddressLine1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DlContactAddressLine2)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DlContactAddressLine3).HasMaxLength(255);

                entity.Property(e => e.DlContactAddressPostCode).HasMaxLength(15);

                entity.Property(e => e.DlContactId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DlContactName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DlContactOwnership)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DlContactsIsConfirmed)
               
                .HasDefaultValue(0);
            });

            modelBuilder.Entity<DrinkLinkOrder>(entity =>
            {
                entity.HasKey(e => e.DlOrderId)
                    .HasName("DlOrder_PK");

                entity.HasIndex(e => e.DlOrderId)
                    .HasName("UQ__DrinkLin__562E53B1FBA2AFEE")
                    .IsUnique();

                entity.Property(e => e.DlOrderId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DlOrderCustomerId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DlOrderDate).HasColumnType("datetime");

                entity.Property(e => e.DlOrderProductId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DlOrderQuantity)
                    .IsRequired();
                    

                entity.Property(e => e.DlOrderParentOrderId)
                    .IsRequired()
                    .HasMaxLength(255)
                     .HasMaxLength(50); ;
            }); 

            modelBuilder.Entity<DrinkLinkProductCategory>(entity =>
            {
                entity.HasKey(e => e.DlProductCategoryName)
                    .HasName("DlProductCategory_PK");

                entity.HasIndex(e => e.DlProductCategoryId)
                    .HasName("UQ__DrinkLin__818DAC6916F9F224")
                    .IsUnique();

                entity.Property(e => e.DlProductCategoryName)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.DlProductCategoryId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DrinkLinkProductQuantity>(entity =>
            {
                entity.HasKey(e => e.DlProductQuantityProductId)
                    .HasName("DrinkLinkProductQuantity_PK");

                entity.HasIndex(e => e.DlProductQuantityProductId)
                    .HasName("UQ__DrinkLin__3F32B541ADA4E22B")
                    .IsUnique();

                entity.Property(e => e.DlProductQuantityProductId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });



            modelBuilder.Entity<DrinkLinkOrderCurrentCustomer>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<DrinkLinkOrderCurrentProduct>(entity =>
            {
                entity.HasNoKey();
            });


            modelBuilder.Entity<DrinkLinkProducts>(entity =>
            {
                entity.HasKey(e => new { e.DlProductName, e.DlProductAvailableQUantity })
                    .HasName("DlProduct_PK");

                entity.HasIndex(e => e.DlProductId)
                    .HasName("UQ__DrinkLin__1E363FB550CBA4B0")
                    .IsUnique();

                entity.Property(e => e.DlProductName).HasMaxLength(255);

                entity.Property(e => e.DlProductAvailableQUantity).HasMaxLength(255);

                entity.Property(e => e.DlProductDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DlProductId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DlProductOwnership)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}