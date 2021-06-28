namespace Infrastructure.Repository
{
    using Core.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="GenericRepository{T}" />.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Defines the _context.
        /// </summary>
        private readonly DataContext _context;

        /// <summary>
        /// Defines the tabel.
        /// </summary>
        private readonly DbSet<T> tabel = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{T}"/> class.
        /// </summary>
        /// <param name="context">The context<see cref="DataContext"/>.</param>
        public GenericRepository(DataContext context)
        {
            _context = context;
            tabel = _context.Set<T>();
        }

        /// <summary>
        /// The Delete.
        /// </summary>
        /// <param name="id">The id<see cref="object"/>.</param>
        public void Delete(object id)
        {
            T entity = GetByID(id);
            tabel.Remove(entity);
        }

        /// <summary>
        /// The GetAll.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{T}"/>.</returns>
        public IEnumerable<T> GetAll()
        {
            return tabel.ToList();
        }

        /// <summary>
        /// The GetByID.
        /// </summary>
        /// <param name="id">The id<see cref="object"/>.</param>
        /// <returns>The <see cref="T"/>.</returns>
        public T GetByID(object id)
        {
            return tabel.Find(id);
        }

        /// <summary>
        /// The Insert.
        /// </summary>
        /// <param name="entity">The entity<see cref="T"/>.</param>
        public void Insert(T entity)
        {
            tabel.Add(entity);
        }

        /// <summary>
        /// The Update.
        /// </summary>
        /// <param name="entity">The entity<see cref="T"/>.</param>
        public void Update(T entity)
        {
            tabel.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
