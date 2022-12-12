using System;

namespace Practice2
{
    class Customer
    {
        private string _customerName;
        private string _customerCountry;
        
    
    public void SetCountry(string country)
    {
        _customerCountry = country;
    }
    public bool Domestic()
        {
            if (_customerCountry == "USA")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}