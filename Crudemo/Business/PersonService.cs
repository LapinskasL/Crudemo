using Crudemo.Business.Interfaces;
using Crudemo.Business.Responses;
using Crudemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crudemo.Business
{
    public class PersonService : IPersonService
    {
        public PersonResponse Delete(int id, string concurrencyToken)
        {
            throw new NotImplementedException();
        }

        public PersonResponse Delete(Person model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> Get()
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public PersonResponse Insert(Person model)
        {
            throw new NotImplementedException();
        }

        public PersonResponse Update(Person model)
        {
            throw new NotImplementedException();
        }
    }
}
