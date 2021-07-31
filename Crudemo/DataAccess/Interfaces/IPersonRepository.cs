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
        /// <summary>
        /// Returns IEnumerable of object.
        /// </summary>
        public Task<IEnumerable<Person>> Get();

        /// <summary>
        /// Returns object by Id.
        /// </summary>
        public Task<Person> Get(int id);

        /// <summary>
        /// Updates object.
        /// </summary>
        public Task<Person> Update(Person model);

        /// <summary>
        /// Inserts object.
        /// </summary>
        /// <returns>Returns inserted object's Id.</returns>
        public Task<Person> Insert(Person model);

        /// <summary>
        /// Deletes object by Id.
        /// </summary>
        public Task Delete(int id);
    }
}
