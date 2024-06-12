using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmAutomaiton
{
    internal class RentedMovie
    {
        public string Id { get; set; }
        public Movie Movie { get; set; }
        public Person Person { get; set; }
        public string RentalDate { get; set; }
        public string ReturnDate { get; set; }
        public String Price { get; set; }

        public RentedMovie(string id, Movie movie, Person person, string rentalDate, string returnDate, String price)
        {
            Id = id;
            Movie = movie;
            Person = person;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            Price = price;
        }

        
    }
}
