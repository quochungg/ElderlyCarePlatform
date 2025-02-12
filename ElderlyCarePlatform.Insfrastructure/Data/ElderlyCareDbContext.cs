using ElderlyCarePlatform.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElderlyCarePlatform.Insfrastructure.Data
{
    public class ElderlyCareDbContext : IdentityDbContext<User>

    {

        public ElderlyCareDbContext(DbContextOptions<ElderlyCareDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
