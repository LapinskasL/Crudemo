using Crudemo.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crudemo.DataAccess.Interfaces
{
    public interface IPersonRepository
    {
        ///// <summary>
        ///// Returns IEnumerable of object.
        ///// </summary>
        //public IEnumerable<Person> Get();

        ///// <summary>
        ///// Returns object by Id.
        ///// </summary>
        //public Person Get(int id);

        ///// <summary>
        ///// Updates object.
        ///// </summary>
        //public void Update(Person model);

        ///// <summary>
        ///// Inserts object.
        ///// </summary>
        ///// <returns>Returns inserted object's Id.</returns>
        //public int Insert(Person model);

        ///// <summary>
        ///// Deletes object by Id and ConcurrencyToken.
        ///// </summary>
        //public void Delete(int id, string concurrencyToken);

        ///// <summary>
        ///// Deletes object.
        ///// </summary>
        ///// <param name="model">Person object with Id and ConcurrencyToken values.</param>
        //public void Delete(Person model);

        [Get("/person")]
        Task<IEnumerable<Person>> Get();

    }
}
