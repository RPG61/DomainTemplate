using Domain.Models.BaseModels;
using System;

namespace Domain.Models.Dtos
{
    public class MovieDto : Base.Dto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
    }
}
