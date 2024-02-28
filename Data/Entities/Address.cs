using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Address
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string? ApartmentNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string? State { get; set; }

        public string Country { get; set; }
    }
}
