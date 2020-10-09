﻿using System;
using System.Collections.Generic;
using System.Text;
using BrainWork.ATM.Data;
using Microsoft.EntityFrameworkCore;

namespace BrainWork.ATM.Data
{
    public class ATMContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<DepositMode> DepositModes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<SiteContent> SiteContents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            string connectionString = "Data Source=DESKTOP-4QP868O\\SQLEXPRESS;Initial Catalog=ATMproject;Integrated Security=True";

            OptionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<User>().Property(b => b.FirstName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.lastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Address1).HasColumnType("varchar(500)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Address2).HasColumnType("varchar(500)");
            modelBuilder.Entity<User>().Property(b => b.Landmark).HasColumnType("varchar(100)");
            modelBuilder.Entity<User>().Property(b => b.City).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.State).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Pincode).HasColumnType("varchar(6)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Email).HasColumnType("varchar(200)").IsRequired();
            //Account type
            modelBuilder.Entity<AccountType>().Property(b => b.Name).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Status>().Property(b => b.Name).HasColumnType("varchar(50)").IsRequired();
            //Account
            modelBuilder.Entity<Account>().Property(b => b.CustomerNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.AccountNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.AvailableBalance).HasColumnType("decimal(10,2)").IsRequired();
            //Deposit Model
            modelBuilder.Entity<DepositMode>().Property(b => b.Name).HasColumnType("varchar(50)").IsRequired();
            //transactionType model
            modelBuilder.Entity<TransactionType>().Property(b => b.Name).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<TransactionType>().Property(b => b.ShortCode).HasColumnType("varchar(10)").IsRequired();
            //Transaction Model
            modelBuilder.Entity<Transaction>().Property(b => b.TransactionNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Transaction>().Property(b => b.TransactionDate).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Transaction>().Property(b => b.Amount).HasColumnType("decimal(10,2)").IsRequired();

            modelBuilder.Entity<SiteContent>().Property(b => b.Reference).HasColumnType("varchar(100)").IsRequired();
            modelBuilder.Entity<SiteContent>().Property(b => b.Key).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<SiteContent>().Property(b => b.Value).HasColumnType("varchar(500)").IsRequired();
        }


    }
}
