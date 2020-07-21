using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace RAT.EntityFramework
{
    public class RatDbContextFactory : IDesignTimeDbContextFactory<RatDbContext>
    {
        public RatDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<RatDbContext>();
            options.UseSqlServer("Server = localhost; Database = RatDB; Trusted_Connection = True;");
            return new RatDbContext(options.Options);
        }
    }
}
