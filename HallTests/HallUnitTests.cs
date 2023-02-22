using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bioscoop.Models;

namespace HallTests
{
    [TestClass]
    public class HallUnitTest
    {
        [TestMethod]
        public void AddSeatsToSeatPlan_Valid()
        {
            //arrange
            int capacity = 120;
            int id = 0;
            List<bool> expected = new List<bool>();
            expected.Add(true);
            Hall hall = new Hall(id, capacity);

        }
    }
}
