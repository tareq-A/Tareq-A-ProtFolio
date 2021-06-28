namespace Infrastructure.UnitOfWork
{
    using Core.Interfaces;
    using Infrastructure.Repository;

    /// <summary>
    /// Defines the <see cref="UnitOfWork{T}" />.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        /// <summary>
        /// Defines the _context.
        /// </summary>
        private readonly DataContext _context;

        /// <summary>
        /// Defines the _Entity.
        /// </summary>
        private IGenericRepository<T> _Entity;

        /// <summary>
        /// Gets the Entity.
        /// </summary>
        public IGenericRepository<T> Entity
        {
            get
            {
#pragma warning disable IDE0074 // Use compound assignment
                return _Entity ?? (_Entity = new GenericRepository<T>(_context));
#pragma warning restore IDE0074 // Use compound assignment
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork{T}"/> class.
        /// </summary>
        /// <param name="context">The context<see cref="DataContext"/>.</param>
        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// The Save.
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
