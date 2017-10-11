using Domain.Models.POCOs;
using Domain.Models.ViewModels;
using Domain.Services.Database;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services
{
    /// <summary>
    /// MovieService Interface
    /// </summary>
    public interface IMovieService
    {
        Task<MovieGenreViewModel> IndexRequest(string movieGenre, string searchString);
        Movie DetailRequest(int id);
    }

    public class MovieService : IMovieService
    {
        private readonly ApplicationContext _context;
        private readonly IDatabaseService<Movie> _db;

        public MovieService(ApplicationContext context, IDatabaseService<Movie> db)
        {
            _context = context;
            _db = db;
        }

        /// <summary>
        /// GET all Movies OR get by Genre AND/OR get by searchString
        /// </summary>
        /// <param name="movieGenre"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public async Task<MovieGenreViewModel> IndexRequest(string movieGenre = default(string), string searchString = default(string))
        {
            var vm = new MovieGenreViewModel();

            var movies = from m in _context.Movie select m;

            // Use LINQ to get populate Movie genres
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;
            // ...then populate selectlist
            vm.Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            if (String.IsNullOrEmpty(movieGenre) && String.IsNullOrEmpty(searchString))
            {
                vm.Movies = await movies.ToListAsync();
            }
            // Genre search
            else if (!String.IsNullOrEmpty(movieGenre) && String.IsNullOrEmpty(searchString))
            {
                vm.Movies = await movies.Where(x => x.Genre == movieGenre).ToListAsync();
            }
            // String search
            else if (!String.IsNullOrEmpty(searchString) && String.IsNullOrEmpty(movieGenre))
            {
                // Search against Movie Title..modified!
                vm.Movies = await movies.Where(s => s.Title.Contains(searchString)).ToListAsync();
            }
            // Genre and string search
            else if(!String.IsNullOrEmpty(movieGenre) && !String.IsNullOrEmpty(searchString))
            {
                vm.Movies = await movies.Where(s => s.Title.Contains(searchString) && s.Genre == movieGenre).ToListAsync();
            }

            return vm;
        }

        public Movie DetailRequest(int id)
        {
            //var vm = new MovieViewModel();

            var movie = _db.FindById(id);

            //vm.ID = movie.ID;
            //vm.Title = movie.Title;
            //vm.ReleaseDate = movie.ReleaseDate;
            
            return movie;
        }        
    }
}