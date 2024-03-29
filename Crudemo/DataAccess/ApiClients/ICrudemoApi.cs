﻿using Crudemo.Models;
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
        Task<ApiResponse<Person>> Get(int id);

        /// <summary>
        /// Returns IEnumerable of object.
        /// </summary>
        [Get("/person")]
        Task<ApiResponse<IEnumerable<Person>>> Get();

        /// <summary>
        /// Updates object.
        /// </summary>
        [Put("/person/{model.Id}")]
        Task<ApiResponse<Person>> Update(Person model);

        /// <summary>
        /// Inserts object.
        /// </summary>
        [Post("/person")]
        Task<ApiResponse<Person>> Insert([Body] Person model);

        /// <summary>
        /// Deletes object.
        /// </summary>
        [Delete("/person/{id}")]
        Task Delete(int id);
    }
}
