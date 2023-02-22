using Xunit;
using Bioscoop.Models;

namespace UnitTests
{
    public class HallTests
    {
        [Fact]
        public void AddSeatsToSeatPlan_InputIs1_ReturnFalse()
        {
            Hall hall = new Hall(0, 120);
            hall.SeatPlan = new List<bool>(hall.Capacity);
            hall.AddSeatsToSeatPlan(115);
            List<bool> testSeatPlan = hall.SeatPlan;
            string resultString = testSeatPlan.Count.ToString();

            Assert.False(testSeatPlan.Count == 0, $"{resultString} is what it is");


        }

        [Fact]
        public void AddSeatsToSeatPlan_InputIs2_ReturnTrue()
        {
            Hall hall = new Hall(0, 5);
            hall.SeatPlan = new List<bool>(hall.Capacity);
            hall.AddSeatsToSeatPlan(2);
            List<bool> testSeatPlan = hall.SeatPlan;
            string resultString = testSeatPlan.Count.ToString();

            Assert.True(testSeatPlan.Count == 2, $"{resultString} is what it is");


        }
    }
}
