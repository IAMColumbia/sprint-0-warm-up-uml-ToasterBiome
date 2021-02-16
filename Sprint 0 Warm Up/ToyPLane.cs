using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public class ToyPlane : Airplane
    {
        public bool isWoundUP;

        public ToyPlane()
        {
            MaxAltitude = 50;
        }

        public override string About()
        {
            string baseString = base.About();
            baseString += "\n" + getWindUpString();
            return baseString;
        }

        public string getWindUpString()
        {
            return "The toy plane is " + (isWoundUP ? "" : "not ") + "wound up";
        }

        public override string StartEngine()
        {
            if (isWoundUP)
            {
                return base.StartEngine();
            }
            else
            {
                return "The toy plane has to be wound up first";
            }
        }

        public override string TakeOff()
        {
            return base.TakeOff();
        }

        public void UnWind()
        {
            isWoundUP = false;
        }

        public void WindUp() {
            isWoundUP = true;
        }
    }
}
