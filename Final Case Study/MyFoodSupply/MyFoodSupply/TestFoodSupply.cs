using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyFoodSupply
{
    [TestFixture]
    public class TestFoodSupply
    {
        Program program;
        FoodDetail foodDetail;
        SupplyDetail supplyDetail;

        [OneTimeSetUp]
        public void SetUp()
        {
            program = new Program();
            foodDetail = new FoodDetail();
            supplyDetail = new SupplyDetail();
        }
        [Test]
        [TestCase("Bread",1,"10/03/2021",12)]//correct
        //[TestCase("", 1, "10/03/2021", 12)]//name null
        //[TestCase("Bread", 1, "11/01/2020", 12)]//expiry date less than today's date
        //[TestCase("Bread", 1, "11/03/2021", -222)]//price invalid
        public void TestFoodDetail(string name, int dishType, string expiryDate, double price)
        {
            try
            {
                foodDetail = program.CreateFoodDetail(name, dishType, DateTime.Parse(expiryDate), price);
                Assert.IsNotNull(foodDetail);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

        }
        [Test]
        [TestCase(1,"11/03/2021","ABC",45)]
        //[TestCase(-2, "11/03/2021", "ABC", 45)]//food item count invalid
        //[TestCase(1, "11/01/2020", "ABC", 45)]//incorrect request date
        //[TestCase(1, "11/03/2021", "", 45)]//seller name invalid
        //[TestCase(1, "12/10/2021", "ABC", 45)]//requested date > expiry date
        public void TestSupplyDetail(int foodItemCount, string requestDate, string sellerName, double packingCharge)
        {
            try
            {
                foodDetail = program.CreateFoodDetail("Bread", 1, DateTime.Parse("12/03/2021"), 12);
                supplyDetail = program.CreateSupplyDetail(foodItemCount, DateTime.Parse(requestDate), sellerName, packingCharge, foodDetail);
                Assert.IsNotNull(supplyDetail);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

    }
}
