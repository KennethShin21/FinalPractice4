using System;

namespace Practice3
{
    public class Reception : Event
    {
        private string _registered;
        private string _RSVPEmail;

        public Reception()
        {

        }

        //This function is the full information on Reception event!
        public string PrintReception()
        {
            return $"Title: {GetTitle()}, Description: {GetDescription()}, Date: {GetDate()}, Time: {GetTime()}, Address: {GetAddress()}, and RSVP E-mail: {GetRSVPEmail()}";
        }

        //These are the getters!
        public string GetRegistered()
        {
            return _registered;
        }
        public string GetRSVPEmail()
        {            
            return _RSVPEmail;
        }

        //These are the setters!
        public void SetRegistered(string registered)
        {            
            _registered = registered;
        }
        public void SetRSVPEmail(string newRSVPEmail)
        {            
            _RSVPEmail = newRSVPEmail;
        }
    }
}