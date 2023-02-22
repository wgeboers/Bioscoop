using System.Diagnostics.CodeAnalysis;

namespace Bioscoop.Models
{
    /*
     * TODO: 
     * CREATE UNIT TEST
     */
    public class Hall
    {

        public required int Id { get; set; }

        //1-3 = 8x15 = 120 capacity
        //4 = 6x10 = 60 capacity
        //5-6 = 2x10 + 2x15 = 50
        public required int Capacity { get; set; }
        private bool Projector3D { get; set; }
        private bool WheelChairFriendly { get; set; }

        public List<bool>? SeatPlan { get; set; }

        [SetsRequiredMembers]
        public Hall(int id, int capacity) => (Id, Capacity) = (id, capacity);

        /*
         * TO (MAYBE) DO:
         * -Create UnitTest
         * -Find a way to match a sublist of an amount of seats to the overall seatplan
         * !!!IF ALLOCATION REMOVAL IS USED THE ABOVE TODO MUST BE IMPLEMENTED!!!
         * 
         * Adds seats to the seatplan sequentially
         */
        public void AddSeatsToSeatPlan(int amount)
        {
           if ((Capacity - SeatPlan.Count) >= amount)
           {
                for (int i = 0; i < amount; i++)
                {
                    SeatPlan!.Add(true);
                }
            }
        }

        /*
         * To be used for adding seat allocations based on a location picked... (Sprint 2/3)
         */
        public void AddSeatAllocation(int seatIndex, int amount = 0)
        {
            if (amount > 0 && Capacity - SeatPlan.Count > amount)
            {
                for (int i = 0; i <= amount; i++)
                {
                    SeatPlan[seatIndex] = true;
                }
            }
            else
            {
                if (amount == 0)
                {
                    SeatPlan![seatIndex] = true;
                }
            }
        }

        /*
         *  Used to remove an allocated seat
         */
        public void RemoveSeatAllocation(int seatNumber)
        {
            SeatPlan.RemoveAt(seatNumber - 1);

        }
    }
}
