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

    //creates a boolean to know whether the customer lives in USA or not
    public bool USAorNot()
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