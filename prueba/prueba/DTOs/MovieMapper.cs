using prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba.DTOs
{
    public static class MovieMapper
    {
        public static MovieDTO ToDTO(Movie movie)
        {
            return new MovieDTO
            {
                Id = movie.Id,
                Name = movie.Name,
                GenreId = movie.GenreId,
                DateAdded = movie.DateAdded,
                ReleaseDate = movie.ReleaseDate,
                NumberInStock = movie.NumberInStock
            };
        }

        public static Movie ToMovie(MovieDTO movieDTO)
        {
            return new Movie
            {
                Id = movieDTO.Id,
                Name = movieDTO.Name,
                GenreId = movieDTO.GenreId,
                DateAdded = movieDTO.DateAdded,
                ReleaseDate = movieDTO.ReleaseDate,
                NumberInStock = movieDTO.NumberInStock
            };
        }

        public static void UpdateMovie(Movie movie, MovieDTO movieDTO)
        {
            movie.Name = movieDTO.Name;
            movie.GenreId = movieDTO.GenreId;
            movie.DateAdded = movieDTO.DateAdded;
            movie.ReleaseDate = movieDTO.ReleaseDate;
            movie.NumberInStock = movieDTO.NumberInStock;
        }

    }
}