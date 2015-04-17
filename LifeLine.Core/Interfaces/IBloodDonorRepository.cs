using System.Collections.Generic;

namespace LifeLine.Core.Interfaces
{
    public interface IBloodDonorRepository   
    {
        //1-3445672832 : Complain numbert Tikona 
        void Add(BloodDonor b);
        void Edit(BloodDonor b);
        void Remove(string BloodDonorID);
        IEnumerable<BloodDonor> GetBloodDonors();
        BloodDonor FindById(string BloodDonorID);

    }
}
