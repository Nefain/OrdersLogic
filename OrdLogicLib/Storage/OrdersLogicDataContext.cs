using Microsoft.EntityFrameworkCore;
using OrdLogicLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdLogicLib.Storage
{
    public class OrdersLogicDataContext : DbContext
    {
        //const string connectionString = "Server=localhost\\SQLEXPRESS;Database=OrdersLogic;Trusted_Connection=True;MultipleActiveResultSets=true;Connect Timeout=15;Encrypt=False;Packet Size=4096";
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<TrancheModel> Tranches { get; set; }
        public DbSet<PaymentModel> Payments { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentModel>()
                .HasKey(e => new { e.IdOrder, e.IdTranche });

            modelBuilder.Entity<PaymentModel>()
                .HasOne(e => e.OrderModel)
                .WithMany()
                .HasForeignKey(e => e.IdOrder);

            modelBuilder.Entity<PaymentModel>()
                .HasOne(e => e.TrancheModel)
                .WithMany()
                .HasForeignKey(e => e.IdTranche);

            modelBuilder.Entity<UserModel>()
                .HasOne(e => e.OrderModel)
                .WithOne()
                .HasForeignKey<UserModel>(e => e.UserOrdersIdGuid);
        }
        public OrdersLogicDataContext(DbContextOptions options) : base(options)
        {

        }
    }
}
