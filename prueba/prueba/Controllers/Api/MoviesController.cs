using AutoMapper;
using prueba.DTOs;
using prueba.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Data.Entity;

namespace prueba.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: api/Movies
        public IHttpActionResult GetMovies(string query = null)
        {
            var moviesQuery = _context.Movies
                .Include(m => m.Genre)
                .Where(m => m.NumberAvailable > 0);

            if (!String.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(query));
            
            return Ok(moviesQuery.ToList().Select(MovieMapper.ToDTO));
        }

        // GET: api/Movies/1
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return BadRequest();
            
            return Ok(MovieMapper.ToDTO(movie));
        }

        // POST: api/Movies
        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult CreateMovie(MovieDTO movieDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = MovieMapper.ToMovie(movieDTO);

            var genreList = _context.Genres.ToList();
            var genre = genreList.FirstOrDefault(g =>g.Id == movie.GenreId);
            movie.Genre = genre;

            if (movie.Genre == null)
                return BadRequest();

            movieDTO.Id = movie.Id;

            _context.Movies.Add(movie);
            _context.SaveChanges();


            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDTO);
        }

        // PUT: api/Movies/1
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult UpdateMovie(int id, MovieDTO movieDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
                return NotFound();
            
            MovieMapper.UpdateMovie(movieInDb, movieDTO);
            _context.SaveChanges();

            return Ok();
        }

        // DELETE: api/Movies/1
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(d => d.Id == id);

            if (movieInDb == null)
                return NotFound();

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}