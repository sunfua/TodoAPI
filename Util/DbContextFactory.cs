using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Models;

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