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
            hall.AddSeatsToSeatPlan(120);
            bool result = hall.AddSeatsToSeatPlan(5);
            string resultString = hall.SeatPlan.Count.ToString();

            Assert.False(result, $"{resultString} is current amount of seats taken");


        }

        [Fact]
        public void AddSeatsToSeatPlan_InputIs2_ReturnTrue()
        {
            Hall hall = new Hall(0, 5);
            hall.SeatPlan = new List<bool>(hall.Capacity);
            bool result = hall.AddSeatsToSeatPlan(2);
            string resultString = hall.SeatPlan.Count.ToString();

            Assert.True(result, $"{resultString} is current amount of seats taken");


        }
    }
}
