using Airbnb.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airbnb.Context
{
    public class AirbnbContext: DbContext
    {

        public AirbnbContext(DbContextOptions<AirbnbContext> options):
            base(options)
        {
       
        }
                            
        public DbSet<RoomDatabase> Rooms { get; set; }

    }
}
