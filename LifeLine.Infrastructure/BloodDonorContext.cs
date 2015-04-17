using System.Data.Entity;
using LifeLine.Core;

namespace LifeLine.Infrastructure
{
   public class BloodDonorContext : DbContext
    {
       public BloodDonorContext()
           : base("name=BloodDonorContextConnectionString")
       {
           var a = Database.Connection.ConnectionString;
       }

       public DbSet<BloodDonor> BloodDonors { get; set; }
    }
}
