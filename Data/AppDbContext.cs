using System;
using CRUDTesteComplete.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDTesteComplete.Data
{
  public class AppDbContext : DbContext
  {
    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlite(connectionString: "DataSource=app2.db;Cache=Shared");

  }
}