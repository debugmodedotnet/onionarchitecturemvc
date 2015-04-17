using Microsoft.VisualStudio.TestTools.UnitTesting;
using LifeLine.Infrastructure;
using System.Linq;

namespace LifeLine.Test
{
    [TestClass]
    public class BloodDonorRepositoryTest
    {
        BloodDonorRepository repo; 
        [TestInitialize]
        public void TestSetUp()      
        {

            BloodDonorInitalizeDb db = new BloodDonorInitalizeDb();
            System.Data.Entity.Database.SetInitializer(db);
            repo = new BloodDonorRepository();
        }
        [TestMethod] 
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {
            var result = repo.GetBloodDonors();
            Assert.IsNotNull(result);
            var numberOfRecords = result.ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }
    }
}
