using Domain.Models.BaseModels;
using Domain.Models.POCOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Domain.Models.ViewModels
{
    public class MovieGenreViewModel : Base.ViewModel
    {
        public IList<Movie> Movies;
        public SelectList Genres;

        public string MovieGenre { get; set; }

        /// <summary>
        /// Ctors
        /// </summary>
        public MovieGenreViewModel() { }

        public MovieGenreViewModel(IList<Movie> movies, SelectList genres)
        {
            Movies = movies;
            Genres = genres;
        }
    }
}
