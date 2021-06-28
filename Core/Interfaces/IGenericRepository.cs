namespace Core.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IGenericRepository{T}" />.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{T}"/>.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// The GetByID.
        /// </summary>
        /// <param name="id">The id<see cref="object"/>.</param>
        /// <returns>The <see cref="T"/>.</returns>
        T GetByID(object id);

        /// <summary>
        /// The Insert.
        /// </summary>
        /// <param name="entity">The entity<see cref="T"/>.</param>
        void Insert(T entity);

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="entity">The entity<see cref="T"/>.</param>
        void Update(T entity);

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="id">The id<see cref="object"/>.</param>
        void Delete(object id);
    }
}
