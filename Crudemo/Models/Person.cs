using System;
using System.Collections.Generic;
using System.Text;

namespace Crudemo.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ConcurrencyToken { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
