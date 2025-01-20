using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElderlyCarePlatform.Insfrastructure.Data
{
    public class ElderlyCareDbContext : DbContext
    {
        public ElderlyCareDbContext()
        {
            
        }

        public ElderlyCareDbContext(DbContextOptions<ElderlyCareDbContext> options) : base(options)
        {

        }


    }
}
