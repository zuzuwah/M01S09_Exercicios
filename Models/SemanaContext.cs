using Microsoft.EntityFrameworkCore;

namespace M01S09.Models;

public class SemanaContext : DbContext
{
    public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
    {
        
    }
    public DbSet<SemanaModel> Semana { get; set; }
}