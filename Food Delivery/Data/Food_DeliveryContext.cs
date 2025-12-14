using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.Domain;

namespace Food_Delivery.Data
{
    public class Food_DeliveryContext : DbContext
    {
        public Food_DeliveryContext (DbContextOptions<Food_DeliveryContext> options)
            : base(options)
        {
        }

        public DbSet<FoodDelivery.Domain.User> User { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.Restaurant> Restaurant { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.PaymentMethod> PaymentMethod { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.OrderItem> OrderItem { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.Order> Order { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.MenuItem> MenuItem { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.Mall> Mall { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.GroupOrderMember> GroupOrderMember { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.GroupOrder> GroupOrder { get; set; } = default!;
        public DbSet<FoodDelivery.Domain.Address> Address { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // FIX: multiple cascade paths (User -> GroupOrderMember)
            modelBuilder.Entity<GroupOrderMember>()
                .HasOne(gom => gom.User)
                .WithMany(u => u.GroupOrderMembers)
                .HasForeignKey(gom => gom.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Payment>()
               .HasOne(p => p.PaymentMethods)
               .WithMany(pm => pm.Payments)
               .HasForeignKey(p => p.PaymentMethodId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Payment>()
               .HasOne(p => p.PaymentMethods)
               .WithMany()
               .HasForeignKey(p => p.PaymentMethodId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
