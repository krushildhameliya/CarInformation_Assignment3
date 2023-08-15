using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarInformation_Assignment3.Models;

namespace CarInformation_Assignment3.Data
{
    public class CarInformation_Assignment3Context : DbContext
    {
        public CarInformation_Assignment3Context (DbContextOptions<CarInformation_Assignment3Context> options)
            : base(options)
        {
        }

        public DbSet<CarInformation_Assignment3.Models.CarInfo> CarInfo { get; set; } = default!;
    }
}
