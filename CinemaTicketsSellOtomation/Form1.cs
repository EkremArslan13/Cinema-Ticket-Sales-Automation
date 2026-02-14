using CinemaTicketSalesAutomation;
using CinemaTicketSalesAutomation.Helpers;
using CinemaTicketSalesAutomation.Modals;

namespace CinemaTicketsSellOtomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<movie> movies;

        DateTime currentDate = DateTime.Now;
        DateTime useDate;
        Form2 form2;



        private void Form1_Load(object sender, EventArgs e)
        {
            useDate = currentDate;
            lbldate.Text = useDate.ToShortDateString();
            movies = helper.CreateMovies();
            ListControls();
            form2 = new Form2(movies, this);
        }

        private void ListControls()
        {
            Size pictureSize = new Size(300, 180);
            Size buttonSize = new Size(90, 40);
            int x = 50;
            int y = 100;
            int xýncrement = 400;
            int yýncrement = 300;

            for (int i = 0; i < movies.Count; i++)
            {
                if (i >= 6) break;
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.Size = pictureSize;

                picture.Image = Image.FromFile(movies[i].picturePath);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(picture);
                int buttonx = x;
                int buttony = picture.Bottom + 10;

                for (int index = 0; index < 3; index++)
                {
                    Button button = new Button();
                    button.Text = movies[i].sessions[index].time;
                    button.Location = new Point(buttonx, buttony);
                    button.Size = buttonSize;
                    button.Tag = i;
                    button.Click += new EventHandler(button_Click);
                    this.Controls.Add(button);
                    buttonx += 100;

                }


                if (1200 > x + xýncrement + picture.Width)
                {
                    x += xýncrement;
                }
                else
                {
                    x = 50;
                    y += yýncrement;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int movieIndex = Convert.ToInt32(button.Tag);
            string sessionTime = button.Text;
            string sessionDate = lbldate.Text;
            if (DateTime.Parse($"{sessionDate} {sessionTime}") < DateTime.Now) 
            {
                MessageBox.Show("Seçilen seansý kaçýrdýnýz. Baþka seans seçebilirsiniz");
                return;
            }

            this.Hide();
            form2.Show();
            form2.listDetail(movieIndex, sessionTime, sessionDate);

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            useDate = useDate.AddDays(1);
            lbldate.Text = useDate.ToShortDateString();
            btnprevious.Enabled = true;
            if (currentDate.AddDays(2) == useDate)
            {
                btnnext.Enabled = false;
            }
        } 

        private void btnprevious_Click(object sender, EventArgs e)
        {
            useDate = useDate.AddDays(-1);
            lbldate.Text = useDate.ToShortDateString();
            btnnext.Enabled = true;

            if (currentDate == useDate) 
            {
             btnprevious.Enabled = false;
            }

        }
    }
}
