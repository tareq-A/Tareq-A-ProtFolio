namespace Web.ViewModels
{
    using Core.Entities;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="HomeViewModel" />.
    /// </summary>
    public class HomeViewModel
    {
        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        public Owner owner { get; set; }

        /// <summary>
        /// Gets or sets the protfolioItems.
        /// </summary>
        public List<ProtfolioItem> protfolioItems { get; set; }
    }
}
