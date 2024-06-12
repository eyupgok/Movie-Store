using System.Windows.Forms;

namespace FilmAutomaiton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            movieAddPnl.Size = mainPnl.Size;
            movieAddPnl.Location = mainPnl.Location;
            personAddPnl.Size = mainPnl.Size;
            personAddPnl.Location = mainPnl.Location;
            rentPnl.Visible = false;
            movieAddPnl.Visible = false;
            personAddPnl.Visible = false;
            mainPnl.Visible = true;
            mainBtnPnl.Visible = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            store.loadAll();
            mainGridLoad();
            personGridLoad();
            movieGridLoad();
        }
        MovieStore store = new MovieStore();
        Random rand = new Random();

        public void mainGridLoad()
        {

            foreach (var rentals in store.rentals)
            {
                int rowId = dataGridMain.Rows.Count + 1;
                dataGridMain.Rows.Add(rentals.Id, rentals.Movie.Title, rentals.Person.FirstName, rentals.RentalDate, rentals.ReturnDate,rentals.Price);
            }
        }
        public void personGridLoad()
        {

            foreach (var persons in store.persons)
            {
                dataGridPerson.Rows.Add(persons.Id, persons.FirstName, persons.LastName, persons.Email);
            }
        }
        public void movieGridLoad()
        {

            foreach (var movies in store.movies)
            {
                dataGridMovie.Rows.Add(movies.Id, movies.Title, movies.Genre, movies.Year);
            }
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(idMovieBox.Text, out int result))
            {
                return;
            }
            if (idMovieBox.Text != null && titleMovieBox.Text != null && yearMovieBox.Text != null && genreMovieBox.Text != null)
            {
                Movie tmp = store.FindMovie(idMovieBox.Text);
                if (tmp == null)
                {
                    String id, title, year, genre;
                    id = idMovieBox.Text;
                    title = titleMovieBox.Text;
                    year = yearMovieBox.Text;
                    genre = genreMovieBox.Text;

                    Movie newMovie = new Movie(id, title, genre, year);
                    store.AddMovie(newMovie);
                    dataGridMovie.Rows.Add(id, title, year, genre);
                    store.MovieWrite();
                }
                else { }


            }
        }

        private void addPersonBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(idPersonBox.Text, out int result))
            {
                return;
            }

            if (idPersonBox.Text != null && namePersonBox.Text != null && lastNamePersonBox.Text != null && mailPersonBox.Text != null)
            {
                Person tmp = store.FindPerson(idPersonBox.Text);
                if (tmp == null)
                {
                    String Id, FirstName, LastName, Email;
                    Id = idPersonBox.Text;
                    FirstName = namePersonBox.Text;
                    LastName = lastNamePersonBox.Text;
                    Email = mailPersonBox.Text;

                    Person newPerson = new Person(Id, FirstName, LastName, Email);
                    store.AddPerson(newPerson);
                    dataGridPerson.Rows.Add(Id, FirstName, LastName, Email);
                    store.PersonWrite();
                }
                else { }


            }

        }

        private void addRentedMovieBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(movieIdRentedMovieBox.Text, out int result) || !int.TryParse(personIdRentedMovieBox.Text, out int result2))
            {
                return;
            }
            if (movieIdRentedMovieBox.Text != null && personIdRentedMovieBox.Text != null)
            {
                Person tmpPerson = store.FindPerson(personIdRentedMovieBox.Text);
                Movie tmpMoive = store.FindMovie(movieIdRentedMovieBox.Text);
                if (tmpMoive != null && tmpPerson != null)
                {
                    string Id, price;
                    Id = rand.Next(1000).ToString();
                    RentedMovie tmpRentedMovie = store.FindRental(Id);
                    while (tmpRentedMovie != null)
                    {
                        Id = rand.Next(1000000).ToString();
                        tmpRentedMovie = store.FindRental(Id);
                    }
                    DateTime rentalDate = DateTime.Now;
                    DateTime returnTime = datePickerRent.Value.Date;

                    string rentalD = rentalDate.ToString("dd.MM.yyyy");
                    string returnTimeD = returnTime.ToString("dd.MM.yyyy");

                    price = (((returnTime.Date - rentalDate.Date).Days)*5).ToString();

                    RentedMovie newRentedMovie = new RentedMovie(Id, tmpMoive, tmpPerson, rentalD, returnTimeD, price);
                    store.RentMovie(newRentedMovie);
                    dataGridMain.Rows.Add(Id, tmpMoive.Title, tmpPerson.FirstName, rentalD, returnTimeD, price);
                    store.RentalWrite();
                }
            }
        }

        private void rentPnlBtn_Click(object sender, EventArgs e)
        {
            mainBtnPnl.Visible = false;
            rentPnl.Visible = true;
        }

        private void personPnlPtn_Click(object sender, EventArgs e)
        {
            mainPnl.Visible = false;
            personAddPnl.Visible = true; ;
        }

        private void moviePnlBtn_Click(object sender, EventArgs e)
        {
            mainPnl.Visible = false;
            movieAddPnl.Visible = true;
        }

        private void backRentMovieBtn_Click(object sender, EventArgs e)
        {
            mainBtnPnl.Visible = true;
            rentPnl.Visible = false;
        }

        private void backAddMovieBtn_Click(object sender, EventArgs e)
        {
            mainPnl.Visible = true;
            movieAddPnl.Visible = false;
        }

        private void backaddPersonBtn_Click(object sender, EventArgs e)
        {
            mainPnl.Visible = true;
            personAddPnl.Visible = false; ;
        }

        private void deleteMovieBtn_Click(object sender, EventArgs e)
        {
            if (dataGridMovie.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridMovie.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridMovie.Rows.Remove(row);
                        store.RemoveMovie(row.Cells[0].Value.ToString());
                        store.refreshMovie();
                    }
                }
            }
        }

        private void deleteRentedMovieBtn_Click(object sender, EventArgs e)
        {
            if (dataGridMain.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridMain.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridMain.Rows.Remove(row);
                        store.RemoveRentedMovie(row.Cells[0].Value.ToString());
                        store.refreshRental();
                    }
                }
            }
        }

        private void deletePersonBtn_Click(object sender, EventArgs e)
        {
            if (dataGridPerson.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridPerson.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridPerson.Rows.Remove(row);
                        store.RemovePerson(row.Cells[0].Value.ToString());
                        store.refreshPerson();

                    }
                }
            }
        }
    }
}
