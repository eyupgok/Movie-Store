using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmAutomaiton
{
    internal class MovieStore
    {
        public List<Movie> movies = new List<Movie>();
        public List<Person> persons = new List<Person>();
        public List<RentedMovie> rentals = new List<RentedMovie>();



        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public void RentMovie(RentedMovie rental)
        {
            rentals.Add(rental);
        }

        public Movie FindMovie(string id)
        {
            return movies.Find(m => m.Id == id);
        }

        public Person FindPerson(string id)
        {
            return persons.Find(p => p.Id == id);
        }

        public RentedMovie FindRental(string id)
        {
            return rentals.Find(r => r.Id == id);
        }

        private void RemoveMovie(Movie movie)
        {
            movies.Remove(movie);
        }

        private void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

        private void RemoveRentedMovie(RentedMovie rental)
        {
            rentals.Remove(rental);
        }

        public void RemoveMovie(string id)
        {
            Movie movie = movies.Find(m => m.Id == id);
            if (movie != null)
            {
                RemoveRelatedRentals(movie);
                RemoveMovie(movie);
            }
        }

        public void RemovePerson(string id)
        {
            Person person = persons.Find(p => p.Id == id);
            if (person != null)
            {
                RemovePerson(person);
            }

        }

        public void RemoveRentedMovie(string id)
        {
            RentedMovie rental = rentals.Find(r => r.Id == id);
            if (rental != null)
            {
                RemoveRentedMovie(rental);
            }
        }

        private void RemoveRelatedRentals(Movie movie)
        {
            List<RentedMovie> relatedRentals = rentals.FindAll(r => r.Movie.Id == movie.Id);
            foreach (var rental in relatedRentals)
            {
                RemoveRentedMovie(rental);
            }
        }

        private void PersonWriteData()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\eg315\\Desktop\\persons.txt"))
                {
                    foreach (var person in persons)
                    {
                        writer.WriteLine($"{person.Id},{person.FirstName},{person.LastName},{person.Email}");
                    }

                }
            }
            catch (Exception ex)
            {
            }
        }
        private void MovieWriteData()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\eg315\\Desktop\\movies.txt"))
                {
                    foreach (var movie in movies)
                    {
                        writer.WriteLine($"{movie.Id},{movie.Title},{movie.Genre},{movie.Year}");
                    }

                }
            }
            catch (Exception ex)
            {
            }
        }
        private void RentalWriteData()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\eg315\\Desktop\\rentals.txt"))
                {
                    foreach (var rental in rentals)
                    {
                        writer.WriteLine($"{rental.Id},{rental.Movie.Id},{rental.Person.Id},{rental.RentalDate},{rental.ReturnDate},{rental.Price}");
                    }

                }
            }
            catch (Exception ex)
            {
            }
        }
        public void PersonWrite()
        {
            PersonWriteData();
        }
        public void MovieWrite()
        {
            MovieWriteData();
        }
        public void RentalWrite()
        {
            RentalWriteData();
        }

        private void loadPerson()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\eg315\\Desktop\\persons.txt"))
            {
                String Id, FirstName, LastName, Email, line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Id = parts[0];
                    FirstName = parts[1];
                    LastName = parts[2];
                    Email = parts[3];
                    Person newPerson = new Person(Id, FirstName, LastName, Email);
                    AddPerson(newPerson);
                }
            }
            
            
        }
        private void loadMovie()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\eg315\\Desktop\\movies.txt"))
            {
                String Id, Title, Genre, Year, line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Id = parts[0];
                    Title = parts[1];
                    Genre = parts[2];
                    Year = parts[3];
                    Movie newMovie = new Movie(Id, Title, Genre, Year);
                    AddMovie(newMovie);
                }

            }
        }
        private void loadRental()
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\eg315\\Desktop\\rentals.txt"))
            {
                String Id, MovieID, PersonID, RentalDate, ReturnDate, Price, line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Id = parts[0];
                    MovieID = parts[1];
                    PersonID = parts[2];
                    RentalDate = parts[3];
                    ReturnDate = parts[4];
                    Price = parts[5];
                    Person tmpPerson = FindPerson(PersonID);
                    Movie tmpMovie = FindMovie(MovieID);
                    RentedMovie newRentedMovie = new RentedMovie(Id, tmpMovie, tmpPerson, RentalDate, ReturnDate, Price);
                    RentMovie(newRentedMovie);
                }

            }
        }
        private void deleteAllPersons()
        {
            string filePath = "C:\\Users\\eg315\\Desktop\\persons.txt";

            try
            {
                File.WriteAllText(filePath, string.Empty);
            }
            catch (Exception ex)
            {
            }
        }
        private void deleteAllMovies()
        {
            string filePath = "C:\\Users\\eg315\\Desktop\\movies.txt";

            try
            {
                File.WriteAllText(filePath, string.Empty);
            }
            catch (Exception ex)
            {
            }
        }
        private void deleteAllRentedMovies()
        {
            string filePath = "C:\\Users\\eg315\\Desktop\\rentals.txt";

            try
            {
                File.WriteAllText(filePath, string.Empty);
            }
            catch (Exception ex)
            {
            }
        }
        public void loadAll()
        {
            loadMovie();
            loadPerson();
            loadRental();
        }
        public void refreshPerson()
        {
            deleteAllPersons();
            loadPerson();
        }
        public void refreshMovie()
        {
            deleteAllMovies();
            deleteAllRentedMovies();
            loadMovie();
            loadRental() ;
        }
        public void refreshRental()
        {
            deleteAllRentedMovies();
            loadRental();
        }
    }
}