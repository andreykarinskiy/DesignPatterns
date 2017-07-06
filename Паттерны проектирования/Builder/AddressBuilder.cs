using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public sealed class AddressBuilder : IBuilder<Address>
    {
        private readonly Address address = new Address();

        #region Builder

        public Address Build()
        {
            return address;
        }

        public AddressBuilder Country(string countryAlias)
        {
            address.Country = FindCountryByAlias(countryAlias);
            return this;
        }

        public AddressBuilder City(string cityAlias)
        {
            address.Street = FindCityByAlias(address.Country, cityAlias);
            return this;
        }

        public AddressBuilder Street(string streetAlias)
        {
            address.Street = FindStreetByAlias(address.City, streetAlias);
            return this;
        }

        public AddressBuilder LivesAt(int building, int apart)
        {
            ValidateBuildingAndApartment(building, apart);

            address.Building = building.ToString();
            address.Apartment = apart;
            return this;
        }

        public AddressBuilder Actual()
        {
            address.IsActual = true;
            return this;
        }

        #endregion

        private Country FindCountryByAlias(string countryAlias)
        {
            throw new NotImplementedException();
        }

        private Street FindCityByAlias(Country addressCountry, string cityAlias)
        {
            throw new NotImplementedException();
        }

        private void ValidateBuildingAndApartment(int building, int apart)
        {
            throw new NotImplementedException();
        }

        private Street FindStreetByAlias(City addressCity, string streetAlias)
        {
            throw new NotImplementedException();
        }
    }
}
