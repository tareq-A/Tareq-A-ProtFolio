namespace Web.Controllers
{
    using Core.Entities;
    using Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using Web.ViewModels;

    /// <summary>
    /// Defines the <see cref="HomeController" />.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Defines the _owner.
        /// </summary>
        private readonly IUnitOfWork<Owner> _owner;

        /// <summary>
        /// Defines the _portfolio.
        /// </summary>
        private readonly IUnitOfWork<ProtfolioItem> _portfolio;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="owner">The owner<see cref="IUnitOfWork{Owner}"/>.</param>
        /// <param name="portfolio">The portfolio<see cref="IUnitOfWork{ProtfolioItem}"/>.</param>
        public HomeController(IUnitOfWork<Owner> owner , IUnitOfWork<ProtfolioItem> portfolio)
        {
            _owner = owner;
            _portfolio = portfolio;
        }

        /// <summary>
        /// The Index.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult Index()
        {
            var HomeViewMdodel = new HomeViewModel
            {
                owner = _owner.Entity.GetAll().First() ,
                protfolioItems = _portfolio.Entity.GetAll().ToList()
            };
            return View(HomeViewMdodel);
        }

        /// <summary>
        /// The About.
        /// </summary>
        /// <returns>The <see cref="IActionResult"/>.</returns>
        public IActionResult About()
        {
            return View();
        }
    }
}
