using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FLP.Library01;
using System.Collections.Generic;

namespace FLP.UnitTest01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestClassPersonne()
        {
            List<FilmDescription> ListofMovie1 = new List<FilmDescription>();
            List<FilmDescription> ListofMovie2 = new List<FilmDescription>();

            FilmDescription film1 = new FilmDescription();
            FilmDescription film2 = new FilmDescription("Alien vs Predator", 2001);
            FilmDescription film3 = new FilmDescription("Alien vs Predator 2", 2007);

            ListofMovie2.Add(film1);
            ListofMovie2.Add(film2);
            ListofMovie2.Add(film3);

            Personne pers = new Personne();
            Personne pers2 = new Personne("Ben", 21);
            Personne pers3 = new Personne("Ben", 21, ListofMovie1, ListofMovie2, ListofMovie1);
        }
    }
}
