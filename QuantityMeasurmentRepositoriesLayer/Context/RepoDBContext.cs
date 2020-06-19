using Microsoft.EntityFrameworkCore;
using QuantityMeasurmentCommanLayer;
using QuantityMeasurmentCommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepositoriesLayer.Context
{
    public class RepoDbContext : DbContext
    {
        public RepoDbContext(DbContextOptions<RepoDbContext> options) : base(options)
        {
        }
        public DbSet<Length> length { get; set; }
        public DbSet<Temperature>  temperature{ get; set; }
        public DbSet<Volume> volume { get; set; }
        public DbSet<Weight> weight { get; set; }
    }
}
