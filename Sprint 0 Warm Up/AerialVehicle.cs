using System;

namespace Sprint_0_Warm_Up
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }

        protected Engine Engine { get; set; }

        protected bool IsFlying { get; set; }

        protected int MaxAltitude { get; set; }

        public AerialVehicle()
        {
            IsFlying = false;
            Engine = new Engine();
        }

        public virtual string About()
        {
            string returnString = "This " + this + " has a max altitude of " + MaxAltitude + " ft." + "\n";
            returnString += "It's current altitude is " + CurrentAltitude + " ft. \n";
            returnString += Engine + " is" + (Engine.IsStarted ? "" : " not") + " started.";

            return returnString;

        }

        public virtual string TakeOff()
        {
            if(Engine.IsStarted)
            {
                IsFlying = true;
                return "Taking off!";
            } else
            {
                return "The engine is not started.";
            }
        }

        public virtual string StartEngine()
        {
            Engine.Start();
            return this + " is flying";

        }

        public void FlyDown(int howMuch)
        {
            if(howMuch <= CurrentAltitude)
            {
                CurrentAltitude -= howMuch;
            }

        }

        internal void FlyUp()
        {
            FlyUp(1000);
        }

        internal void FlyUp(int HowMuch)
        {
            if(CurrentAltitude + HowMuch <= MaxAltitude)
            {
                CurrentAltitude += HowMuch;
            }
        }
    }
}