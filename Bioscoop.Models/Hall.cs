using System.Diagnostics.CodeAnalysis;

namespace Bioscoop.Models
{
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
         * -Find a way to match a sublist of an amount of seats to the overall seatplan
         * !!!IF ALLOCATION REMOVAL/PICKING IS USED THE ABOVE TODO MUST BE IMPLEMENTED!!!
         * 
         * Adds seats to the seatplan sequentially
         */
        public bool AddSeatsToSeatPlan(int amount)
        {
           if (CheckCurrentCapacity() >= amount)
           {
                for (int i = 0; i < amount; i++)
                {
                    SeatPlan!.Add(true);
                }
                return true;
           }
            return false;
        }

        /*
         * To be used for adding seat allocations based on a location picked... (Sprint 2/3)
         */
        public bool AddSeatAllocation(int seatIndex, int amount = 0)
        {
            if (CheckCurrentCapacity() >= amount)
            {
                if (amount == 0)
                {
                    SeatPlan![seatIndex] = true;
                }
                else if (amount > 0)
                {
                    for (int i = 0; i <= amount; i++)
                    {
                        SeatPlan![seatIndex] = true;
                    }
                }
                return true;
            }
            return false;
        }

        /*
         *  Used to remove an allocated seat
         */
        public void RemoveSeatAllocation(int seatNumber)
        {
            SeatPlan!.RemoveAt(seatNumber - 1);

        }

        public int CheckCurrentCapacity()
        {
            return Capacity - SeatPlan.Count;
        }
    }
}
