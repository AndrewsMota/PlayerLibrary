using Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public class AppDbContext : DbContext
{
    public DbSet<Game> Jogos { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}