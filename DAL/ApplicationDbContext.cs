// ===============================
// roberto.garcia@transmaquila.com
// www.transmaquila.com
// ===============================

using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DAL.Models.Interfaces;

namespace DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public string CurrentUserId { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //ASCA classes 

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contributor> Contributors { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<ASCA> ASCAs { get; set; }
        public DbSet<Relationship> Relationships { get; set; }

        //public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        //public DbSet<Withdrawal> Withdraws { get; set; }
        //public DbSet<Transference> Transferences { get; set; }

        //ASCA classes Common
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Company_PayReollRep> Company_PayRollRep { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Person> People { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<UniqueID> UniqueIDs { get; set; }


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            


        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.HasDefaultSchema("Common");


            builder.Entity<ApplicationUser>().HasMany(u => u.Claims).WithOne().HasForeignKey(c => c.UserId).IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.Entity<ApplicationUser>().HasMany(u => u.Roles).WithOne().HasForeignKey(r => r.UserId).IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationRole>().HasMany(r => r.Claims).WithOne().HasForeignKey(c => c.RoleId).IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.Entity<ApplicationRole>().HasMany(r => r.Users).WithOne().HasForeignKey(r => r.RoleId).IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Customer>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Customer>().HasIndex(c => c.Name);
            builder.Entity<Customer>().Property(c => c.Email).HasMaxLength(100);
            builder.Entity<Customer>().Property(c => c.PhoneNumber).IsUnicode(false).HasMaxLength(30);
            builder.Entity<Customer>().Property(c => c.City).HasMaxLength(50);
            builder.Entity<Customer>().ToTable($"App{nameof(this.Customers)}");

            builder.Entity<ProductCategory>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Entity<ProductCategory>().Property(p => p.Description).HasMaxLength(500);
            builder.Entity<ProductCategory>().ToTable($"App{nameof(this.ProductCategories)}");

            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Product>().HasIndex(p => p.Name);
            builder.Entity<Product>().Property(p => p.Description).HasMaxLength(500);
            builder.Entity<Product>().Property(p => p.Icon).IsUnicode(false).HasMaxLength(256);
            builder.Entity<Product>().HasOne(p => p.Parent).WithMany(p => p.Children).OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Product>().ToTable($"App{nameof(this.Products)}");

            builder.Entity<Order>().Property(o => o.Comments).HasMaxLength(500);
            builder.Entity<Order>().ToTable($"App{nameof(this.Orders)}");

            builder.Entity<OrderDetail>().ToTable($"App{nameof(this.OrderDetails)}");

            //builder.Entity<Person>().HasOne(a => a.Address).WithOne(b => b.Person).HasForeignKey<Address>(b => b.Person);
            //builder.Entity<Address>().HasOne(a => a.Person).WithOne(b => b.Address).HasForeignKey<Person>(b => b.Address);

            //ASCA Entities
            builder.Entity<Account>().ToTable("Accounts", "ASCA");
            builder.Entity<Contributor>().ToTable("Contributors", "ASCA");
            builder.Entity<AccountType>().ToTable("AccountTypes", "ASCA");
            builder.Entity<ASCA>().ToTable("ASCAs", "ASCA");
            builder.Entity<Relationship>().ToTable("Relationships", "ASCA");

            //builder.Entity<Transaction>().ToTable("Transactions", "ASCA");
            builder.Entity<Deposit>().ToTable("Deposits", "ASCA");
            //builder.Entity<Withdrawal>().ToTable("Withdrawals", "ASCA");
            //builder.Entity<Transference>().ToTable("Transferences", "ASCA");

            //Common Entities
            builder.Entity<Person>().HasOne(a => a.Address).WithOne(b => b.Person);
            builder.Entity<Address>().HasOne(a => a.Person).WithOne(b => b.Address).HasForeignKey<Address>(p => p.PersonId).IsRequired();

            builder.Entity<Address>().ToTable("Addresses", "ASCA");
            builder.Entity<City>().ToTable("Cities", "ASCA");
            builder.Entity<Company>().ToTable("Companies", "ASCA");
            builder.Entity<Company_PayReollRep>().ToTable("Company_PayRollRep", "ASCA");
            builder.Entity<Country>().ToTable("Countries", "ASCA");
            builder.Entity<Currency>().ToTable("Currencies", "ASCA");
            builder.Entity<Department>().ToTable("Departments", "ASCA");
            builder.Entity<Email>().ToTable("Emails", "ASCA");
            builder.Entity<Employee>().ToTable("Employees", "ASCA");
            builder.Entity<Person>().ToTable("People", "ASCA");
            builder.Entity<Phone>().ToTable("Phones", "ASCA");
            builder.Entity<State>().ToTable("States", "ASCA");
            builder.Entity<UniqueID>().ToTable("UniqueIDs", "ASCA");



        }







        public override int SaveChanges()
        {
            UpdateAuditEntities();
            return base.SaveChanges();
        }


        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            UpdateAuditEntities();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditEntities();
            return base.SaveChangesAsync(cancellationToken);
        }


        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditEntities();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }


        private void UpdateAuditEntities()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));


            foreach (var entry in modifiedEntries)
            {
                var entity = (IAuditableEntity)entry.Entity;
                DateTime now = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedDate = now;
                    entity.CreatedBy = CurrentUserId;
                }
                else
                {
                    base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                    base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                }

                entity.UpdatedDate = now;
                entity.UpdatedBy = CurrentUserId;
            }
        }
    }
}
