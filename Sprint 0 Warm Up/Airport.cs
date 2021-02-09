using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    class Airport
    {
        public int MaxVehicles;
        public List<AerialVehicle> Vehicles;

        public string AirportCode { get; set; }

        public Airport(string Code)
        {
            AirportCode = Code;
            Vehicles = new List<AerialVehicle>();

        }

        public Airport(string Code, int MaxVehicles) : this(Code)
        {
            this.MaxVehicles = MaxVehicles;
        }

        public string AllTakeOff()
        {
            foreach(AerialVehicle a in Vehicles)
            {
                TakeOff(a);
            }

            return "all taking off!";
        }

        public string TakeOff(AerialVehicle a)
        {
            a.StartEngine();
            a.IsFlying = true;
            a.FlyUp(50);
            Vehicles.Remove(a);
            return a + " taking off!";
        }

        public string Land(AerialVehicle a)
        {
            if (Vehicles.Count < MaxVehicles)
            {
                a.FlyDown(a.CurrentAltitude);
                a.IsFlying = false;
                Vehicles.Add(a);
                return a + " landing!";
            } else
            {
                return "Not enough space!";
            }
        }

        public string Land(List<AerialVehicle> landing)
        {
            foreach(AerialVehicle a in landing)
            {
                Land(a);
            }
            return "All (attempted) landing!";
        }
    }
}
