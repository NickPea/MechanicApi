using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicApi.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int VehicleId { get; set; }
    }
}
