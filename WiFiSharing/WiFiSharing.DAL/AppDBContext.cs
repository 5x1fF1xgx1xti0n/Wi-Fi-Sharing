namespace WiFiSharing.DAL
{
    using Microsoft.EntityFrameworkCore;
    using WiFiSharing.DAL.Entities;

    public class AppDBContext : DbContext
    {
        public DbSet<Drone> Drones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasKey(x => x.Id);

            builder.Entity<Drone>()
                .HasKey(x => x.Id);

            builder.Entity<Order>()
                .HasKey(x => new { x.DroneId, x.UserId });

            builder.Entity<Order>()
                .HasOne(x => x.Drone)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.DroneId);

            builder.Entity<Order>()
                .HasOne(x => x.User)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.UserId);

            base.OnModelCreating(builder);
        }
    }
}
