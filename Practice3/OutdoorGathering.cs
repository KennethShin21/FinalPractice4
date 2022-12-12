using System;

namespace Practice3
{
    public class OutdoorGathering : Event
    {
        private string _forecast;

        public OutdoorGathering()
        {

        }
        //This function is the full information on Outdoor Gathering event!
        public string PrintOutdoorGathering()
        {
            return $"Title: {GetTitle()}, Description: {GetDescription()}, Date: {GetDate()}, Time: {GetTime()}, Address:  {GetAddress()}, and Weather Forecast: {GetForecast()}";
        }

       
        public string GetForecast()
        {
            return _forecast;
        }


        public void SetForecast(string forecast)
        {            
            _forecast = forecast;
        }
    }
}