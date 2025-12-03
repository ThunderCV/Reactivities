using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

// inherit from DbContext instance
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; }
}

// GPT corrected:
// public class AppDbContext : DbContext
// {
//     public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//     {   
//     }

//     public required DbSet<Activity> Activities { get; set; }
// }
