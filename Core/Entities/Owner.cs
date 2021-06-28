namespace Core.Entities
{
    /// <summary>
    /// Defines the <see cref="Owner" />.
    /// </summary>
    public class Owner : EntityBase
    {
        /// <summary>
        /// Gets or sets the FullName.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the Profil.
        /// </summary>
        public string Profil { get; set; }

        /// <summary>
        /// Gets or sets the Avater.
        /// </summary>
        public string Avater { get; set; }

        /// <summary>
        /// Gets or sets the Address.
        /// </summary>
        public Address Address { get; set; }
    }
}
