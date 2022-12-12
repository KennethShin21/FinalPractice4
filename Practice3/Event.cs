using System;

namespace Practice3
{
    public class Event
    {
        private string _eventTitle;
        private string _description;
        private DateOnly _date;
        private TimeOnly _time;
        private string _address;
        private string _userType;

        public Event()
        {

        }
        public string GetUserType()
        {
            switch(this.GetType().ToString())
            {
                case "Practice3.Lecture" :
                    _userType = "Lecture";
                    break;                
                case "Practice3.Gathering" :
                    _userType = "Gathering";
                    break;
                case "Practice3.Reception" :
                    _userType = "Reception";
                    break;
                default:
                    _userType = "Standard Event";
                    break;
            }

            return _userType;
        }

        //This function will print out a short detail of the event.
        public string GetShortDetails()
        {
            return $"Title: {GetTitle()}, Date: {GetDate()}, and Event Type: {GetUserType()}";
        }

        //This function will print all the details for an event.
        public string GetFullEvent()
        {
            return $"Title: {GetTitle()}, Description: {GetDescription()}, Date: {GetDate()}, Time: {GetTime()}, and Address: {GetAddress()}";
        }
        //The following would be my getters.
        public string GetTitle()
        {
            return _eventTitle;
        }
        public string GetDescription()
        {
            return _description;
        }
        public DateOnly GetDate()
        {
            return _date;
        }
        public TimeOnly GetTime()
        {
            return _time;
        }
        public string GetAddress()
        {
            return _address;
        }
        //The following would be my setters.
        public void SetTitle(string title)
        {
            _eventTitle = title;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }
        public void SetDate(DateOnly date)
        {
            _date = date;
        }
        public void SetTime(TimeOnly time)
        {
            _time = time;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }
    }
}