using Crudemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crudemo.Business.Responses
{
    public class PersonResponse : ResponseBase
    {
        public Person Person { get; set; }
    }
}
