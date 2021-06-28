namespace Core.Entities
{
    /// <summary>
    /// Defines the <see cref="Address" />.
    /// </summary>
    public class Address : EntityBase
    {
        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Street.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the Number.
        /// </summary>
        public int Number { get; set; }
    }
}
