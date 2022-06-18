using Microsoft.EntityFrameworkCore;
using ChartDiagram.Models;


namespace ChartDiagram.DataLayer
{
    public class DbContextSales : DbContext
    {
        public DbContextSales(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SalesEntity> Sales { get; set; }
    }
}
