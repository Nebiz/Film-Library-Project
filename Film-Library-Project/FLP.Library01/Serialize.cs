using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLP.Library01;

namespace FLP.Library01
{
    public static class Serialize
    {
        public static void SerializeLibrary()
        {/*
            Personne grpRacine = ListeCles();

            XmlSerializer xmlSerialisateur = new XmlSerializer(grpRacine.GetType());

            using (FileStream fs = new FileStream(nomFichier, FileMode.Create))
            {
                xmlSerialisateur.Serialize(fs, grpRacine);
            }
        */}

        public static Personne DeSerializeLibrary(Personne pers)
        {/*
            using (FileStream fs = new FileStream(nomFichier, FileMode.Open))
            {
                var Serialiseur = new XmlSerializer(typeof(Regroupement));
                return Serialiseur.Deserialize(fs) as Regroupement;
            }*/
            return pers;
        }
        
    }
}
