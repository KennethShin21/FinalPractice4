using System;

namespace Practice4
{
    public class Swimming : Activity
    {
        private float _lapCount;
        private float _metersLap;
           
        public Swimming()
        {
            _metersLap = 50.00f;

        }

        public override float GetDistance()
        {
            return (GetLaps() * _metersLap) / 1000;
        }

        public override float GetSpeed()
        {
            
            return (GetDistance() / GetMinutes()) *60;
        }

        public void SetLaps(float laps)
        {
            _lapCount = laps;
        }
        public float GetLaps()
        {
            return _lapCount;
        }
        public override string GetSummary()
        {
            return $"{GetDate()} Swimming ({GetMinutes()} min) - Distance {GetDistance()} km, Speed {GetSpeed().ToString("0.00")} kph, Pace: {GetPace().ToString("0.0")} min per km.";
        } 
    }
}