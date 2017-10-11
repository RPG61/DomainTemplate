using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Services;

namespace Domain.UX.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService) =>
            _movieService = movieService;

        // GET: Movies
        public async Task<IActionResult> Index(string movieGenre = default(string), string searchString = default(string)) =>
            View(await _movieService.IndexRequest(movieGenre, searchString));

        // GET: Movies/Details/5
        public IActionResult Details(int id) =>
            View(_movieService.DetailRequest(id));
    }
}
