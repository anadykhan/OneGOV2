using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class OneGOV2Context : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
    }
}
