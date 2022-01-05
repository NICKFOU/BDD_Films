using BDD_Films.Model;
using BDD_Films.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BDD_Films.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Index : ContentPage
    {
        public Index()
        {
            InitializeComponent();
            BindingContext = new MoviesViewModel();
        }

        private async void ReservationFilm(object sender, EventArgs e)
        {
            string data = ((Button)sender).BindingContext as string;
            bool reservation = await DisplayAlert("Réservation", data, "Fermer", "Réserver");
            if(reservation == false) {
                bool confirmation = await DisplayAlert("Confirmation", "Voulez-vous vraiment réserver une place ?", "Annuler", "Confirmer");
                if(confirmation == false)
                {
                    DisplayAlert("", "Réservation enregistrée", "Fermer");
                }
            }
        }

        private async void InfosFilm(object sender, EventArgs e)
        {
            string data = ((Button)sender).BindingContext as string;
            DisplayAlert("Description", data, "Fermer");
        }
    }
}