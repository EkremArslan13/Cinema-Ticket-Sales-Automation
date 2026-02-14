using CinemaTicketSalesAutomation.Modals;
using CinemaTicketsSellOtomation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketSalesAutomation
{
    public partial class Form2 : Form
    {
        public Form2(List<movie> _movies, Form1 _form1)
        {
            InitializeComponent();
            movies = _movies;
            form1 = _form1;
        }

        List<movie> movies;
        Form1 form1;
        movie selectedMovie;
        session selectedSession;


        public void listDetail(int _movieIndex, string _time, string _date)
        {
            selectedMovie = movies[_movieIndex];
            selectedSession = selectedMovie.sessions.Find(session => session.date == _date && session.time == _time);
            lbltime.Text = $"{_date} - {_time} ";
            lblminute.Text = selectedMovie.Minute;
            lblprice.Text = selectedMovie.Price.ToString() + "Tl";
            pbselectedpicture.Image = Image.FromFile(selectedMovie.picturePath);
            lblcategory.Text = selectedMovie.category.ToString();
            CheckChairStatus();

        }
        private void CheckChairStatus()
        {
            foreach (Control item in grbchairs.Controls)
            {
                if (item is Button)
                {

                    string row = item.Tag.ToString();
                    string number = item.Text;
                    item.Enabled = true;
                    foreach (chair chair in selectedSession.chairs)
                    {
                        if (chair.row == row && chair.number == number)
                        {
                            if (chair.status)
                            {
                                item.BackColor = Color.DarkRed;
                                item.Enabled = false;
                            }
                            else
                            {
                                item.BackColor = Color.LightGreen;
                            }
                            break;
                        }
                    }
                }

            }

        }
        List<chair> chairs = new List<chair>();

        private void button24_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;
            string row = button.Tag.ToString();
            string number = button.Text;

            chair chair = selectedSession.chairs.Find(c => c.row == row && c.number == number);
            if (button.BackColor.Name != "Blue")
            {
                chairs.Add(chair);
                button.BackColor = Color.Blue;
            }
            else
            {
                chairs.Remove(chair);
                button.BackColor = Color.LightGreen;

            }



        }



        private void Salon_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            if (chairs.Count == 0)
            {
                MessageBox.Show("Lütfen en az 1 koltuk seçiniz");
                return;
            }
            sales sales = new sales();
            sales.movieName = selectedMovie.movieName;
            sales.count = chairs.Count;
            sales.sessionTime = $"{selectedSession.date} - {selectedSession.time}";
            sales.totalPrice = CalculatePrice();

            foreach (chair chair in chairs) 
            {
             chair.status = true;
             
            }

            MessageBox.Show(sales.ToString());


            changePage();


        }

        private void changePage()
        {
            rbsmall.Checked = rbmedium.Checked = rblarge.Checked = false;
            chairs.Clear();
            this.Hide();
            form1.Show();


        }

        private decimal CalculatePrice()
        {
            decimal price = selectedMovie.Price * chairs.Count;
            if (rbsmall.Checked)
            {
                price += 3;

            }
            else if (rbmedium.Checked)
            {
                price += 6;
            }
            else if (rblarge.Checked)
            {
                price += 9;
            }
            return price;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            changePage();
        }
    }
}
