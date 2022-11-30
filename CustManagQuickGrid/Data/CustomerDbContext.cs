using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CustManagQuickGrid.Data;

public class CustomerDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=Data/CustomerDB.db");

    public DbSet<Customer> Customers { get; set; }
}

