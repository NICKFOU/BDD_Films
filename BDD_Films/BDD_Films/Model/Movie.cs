using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_Films.Model
{
    class Movie
    {
        public int id_F { get; set; }
        public string categorie { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string langage { get; set; }
        public string longueur { get; set; }
        public float note { get; set; }
        public string playing_date { get; set; }
        public string playing_time { get; set; }
        public string ticket_price { get; set; }
        public string titre { get; set; }
        public string video { get; set; }
        public string seance => $"Réserver une place pour la séance du {playing_date} à {playing_time} ?";
    }
}
