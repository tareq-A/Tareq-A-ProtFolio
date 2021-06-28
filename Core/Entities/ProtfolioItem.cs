namespace Core.Entities
{
    /// <summary>
    /// Defines the <see cref="ProtfolioItem" />.
    /// </summary>
    public class ProtfolioItem : EntityBase
    {
        /// <summary>
        /// Gets or sets the ProjectName.
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the ImageUrl.
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
