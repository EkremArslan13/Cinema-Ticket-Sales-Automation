using CinemaTicketSalesAutomation.Enum;
using CinemaTicketSalesAutomation.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Helpers
{
    public class helper
    {
        public static List<movie> CreateMovies() 
        {
            string basePath = "C://Users//msı//Desktop//Sinema Otomasyonu Project1//CinemaTicketsSellOtomation//CinemaTicketsSellOtomation//Pictures//";

            return new List<movie>()
            {
                new movie()
                {
                    movieName = "Yıldızlarası",
                    category = Category.bilim_kurgu,
                    Minute = "2 saat 49 dakika",
                    Price = 50,
                    picturePath = basePath + "yıldızlararası.jpg"

                },
                new movie()
                {
                    movieName = "Nefesini Tut",
                    category = Category.gerilim,
                    Minute = "1saat 28dakika",
                    Price = 40,
                    picturePath = basePath + "nefes.jpg"

                },
                new movie()
                {
                    movieName = "3 aptal",
                    category = Category.komedi,
                    Minute = "2 saat 51 dakika",
                    Price = 60,
                    picturePath = basePath + "3 aptal.jpg"

                },
                new movie()
                {
                    movieName = "Geleceğe Dönüş",
                    category = Category.macera,
                    Minute = "1 saat 56 dakika",
                    Price = 50,
                    picturePath = basePath + "gelecek.jpg"

                },
                new movie()
                {
                    movieName = "Jumanji",
                    category = Category.macera,
                    Minute = "1 saat 44 dakika",
                    Price = 50,
                    picturePath = basePath + "jumanji.jpg"

                },
                new movie()
                {
                    movieName = "Warcraft",
                    category = Category.fantastik,
                    Minute = "2 saat 3 dakika",
                    Price = 40,
                    picturePath = basePath + "warcraft.jpg"

                },
            };

        
        
        
        }



    }
}
