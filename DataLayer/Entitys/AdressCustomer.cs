using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entitys
{
    public class AdressCustomer
    {
        internal int Id { get; set; }
        public string City { get; set;}
        public string Country { get; set;}
        public string PhoneNumber { get; set;}
        public string PostalCode { get; set;}
        public string NameStreet { get; set;}
        public string NumberBulding { get; set;}

        public string NumberHouse { get; set;}

        public ICollection<Customer>? Customers { get; set;}
        
    }
}
