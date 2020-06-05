using Microsoft.EntityFrameworkCore;
using QuantityMeasurmentCommanLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentRepositoriesLayer.Context
{
    public class RepoDBContext : DbContext
    {
        public RepoDBContext(DbContextOptions<RepoDBContext> options) : base(options)
        {
        }
        public DbSet<MeasurmentModel> Measurments { get; set; }
    }
}
