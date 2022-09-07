using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class WellnessDbContext:DbContext
    {
        public WellnessDbContext():base("WellnessDBString")
        {

        }
        public DbSet<Tbl_Login> Logins { get; set; }
    }
}
