using Microsoft.EntityFrameworkCore;
using BookStore.Shared;

namespace BookStore.Server
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var BookEntity = modelBuilder.Entity<Book>();
            BookEntity.HasKey(Book => Book.Id);
            BookEntity.Property(Book => Book.Name).HasMaxLength(80);
            BookEntity.Property(Book => Book.Price).HasColumnType("money");
            BookEntity.Property(Book => Book.imagebook).HasConversion<string>();

            var ordersEntity = modelBuilder.Entity<Order>();
            ordersEntity.HasKey(order => order.Id);
            ordersEntity.HasOne(order => order.Customer);
            ordersEntity.HasMany(order => order.Books).WithMany(Book => Book.Orders);

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.HasKey(customer => customer.ID);
            customerEntity.Property(customer => customer.Name).HasMaxLength(100);
            customerEntity.Property(customer => customer.Street).HasMaxLength(50);
            customerEntity.Property(customer => customer.City).HasMaxLength(50);

        }

    }
}
