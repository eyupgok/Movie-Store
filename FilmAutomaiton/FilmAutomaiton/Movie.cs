using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmAutomaiton
{
    internal class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }

        public Movie(string id, string title, string genre, string year)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Year = year;
        }

        
    }

}
