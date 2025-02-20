using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcess.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Game> Jogos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
}