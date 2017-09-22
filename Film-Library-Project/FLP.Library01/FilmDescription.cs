using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLP.Library01;

namespace FLP.Library01
{
    public class FilmDescription
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ImgPath { get; set; }
        public List<Actor> ListActor { get; set; }
        public string Realisateur { get; set; }

        public FilmDescription ()
        {
        }

        // A supprimer / garder seulement pour le test deja cree
        public FilmDescription(string name, DateTime releaseDate)
        {
            Name = name;
            ReleaseDate = releaseDate;
        }

        public FilmDescription(string name, DateTime releasedate, string imgPath, List<Actor> listActor, string realisteur)
        {
            Name = name;
            ReleaseDate = releasedate;
            ImgPath = imgPath;
            ListActor = listActor;
            Realisateur = realisteur;
        }
    }
}
