using System;

namespace Foundation3
{
    public class Address
    {
        protected string _street;
        protected string _city;
        protected string _state;
        protected string _country;


        public Address()
        {

        }

        public void SetAddress(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        public string GetAddress()
        {
            return $"{_street}, {_city}, {_state}, {_country}";
        }


    }
}