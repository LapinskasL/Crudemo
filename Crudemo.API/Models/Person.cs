using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudemo.API.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] ConcurrencyToken { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
