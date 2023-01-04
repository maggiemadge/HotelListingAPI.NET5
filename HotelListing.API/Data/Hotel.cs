using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Data
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country Country { get; set; }


    }

    internal class ForeignKeyAttribute : Attribute
    {
        private string v;

        public ForeignKeyAttribute(string v)
        {
            this.v = v;
        }
    }
}
