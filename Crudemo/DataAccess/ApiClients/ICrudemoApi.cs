using Crudemo.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crudemo.DataAccess.ApiClients
{
    public interface ICrudemoApi
    {
        /// <summary>
        /// Returns object by Id.
        /// </summary>
        [Get("/person/{id}")]
        Task<Person> Get(int id);

        /// <summary>
        /// Returns IEnumerable of object.
        /// </summary>
        [Get("/person")]
        Task<IEnumerable<Person>> Get();

        /// <summary>
        /// Updates object.
        /// </summary>
        [Put("/person")]
        Task<Person> Update(Person model);

        /// <summary>
        /// Inserts object.
        /// </summary>
        [Post("/person")]
        Task<Person> Insert([Body] Person model);

        /// <summary>
        /// Deletes object.
        /// </summary>
        [Delete("/person/{id}")]
        Task Delete(int id);
    }
}
