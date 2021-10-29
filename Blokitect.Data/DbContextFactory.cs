using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blokitect.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var dbContextOptions = new DbContextOptionsBuilder<AppDbContext>();
            dbContextOptions.UseSqlServer("Server=DESKTOP-ROV0CNI;Database=Blokitect;Trusted_Connection=True;MultipleActiveResultSets=True;");
            return new AppDbContext(dbContextOptions.Options);
        }
    }
}
