using System.Collections.Generic;
using System.Linq;
using LifeLine.Core;
using LifeLine.Core.Interfaces;

namespace LifeLine.Infrastructure
{
   public class BloodDonorRepository : IBloodDonorRepository
    {
       BloodDonorContext context = new BloodDonorContext();
        public void Add(BloodDonor b)
        {
            context.BloodDonors.Add(b);
            context.SaveChanges();
        }

        public void Edit(BloodDonor b)
        {
            context.Entry(b).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(string BloodDonorID)
        {
            BloodDonor b = context.BloodDonors.Find(BloodDonorID);
            context.BloodDonors.Remove(b);
            context.SaveChanges();
        }

        public IEnumerable<BloodDonor> GetBloodDonors()
        {
            return context.BloodDonors;
        }

        public BloodDonor FindById(string BloodDonorID)
        {
            var bloodDonor = (from r in context.BloodDonors where r.BloodDonorID == BloodDonorID select r).FirstOrDefault();
            return bloodDonor; 
        }
    }
}
