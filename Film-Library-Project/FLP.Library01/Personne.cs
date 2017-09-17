using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLP.Library01;

namespace FLP.Library01
{
    public class Personne
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<FilmDescription> FilmSeen { get; set; }
        public List<FilmDescription> FilmToSee { get; set; }
        public List<FilmDescription> FilmBlackListed { get; set; }

        public Personne ()
        {
        }

        public Personne(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Personne(string name = null, int age = 0, List<FilmDescription> seen = null, List<FilmDescription> tosee = null, List<FilmDescription> blacklisted = null)
        {
            Name = name;
            Age = age;
            FilmSeen = seen;
            FilmToSee = tosee;
            FilmBlackListed = blacklisted;
        }
    }
}
