namespace Core.Interfaces
{
    /// <summary>
    /// Defines the <see cref="IUnitOfWork{T}" />.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public interface IUnitOfWork<T> where T : class
    {
        /// <summary>
        /// Gets the Entity.
        /// </summary>
        IGenericRepository<T> Entity { get; }

        /// <summary>
        /// The Save.
        /// </summary>
        void Save();
    }
}
