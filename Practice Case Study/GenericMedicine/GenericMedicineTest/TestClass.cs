using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GenericMedicine;

namespace GenericMedicineTest
{
    [TestFixture]
    public class TestClass
    {
         Program program;
         Medicine medicine;
         CartonDetail carton;

       [OneTimeSetUp]
        public void SetUp()
        {
            program = new Program();
            medicine = new Medicine();
            carton = new CartonDetail();

        }
        [Test]
        [TestCase("Akriti","Sinarest","PhenylPhrine HCL Paracetamol","01/01/2023",20)]
        [TestCase("", "Sinarest", "PhenylPhrine HCL Paracetamol", "01/01/2023", 20)]
        [TestCase("Akriti", "Sinarest", "PhenylPhrine HCL Paracetamol", "01/01/2023", -10)]
        [TestCase("Akriti", "Sinarest", "PhenylPhrine HCL Paracetamol", "01/01/2016", 20)]
        public void TestGenericMedicine(string name,string genericMedicine,string composition, string expiryDate,double pricePerStrip)
        {

            try
            {
                medicine = program.CreateMedicineDetail(name, genericMedicine, composition, DateTime.Parse(expiryDate), pricePerStrip);
                Assert.IsNotNull(medicine);
                //Assert.IsNull(medicine);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        [Test]
        [TestCase(10, "09/03/2021", "Baguiati")]//correct
        [TestCase(10, "10/10/2000", "Baguiati")]//incorrect launch date
        [TestCase(-10, "10/10/2021", "Baguiati")]//incorrect strip count
        [TestCase(10, "01/02/2023", "Baguiati")]//launch date greater than expiry date
        [TestCase(10, "10/10/2021", "")]//Incorrect retailer address
        public void TestCartonDetails(int medicineStripCount, string launchDate, string retailerAddress)
        {
            try
            {
                medicine = program.CreateMedicineDetail("Akriti", "Sinarest", "PhenylPhrine HCL Paracetamol", DateTime.Parse("01/01/2023"), 20);
                carton = program.CreateCartonDetail(medicineStripCount, DateTime.Parse(launchDate), retailerAddress, medicine);
                Assert.IsNotNull(carton);
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);                
            }
        }
    }
}
