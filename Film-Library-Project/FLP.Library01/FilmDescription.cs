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
        public int Date { get; set; }

        public FilmDescription ()
        {
        }

        public FilmDescription(string name, int date)
        {
            Name = name;
            Date = date;
        }
    }
}
