namespace FilmAutomaiton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            movieAddPnl = new Panel();
            deleteMovieBtn = new Button();
            backAddMovieBtn = new Button();
            dataGridMovie = new DataGridView();
            idMovieGrid = new DataGridViewTextBoxColumn();
            nameMovieGrid = new DataGridViewTextBoxColumn();
            genreMovieGrid = new DataGridViewTextBoxColumn();
            yearMovieGrid = new DataGridViewTextBoxColumn();
            addMovieBtn = new Button();
            yearMovieBox = new TextBox();
            yearMovie = new Label();
            genreMovieBox = new TextBox();
            genreMovie = new Label();
            titleMovieBox = new TextBox();
            titleMovie = new Label();
            idMovieBox = new TextBox();
            idMovie = new Label();
            personAddPnl = new Panel();
            deletePersonBtn = new Button();
            backaddPersonBtn = new Button();
            dataGridPerson = new DataGridView();
            personIdPerson = new DataGridViewTextBoxColumn();
            namePersonPerson = new DataGridViewTextBoxColumn();
            lastNamePersonGrid = new DataGridViewTextBoxColumn();
            EmailPerson = new DataGridViewTextBoxColumn();
            addPersonBtn = new Button();
            mailPersonBox = new TextBox();
            mailPerson = new Label();
            lastNamePersonBox = new TextBox();
            lastNamePerson = new Label();
            namePersonBox = new TextBox();
            namePerson = new Label();
            idPersonBox = new TextBox();
            idPerson = new Label();
            rentPnl = new Panel();
            backRentMovieBtn = new Button();
            dateRentedMovie = new Label();
            datePickerRent = new DateTimePicker();
            addRentedMovieBtn = new Button();
            personIdRentedMovieBox = new TextBox();
            personIdRentedMovie = new Label();
            movieIdRentedMovieBox = new TextBox();
            movieIdRentedMovie = new Label();
            dataGridMain = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            movieName = new DataGridViewTextBoxColumn();
            personId = new DataGridViewTextBoxColumn();
            rentalDate = new DataGridViewTextBoxColumn();
            returnDate = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            mainPnl = new Panel();
            deleteRentedMovieBtn = new Button();
            mainBtnPnl = new Panel();
            rentPnlBtn = new Button();
            moviePnlBtn = new Button();
            personPnlPtn = new Button();
            movieAddPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMovie).BeginInit();
            personAddPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPerson).BeginInit();
            rentPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMain).BeginInit();
            mainPnl.SuspendLayout();
            mainBtnPnl.SuspendLayout();
            SuspendLayout();
            // 
            // movieAddPnl
            // 
            movieAddPnl.Controls.Add(deleteMovieBtn);
            movieAddPnl.Controls.Add(backAddMovieBtn);
            movieAddPnl.Controls.Add(dataGridMovie);
            movieAddPnl.Controls.Add(addMovieBtn);
            movieAddPnl.Controls.Add(yearMovieBox);
            movieAddPnl.Controls.Add(yearMovie);
            movieAddPnl.Controls.Add(genreMovieBox);
            movieAddPnl.Controls.Add(genreMovie);
            movieAddPnl.Controls.Add(titleMovieBox);
            movieAddPnl.Controls.Add(titleMovie);
            movieAddPnl.Controls.Add(idMovieBox);
            movieAddPnl.Controls.Add(idMovie);
            movieAddPnl.Location = new Point(851, 539);
            movieAddPnl.Name = "movieAddPnl";
            movieAddPnl.Size = new Size(1206, 511);
            movieAddPnl.TabIndex = 0;
            // 
            // deleteMovieBtn
            // 
            deleteMovieBtn.Location = new Point(770, 432);
            deleteMovieBtn.Name = "deleteMovieBtn";
            deleteMovieBtn.Size = new Size(94, 29);
            deleteMovieBtn.TabIndex = 10;
            deleteMovieBtn.Text = "Delete";
            deleteMovieBtn.UseVisualStyleBackColor = true;
            deleteMovieBtn.Click += deleteMovieBtn_Click;
            // 
            // backAddMovieBtn
            // 
            backAddMovieBtn.Location = new Point(349, 352);
            backAddMovieBtn.Name = "backAddMovieBtn";
            backAddMovieBtn.Size = new Size(94, 29);
            backAddMovieBtn.TabIndex = 9;
            backAddMovieBtn.Text = "BACK";
            backAddMovieBtn.UseVisualStyleBackColor = true;
            backAddMovieBtn.Click += backAddMovieBtn_Click;
            // 
            // dataGridMovie
            // 
            dataGridMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMovie.Columns.AddRange(new DataGridViewColumn[] { idMovieGrid, nameMovieGrid, genreMovieGrid, yearMovieGrid });
            dataGridMovie.Location = new Point(492, 66);
            dataGridMovie.Name = "dataGridMovie";
            dataGridMovie.RowHeadersWidth = 51;
            dataGridMovie.Size = new Size(565, 308);
            dataGridMovie.TabIndex = 8;
            // 
            // idMovieGrid
            // 
            idMovieGrid.HeaderText = "ID";
            idMovieGrid.MinimumWidth = 6;
            idMovieGrid.Name = "idMovieGrid";
            idMovieGrid.Width = 125;
            // 
            // nameMovieGrid
            // 
            nameMovieGrid.HeaderText = "Name";
            nameMovieGrid.MinimumWidth = 6;
            nameMovieGrid.Name = "nameMovieGrid";
            nameMovieGrid.Width = 125;
            // 
            // genreMovieGrid
            // 
            genreMovieGrid.HeaderText = "Genre";
            genreMovieGrid.MinimumWidth = 6;
            genreMovieGrid.Name = "genreMovieGrid";
            genreMovieGrid.Width = 125;
            // 
            // yearMovieGrid
            // 
            yearMovieGrid.HeaderText = "Year";
            yearMovieGrid.MinimumWidth = 6;
            yearMovieGrid.Name = "yearMovieGrid";
            yearMovieGrid.Width = 125;
            // 
            // addMovieBtn
            // 
            addMovieBtn.Location = new Point(191, 305);
            addMovieBtn.Name = "addMovieBtn";
            addMovieBtn.Size = new Size(94, 29);
            addMovieBtn.TabIndex = 1;
            addMovieBtn.Text = "EKLE";
            addMovieBtn.UseVisualStyleBackColor = true;
            addMovieBtn.Click += addMovieBtn_Click;
            // 
            // yearMovieBox
            // 
            yearMovieBox.Location = new Point(139, 260);
            yearMovieBox.Name = "yearMovieBox";
            yearMovieBox.Size = new Size(213, 27);
            yearMovieBox.TabIndex = 7;
            // 
            // yearMovie
            // 
            yearMovie.AutoSize = true;
            yearMovie.Location = new Point(70, 263);
            yearMovie.Name = "yearMovie";
            yearMovie.Size = new Size(37, 20);
            yearMovie.TabIndex = 6;
            yearMovie.Text = "Year";
            // 
            // genreMovieBox
            // 
            genreMovieBox.Location = new Point(139, 225);
            genreMovieBox.Name = "genreMovieBox";
            genreMovieBox.Size = new Size(213, 27);
            genreMovieBox.TabIndex = 5;
            // 
            // genreMovie
            // 
            genreMovie.AutoSize = true;
            genreMovie.Location = new Point(70, 228);
            genreMovie.Name = "genreMovie";
            genreMovie.Size = new Size(48, 20);
            genreMovie.TabIndex = 4;
            genreMovie.Text = "Genre";
            // 
            // titleMovieBox
            // 
            titleMovieBox.Location = new Point(139, 188);
            titleMovieBox.Name = "titleMovieBox";
            titleMovieBox.Size = new Size(213, 27);
            titleMovieBox.TabIndex = 3;
            // 
            // titleMovie
            // 
            titleMovie.AutoSize = true;
            titleMovie.Location = new Point(70, 191);
            titleMovie.Name = "titleMovie";
            titleMovie.Size = new Size(38, 20);
            titleMovie.TabIndex = 2;
            titleMovie.Text = "Title";
            // 
            // idMovieBox
            // 
            idMovieBox.Location = new Point(139, 152);
            idMovieBox.Name = "idMovieBox";
            idMovieBox.Size = new Size(213, 27);
            idMovieBox.TabIndex = 1;
            // 
            // idMovie
            // 
            idMovie.AutoSize = true;
            idMovie.Location = new Point(70, 155);
            idMovie.Name = "idMovie";
            idMovie.Size = new Size(24, 20);
            idMovie.TabIndex = 0;
            idMovie.Text = "ID";
            // 
            // personAddPnl
            // 
            personAddPnl.Controls.Add(deletePersonBtn);
            personAddPnl.Controls.Add(backaddPersonBtn);
            personAddPnl.Controls.Add(dataGridPerson);
            personAddPnl.Controls.Add(addPersonBtn);
            personAddPnl.Controls.Add(mailPersonBox);
            personAddPnl.Controls.Add(mailPerson);
            personAddPnl.Controls.Add(lastNamePersonBox);
            personAddPnl.Controls.Add(lastNamePerson);
            personAddPnl.Controls.Add(namePersonBox);
            personAddPnl.Controls.Add(namePerson);
            personAddPnl.Controls.Add(idPersonBox);
            personAddPnl.Controls.Add(idPerson);
            personAddPnl.Location = new Point(256, 516);
            personAddPnl.Name = "personAddPnl";
            personAddPnl.Size = new Size(1206, 511);
            personAddPnl.TabIndex = 1;
            // 
            // deletePersonBtn
            // 
            deletePersonBtn.Location = new Point(837, 432);
            deletePersonBtn.Name = "deletePersonBtn";
            deletePersonBtn.Size = new Size(94, 29);
            deletePersonBtn.TabIndex = 11;
            deletePersonBtn.Text = "Delete";
            deletePersonBtn.UseVisualStyleBackColor = true;
            deletePersonBtn.Click += deletePersonBtn_Click;
            // 
            // backaddPersonBtn
            // 
            backaddPersonBtn.Location = new Point(349, 352);
            backaddPersonBtn.Name = "backaddPersonBtn";
            backaddPersonBtn.Size = new Size(94, 29);
            backaddPersonBtn.TabIndex = 10;
            backaddPersonBtn.Text = "BACK";
            backaddPersonBtn.UseVisualStyleBackColor = true;
            backaddPersonBtn.Click += backaddPersonBtn_Click;
            // 
            // dataGridPerson
            // 
            dataGridPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPerson.Columns.AddRange(new DataGridViewColumn[] { personIdPerson, namePersonPerson, lastNamePersonGrid, EmailPerson });
            dataGridPerson.Location = new Point(512, 78);
            dataGridPerson.Name = "dataGridPerson";
            dataGridPerson.RowHeadersWidth = 51;
            dataGridPerson.Size = new Size(554, 315);
            dataGridPerson.TabIndex = 9;
            // 
            // personIdPerson
            // 
            personIdPerson.HeaderText = "ID";
            personIdPerson.MinimumWidth = 6;
            personIdPerson.Name = "personIdPerson";
            personIdPerson.Width = 125;
            // 
            // namePersonPerson
            // 
            namePersonPerson.HeaderText = "FirstName";
            namePersonPerson.MinimumWidth = 6;
            namePersonPerson.Name = "namePersonPerson";
            namePersonPerson.Width = 125;
            // 
            // lastNamePersonGrid
            // 
            lastNamePersonGrid.HeaderText = "LastName";
            lastNamePersonGrid.MinimumWidth = 6;
            lastNamePersonGrid.Name = "lastNamePersonGrid";
            lastNamePersonGrid.Width = 125;
            // 
            // EmailPerson
            // 
            EmailPerson.HeaderText = "E-mail";
            EmailPerson.MinimumWidth = 6;
            EmailPerson.Name = "EmailPerson";
            EmailPerson.Width = 125;
            // 
            // addPersonBtn
            // 
            addPersonBtn.Location = new Point(191, 319);
            addPersonBtn.Name = "addPersonBtn";
            addPersonBtn.Size = new Size(94, 29);
            addPersonBtn.TabIndex = 8;
            addPersonBtn.Text = "EKLE";
            addPersonBtn.UseVisualStyleBackColor = true;
            addPersonBtn.Click += addPersonBtn_Click;
            // 
            // mailPersonBox
            // 
            mailPersonBox.Location = new Point(134, 274);
            mailPersonBox.Name = "mailPersonBox";
            mailPersonBox.Size = new Size(213, 27);
            mailPersonBox.TabIndex = 7;
            // 
            // mailPerson
            // 
            mailPerson.AutoSize = true;
            mailPerson.Location = new Point(65, 277);
            mailPerson.Name = "mailPerson";
            mailPerson.Size = new Size(52, 20);
            mailPerson.TabIndex = 6;
            mailPerson.Text = "E-mail";
            // 
            // lastNamePersonBox
            // 
            lastNamePersonBox.Location = new Point(134, 239);
            lastNamePersonBox.Name = "lastNamePersonBox";
            lastNamePersonBox.Size = new Size(213, 27);
            lastNamePersonBox.TabIndex = 5;
            // 
            // lastNamePerson
            // 
            lastNamePerson.AutoSize = true;
            lastNamePerson.Location = new Point(65, 242);
            lastNamePerson.Name = "lastNamePerson";
            lastNamePerson.Size = new Size(72, 20);
            lastNamePerson.TabIndex = 4;
            lastNamePerson.Text = "Lastname";
            // 
            // namePersonBox
            // 
            namePersonBox.Location = new Point(134, 202);
            namePersonBox.Name = "namePersonBox";
            namePersonBox.Size = new Size(213, 27);
            namePersonBox.TabIndex = 3;
            // 
            // namePerson
            // 
            namePerson.AutoSize = true;
            namePerson.Location = new Point(65, 205);
            namePerson.Name = "namePerson";
            namePerson.Size = new Size(49, 20);
            namePerson.TabIndex = 2;
            namePerson.Text = "Name";
            // 
            // idPersonBox
            // 
            idPersonBox.Location = new Point(134, 166);
            idPersonBox.Name = "idPersonBox";
            idPersonBox.Size = new Size(213, 27);
            idPersonBox.TabIndex = 1;
            // 
            // idPerson
            // 
            idPerson.AutoSize = true;
            idPerson.Location = new Point(65, 169);
            idPerson.Name = "idPerson";
            idPerson.Size = new Size(24, 20);
            idPerson.TabIndex = 0;
            idPerson.Text = "ID";
            // 
            // rentPnl
            // 
            rentPnl.Controls.Add(backRentMovieBtn);
            rentPnl.Controls.Add(dateRentedMovie);
            rentPnl.Controls.Add(datePickerRent);
            rentPnl.Controls.Add(addRentedMovieBtn);
            rentPnl.Controls.Add(personIdRentedMovieBox);
            rentPnl.Controls.Add(personIdRentedMovie);
            rentPnl.Controls.Add(movieIdRentedMovieBox);
            rentPnl.Controls.Add(movieIdRentedMovie);
            rentPnl.Location = new Point(44, 122);
            rentPnl.Name = "rentPnl";
            rentPnl.Size = new Size(419, 244);
            rentPnl.TabIndex = 2;
            // 
            // backRentMovieBtn
            // 
            backRentMovieBtn.Location = new Point(322, 212);
            backRentMovieBtn.Name = "backRentMovieBtn";
            backRentMovieBtn.Size = new Size(94, 29);
            backRentMovieBtn.TabIndex = 8;
            backRentMovieBtn.Text = "BACK";
            backRentMovieBtn.UseVisualStyleBackColor = true;
            backRentMovieBtn.Click += backRentMovieBtn_Click;
            // 
            // dateRentedMovie
            // 
            dateRentedMovie.AutoSize = true;
            dateRentedMovie.Location = new Point(39, 110);
            dateRentedMovie.Name = "dateRentedMovie";
            dateRentedMovie.Size = new Size(41, 20);
            dateRentedMovie.TabIndex = 7;
            dateRentedMovie.Text = "Date";
            // 
            // datePickerRent
            // 
            datePickerRent.Location = new Point(105, 103);
            datePickerRent.Name = "datePickerRent";
            datePickerRent.Size = new Size(213, 27);
            datePickerRent.TabIndex = 6;
            // 
            // addRentedMovieBtn
            // 
            addRentedMovieBtn.Location = new Point(151, 180);
            addRentedMovieBtn.Name = "addRentedMovieBtn";
            addRentedMovieBtn.Size = new Size(94, 29);
            addRentedMovieBtn.TabIndex = 1;
            addRentedMovieBtn.Text = "EKLE";
            addRentedMovieBtn.UseVisualStyleBackColor = true;
            addRentedMovieBtn.Click += addRentedMovieBtn_Click;
            // 
            // personIdRentedMovieBox
            // 
            personIdRentedMovieBox.Location = new Point(105, 30);
            personIdRentedMovieBox.Name = "personIdRentedMovieBox";
            personIdRentedMovieBox.Size = new Size(213, 27);
            personIdRentedMovieBox.TabIndex = 3;
            // 
            // personIdRentedMovie
            // 
            personIdRentedMovie.AutoSize = true;
            personIdRentedMovie.Location = new Point(30, 30);
            personIdRentedMovie.Name = "personIdRentedMovie";
            personIdRentedMovie.Size = new Size(68, 20);
            personIdRentedMovie.TabIndex = 2;
            personIdRentedMovie.Text = "Name ID";
            // 
            // movieIdRentedMovieBox
            // 
            movieIdRentedMovieBox.Location = new Point(105, 66);
            movieIdRentedMovieBox.Name = "movieIdRentedMovieBox";
            movieIdRentedMovieBox.Size = new Size(213, 27);
            movieIdRentedMovieBox.TabIndex = 1;
            // 
            // movieIdRentedMovie
            // 
            movieIdRentedMovie.AutoSize = true;
            movieIdRentedMovie.Location = new Point(30, 66);
            movieIdRentedMovie.Name = "movieIdRentedMovie";
            movieIdRentedMovie.Size = new Size(65, 20);
            movieIdRentedMovie.TabIndex = 0;
            movieIdRentedMovie.Text = "MovieID";
            // 
            // dataGridMain
            // 
            dataGridMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMain.Columns.AddRange(new DataGridViewColumn[] { id, movieName, personId, rentalDate, returnDate, price });
            dataGridMain.Location = new Point(469, 62);
            dataGridMain.Name = "dataGridMain";
            dataGridMain.RowHeadersWidth = 51;
            dataGridMain.Size = new Size(803, 354);
            dataGridMain.TabIndex = 3;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // movieName
            // 
            movieName.HeaderText = "Movie";
            movieName.MinimumWidth = 6;
            movieName.Name = "movieName";
            movieName.Width = 125;
            // 
            // personId
            // 
            personId.HeaderText = "Person";
            personId.MinimumWidth = 6;
            personId.Name = "personId";
            personId.Width = 125;
            // 
            // rentalDate
            // 
            rentalDate.HeaderText = "Rent Date";
            rentalDate.MinimumWidth = 6;
            rentalDate.Name = "rentalDate";
            rentalDate.Width = 125;
            // 
            // returnDate
            // 
            returnDate.HeaderText = "Return Date";
            returnDate.MinimumWidth = 6;
            returnDate.Name = "returnDate";
            returnDate.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 125;
            // 
            // mainPnl
            // 
            mainPnl.Controls.Add(deleteRentedMovieBtn);
            mainPnl.Controls.Add(mainBtnPnl);
            mainPnl.Controls.Add(dataGridMain);
            mainPnl.Controls.Add(rentPnl);
            mainPnl.Location = new Point(2, 1);
            mainPnl.Name = "mainPnl";
            mainPnl.Size = new Size(1292, 509);
            mainPnl.TabIndex = 4;
            // 
            // deleteRentedMovieBtn
            // 
            deleteRentedMovieBtn.Location = new Point(837, 432);
            deleteRentedMovieBtn.Name = "deleteRentedMovieBtn";
            deleteRentedMovieBtn.Size = new Size(94, 29);
            deleteRentedMovieBtn.TabIndex = 8;
            deleteRentedMovieBtn.Text = "Delete";
            deleteRentedMovieBtn.UseVisualStyleBackColor = true;
            deleteRentedMovieBtn.Click += deleteRentedMovieBtn_Click;
            // 
            // mainBtnPnl
            // 
            mainBtnPnl.Controls.Add(rentPnlBtn);
            mainBtnPnl.Controls.Add(moviePnlBtn);
            mainBtnPnl.Controls.Add(personPnlPtn);
            mainBtnPnl.Location = new Point(141, 122);
            mainBtnPnl.Name = "mainBtnPnl";
            mainBtnPnl.Size = new Size(209, 248);
            mainBtnPnl.TabIndex = 7;
            // 
            // rentPnlBtn
            // 
            rentPnlBtn.Location = new Point(27, 29);
            rentPnlBtn.Name = "rentPnlBtn";
            rentPnlBtn.Size = new Size(143, 41);
            rentPnlBtn.TabIndex = 4;
            rentPnlBtn.Text = "New Rent";
            rentPnlBtn.UseVisualStyleBackColor = true;
            rentPnlBtn.Click += rentPnlBtn_Click;
            // 
            // moviePnlBtn
            // 
            moviePnlBtn.Location = new Point(27, 166);
            moviePnlBtn.Name = "moviePnlBtn";
            moviePnlBtn.Size = new Size(143, 41);
            moviePnlBtn.TabIndex = 6;
            moviePnlBtn.Text = "New Movie";
            moviePnlBtn.UseVisualStyleBackColor = true;
            moviePnlBtn.Click += moviePnlBtn_Click;
            // 
            // personPnlPtn
            // 
            personPnlPtn.Location = new Point(27, 98);
            personPnlPtn.Name = "personPnlPtn";
            personPnlPtn.Size = new Size(143, 41);
            personPnlPtn.TabIndex = 5;
            personPnlPtn.Text = "New Member";
            personPnlPtn.UseVisualStyleBackColor = true;
            personPnlPtn.Click += personPnlPtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 519);
            Controls.Add(mainPnl);
            Controls.Add(movieAddPnl);
            Controls.Add(personAddPnl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            movieAddPnl.ResumeLayout(false);
            movieAddPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMovie).EndInit();
            personAddPnl.ResumeLayout(false);
            personAddPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPerson).EndInit();
            rentPnl.ResumeLayout(false);
            rentPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMain).EndInit();
            mainPnl.ResumeLayout(false);
            mainBtnPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel movieAddPnl;
        private TextBox yearMovieBox;
        private Label yearMovie;
        private TextBox genreMovieBox;
        private Label genreMovie;
        private TextBox titleMovieBox;
        private Label titleMovie;
        private TextBox idMovieBox;
        private Label idMovie;
        private Button addMovieBtn;
        private Panel personAddPnl;
        private TextBox mailPersonBox;
        private Label mailPerson;
        private TextBox lastNamePersonBox;
        private Label lastNamePerson;
        private TextBox namePersonBox;
        private Label namePerson;
        private TextBox idPersonBox;
        private Label idPerson;
        private Panel rentPnl;
        private Button addRentedMovieBtn;
        private TextBox personIdRentedMovieBox;
        private Label personIdRentedMovie;
        private TextBox movieIdRentedMovieBox;
        private Label movieIdRentedMovie;
        private Button addPersonBtn;
        private Label dateRentedMovie;
        private DateTimePicker datePickerRent;
        private DataGridView dataGridMain;
        private Panel mainPnl;
        private Button moviePnlBtn;
        private Button personPnlPtn;
        private Button rentPnlBtn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn movieName;
        private DataGridViewTextBoxColumn personId;
        private DataGridViewTextBoxColumn rentalDate;
        private DataGridViewTextBoxColumn returnDate;
        private DataGridView dataGridPerson;
        private DataGridViewTextBoxColumn personIdPerson;
        private DataGridViewTextBoxColumn namePersonPerson;
        private DataGridViewTextBoxColumn lastNamePersonGrid;
        private DataGridViewTextBoxColumn EmailPerson;
        private DataGridView dataGridMovie;
        private DataGridViewTextBoxColumn idMovieGrid;
        private DataGridViewTextBoxColumn nameMovieGrid;
        private DataGridViewTextBoxColumn genreMovieGrid;
        private DataGridViewTextBoxColumn yearMovieGrid;
        private Panel mainBtnPnl;
        private Button backRentMovieBtn;
        private Button backAddMovieBtn;
        private Button backaddPersonBtn;
        private DataGridViewTextBoxColumn price;
        private Button deleteRentedMovieBtn;
        private Button deleteMovieBtn;
        private Button deletePersonBtn;
    }
}
