using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {

            var customerInDb = _context.Customers.Single(c => c.Id == newRental.Customer_Id);

            var movies = _context.Movies.Where(m => newRental.Movies_Ids.Contains((byte)m.Id)).ToList();

                

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie not Available");
                
                    Rental rental = new Rental()
                    {
                        Customer = customerInDb,
                        Movie = movie,
                        DateRented = DateTime.Now,



                    };
                    movie.NumberAvailable--;
                    _context.Rentals.Add(rental);
                
            }
             _context.SaveChanges();
            return Ok();

        }
    }
}
