using System;

namespace Practice4
{
    public class Cycling : Activity
    {
        private float _speed;

        public Cycling()
        {

        }
  
        public void SetSpeed(int speed)
        {
            _speed = speed;
        }
        
        public override float GetSpeed()
        {
            return _speed;
        }

        //This is where polymorphism goes! We just override the GetSumarry()!
        public override string GetSummary()
        {
            return $"{GetDate()} Cycling ({GetMinutes()} min) - Distance {GetDistance()} km, Speed {GetSpeed().ToString("0.00")} kph, Pace: {GetPace().ToString("0.0")} min per km.";
        } 


    }
}