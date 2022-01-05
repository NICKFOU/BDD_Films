using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDD_Films.Model;

namespace BDD_Films.ViewModel
{
    class MoviesViewModel
    {
        public static FirebaseClient firebase = new FirebaseClient("https://portail-de-services-default-rtdb.europe-west1.firebasedatabase.app/");

        public MoviesViewModel()
        {
            GetMovies();
        }

        private async void GetMovies()
        {
            Movies = new ObservableCollection<Movie>();

            var GetItems = (await firebase
              .Child("Film")
              .OnceAsync<Movie>()).Select(item => new Movie
              {
                  id_F = item.Object.id_F,
                  titre = item.Object.titre,
                  categorie = item.Object.categorie,
                  note = item.Object.note,
                  langage = item.Object.langage,
                  longueur = item.Object.longueur,
                  playing_date = item.Object.playing_date,
                  playing_time = item.Object.playing_time,
                  ticket_price = item.Object.ticket_price,
                  description = item.Object.description,
                  image = item.Object.image,
                  video = item.Object.video
              }).OrderBy(a => a.titre);

            foreach (var item in GetItems)
            {
                Movies.Add(item);
            }

        }

        private ObservableCollection<Movie> movies;
        public ObservableCollection<Movie> Movies
        {
            get { return movies; }
            set
            {
                movies = value;
            }
        }
    }
}
