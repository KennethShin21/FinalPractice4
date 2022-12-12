using System;

namespace Practice4
{
    public class Running : Activity
    {
        private int _distance;

        public Running()
        {

        }

        public override float GetSpeed()
        {
            return (GetDistance() / GetMinutes()) * 60f;
        }

        public void SetDistance(int km)
        {
            _distance = km;
        }
        public override float GetDistance()
        {
            return _distance;
        }

        //Override here again for running.
        public override string GetSummary()
        {
            return $"{GetDate()} Running ({GetMinutes()} min) - Distance {GetDistance()} km, Speed {GetSpeed().ToString("0.00")} kph, Pace: {GetPace().ToString("0.0")} min per km.";
        }


    }
}