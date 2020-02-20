using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MechanicApi.Models
{
    public class MechanicContext: DbContext
    {
        public MechanicContext(DbContextOptions<MechanicContext> options) :
            base(options)
        {

        }

        DbSet<Owner> Owners { get; set; }
        DbSet<Vehicle> Vehicles { get; set; }
        DbSet<Job> Jobs { get; set; }
    }
}
