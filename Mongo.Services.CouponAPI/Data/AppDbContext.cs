using Microsoft.EntityFrameworkCore;
using Mongo.Services.CouponAPI.Model;

namespace Mongo.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Coupon> Coupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(
                new Coupon
                {
                    CouponId = 1,
                    CouponCode = "10Off",
                    DiscountAmount = 10,
                    MinAmount = 20
                },
                new Coupon
                {
                    CouponId = 2,
                    CouponCode = "10Ogg",
                    DiscountAmount = 20,
                    MinAmount = 30
                }
            );

        }

    }
}
