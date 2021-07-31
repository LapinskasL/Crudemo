using Crudemo.Business.Responses;
using Crudemo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crudemo.Business.Interfaces
{
    public interface IPersonService
    {
        /// <summary>
        /// Returns IEnumerable of objects.
        /// </summary>
        public Task<IEnumerable<Person>> Get();

        /// <summary>
        /// Returns one object by Id.
        /// </summary>
        public Task<Person> Get(int id);

        /// <summary>
        /// Updates object.
        /// </summary>
        /// <returns>PersonResponse containing updated object.</returns>
        public Task<PersonResponse> Update(Person model);

        /// <summary>
        /// Inserts obejct.
        /// </summary>
        /// <returns>PersonResponse containing inserted object.</returns>
        public Task<PersonResponse> Insert(Person model);

        /// <summary>
        /// Deletes object by Id.
        /// </summary>
        /// <returns>PersonResponse object.</returns>
        public Task<PersonResponse> Delete(int id);
    }
}
