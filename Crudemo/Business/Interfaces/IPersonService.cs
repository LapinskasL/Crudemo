using Crudemo.Business.Responses;
using Crudemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crudemo.Business.Interfaces
{
    public interface IPersonService
    {
        /// <summary>
        /// Returns IEnumerable of objects.
        /// </summary>
        public IEnumerable<Person> Get();

        /// <summary>
        /// Returns one object by Id.
        /// </summary>
        public Person Get(int id);

        /// <summary>
        /// Updates object.
        /// </summary>
        /// <returns>PersonResponse containing updated object.</returns>
        public PersonResponse Update(Person model);

        /// <summary>
        /// Inserts obejct.
        /// </summary>
        /// <returns>PersonResponse containing inserted object.</returns>
        public PersonResponse Insert(Person model);

        /// <summary>
        /// Deletes object by Id and ConcurrencyToken.
        /// </summary>
        /// <returns>PersonResponse object.</returns>
        public PersonResponse Delete(int id, string concurrencyToken);

        /// <summary>
        /// Deletes object.
        /// </summary>
        /// <param name="model">Person object with Id and ConcurrencyToken values.</param>
        public PersonResponse Delete(Person model);
    }
}
