using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Models;

namespace TodoAPI.Repository
{
    public static class DbContextFactory
    {
        public static Dictionary<string, string> ConnectionStrings { get; set; }

        public static void SetConnectionString(Dictionary<string, string> connStrs)
        {
            ConnectionStrings = connStrs;
        }

        public static BCCPContext Create(string connid)
        {
            if (!string.IsNullOrEmpty(connid))
            {
                var connStr = ConnectionStrings[connid];
                var optionsBuilder = new DbContextOptionsBuilder<BCCPContext>();
                optionsBuilder.UseSqlServer(connStr);
                return new BCCPContext(optionsBuilder.Options);
            }
            else
            {
                throw new ArgumentNullException("ConnectionId");
            }
        }
    }
}
// Intialize DbContext factory

// In startup.cs

// public void Configure()
// {
//   Dictionary<string, string> connStrs = new Dictionary<string, string>();
//   connStrs.Add("DB1", Configuration["Data:DB1Connection:ConnectionString"]);
//   connStrs.Add("DB2", Configuration["Data:DB2Connection:ConnectionString"]);
//   DbContextFactory.SetConnectionString(connStrs);
// }
// Usage

// var dbContext= DbContextFactory.Create("DB1");