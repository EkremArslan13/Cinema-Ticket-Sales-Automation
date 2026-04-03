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
            // Programın (.exe) çalıştığı klasörün içindeki Pictures klasörünü bulur.
            // Bu sayede bilgisayarın neresinde olursa olsun resimleri bulabilir.
            string basePath = Path.Combine(Application.StartupPath, "Pictures");

            return new List<movie>()
    {
        new movie()
        {
            movieName = "Yıldızlararası",
            category = Category.bilim_kurgu,
            Minute = "2 saat 49 dakika",
            Price = 50,
            picturePath = Path.Combine(basePath, "yıldızlararası.jpg")
        },
        new movie()
        {
            movieName = "Nefesini Tut",
            category = Category.gerilim,
            Minute = "1saat 28dakika",
            Price = 40,
            picturePath = Path.Combine(basePath, "nefes.jpg")
        },
        new movie()
        {
            movieName = "3 aptal",
            category = Category.komedi,
            Minute = "2 saat 51 dakika",
            Price = 60,
            picturePath = Path.Combine(basePath, "3 aptal.jpg")
        },
        new movie()
        {
            movieName = "Geleceğe Dönüş",
            category = Category.macera,
            Minute = "1 saat 56 dakika",
            Price = 50,
            picturePath = Path.Combine(basePath, "gelecek.jpg")
        },
        new movie()
        {
            movieName = "Jumanji",
            category = Category.macera,
            Minute = "1 saat 44 dakika",
            Price = 50,
            picturePath = Path.Combine(basePath, "jumanji.jpg")
        },
        new movie()
        {
            movieName = "Warcraft",
            category = Category.fantastik,
            Minute = "2 saat 3 dakika",
            Price = 40,
            picturePath = Path.Combine(basePath, "warcraft.jpg")
        }
    };
        }



    }



}

