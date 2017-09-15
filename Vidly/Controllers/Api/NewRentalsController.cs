using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //checks if movieIds have been supplied
            if (newRental.MovieIds.Count == 0)
                return BadRequest("No Movie Ids have been given");
            
            var customer = _context.Customers.SingleOrDefault((
                c => c.Id == newRental.CustomerId));

            // checks if customer id is invalid
            if (customer == null)
                return BadRequest("Invalid Customer Id");          

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            //checks if movieIds are valid
            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or more movie Ids invalid");

            foreach (var movie in movies)
            {
                //checks if this movie is available
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is  not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add((rental));
            }

            _context.SaveChanges();

            return Ok();

        }
    }
}