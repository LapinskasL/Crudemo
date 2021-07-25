using Crudemo.API.Models.Person;
using Crudemo.API.Repositories.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Crudemo.API.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IDbConnection _connection;

        public PersonRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Delete(int id)
        {
            //TODO handle concurrency
            _connection.Execute(
                "DELETE FROM Persons " +
                "WHERE Id = @Id",
                new { id }
            );
        }

        public IEnumerable<Person> Get()
        {
            IEnumerable<Person> models = _connection.Query<Person>(
                "SELECT Id, FirstName, LastName, PhoneNumber, ConcurrencyToken, DateAdded " +
                "FROM Persons"
            );
            return models;
        }

        public Person Get(int id)
        {
            Person model = _connection.QueryFirstOrDefault<Person>(
                "SELECT Id, FirstName, LastName, PhoneNumber, ConcurrencyToken, DateAdded " +
                "FROM Persons " +
                "WHERE Id = @Id",
                new { id }
            );
            return model;
        }

        public int Insert(Person model)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@FirstName", model.FirstName);
            parameters.Add("@LastName", model.LastName);
            parameters.Add("@PhoneNumber", model.PhoneNumber);
            parameters.Add("@InsertedId", dbType: DbType.Int32, direction: ParameterDirection.Output);
            _connection.Execute(
                "PersonsInsertPerson",
                parameters,
                commandType: CommandType.StoredProcedure
            );

            return parameters.Get<int>("@InsertedId");
        }

        public void Update(Person model)
        {
            //TODO handle concurrency
            DynamicParameters parameters = new DynamicParameters(model);
            _connection.Execute(
                "UPDATE Persons " +
                "SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber " +
                "WHERE Id = @Id " +
                "AND ConcurrencyToken = @ConcurrencyToken",
                parameters
            );
        }
    }
}
