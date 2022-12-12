using System;

namespace Practice3
{
    public class Lecture : Event
    {
        private string _speaker;
        private string _capacity;

        public Lecture()
        {

        }
        //This function is the full information on Lecture Event!
        public string PrintLecture()
        {
            return $"Title: {GetTitle()}, Description: {GetDescription()}, Date: {GetDate()}, Time:  {GetTime()}, Adress: {GetAddress()}, Speaker:  {GetSpeaker()}, and Capacity: {GetCapacity()}";

        }

        //These are my getters!
        public string GetSpeaker()
        {
            return _speaker;
        }
        public string GetCapacity()
        {
            return _capacity;
        }

        //These are my setters!
        public void SetSpeaker(string speaker)
        {            
            _speaker = speaker;
        }
        public void SetCapacity(string capacity)
        {
            _capacity = capacity;
        }
    }
}