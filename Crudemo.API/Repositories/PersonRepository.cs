using Crudemo.API.Models.Person;
using Crudemo.API.Repositories.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Crudemo.API.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> Get()
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            using System.Data.IDbConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Crudemo;Trusted_Connection=True;");
            Person model = connection.QueryFirstOrDefault<Person>(
                    "SELECT Id, FirstName, LastName, PhoneNumber, ConcurrencyToken, DateAdded " +
                    "FROM Persons " +
                    "WHERE Id = @Id",
                    new { id }
                );
            return model;
        }

        public int Insert(Person model)
        {
            throw new NotImplementedException();
        }

        public void Update(Person model)
        {
            throw new NotImplementedException();
        }
    }
}
