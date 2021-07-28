using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudemo.WebUI.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string ConcurrencyToken { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
