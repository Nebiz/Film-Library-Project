using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLP.Library01;
using System.Xml.Serialization;

namespace FLP.Library01
{
    public static class Serialize
    {
        public static string CurrentUserData { get
            {
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string flpFolder = Path.Combine(appDataFolder, "Film Library Project");
                string filePath = Path.Combine(flpFolder, "CurrentUserData.xml");

                if (!Directory.Exists(flpFolder))
                {
                    Directory.CreateDirectory(flpFolder);
                }

                return filePath;
            }
        }

        public static void SerializeLibrary(Personne pers)
        {
            XmlSerializer xmlSerialisateur = new XmlSerializer(pers.GetType());

            using (FileStream fs = new FileStream(Path.Combine(CurrentUserData), FileMode.Create))
            {
                xmlSerialisateur.Serialize(fs, pers);
            }
        }

        public static Personne DeSerializeLibrary()
        {
            if (!File.Exists(CurrentUserData))
            {
                return new Personne("Invité", 0);
            }

            using (FileStream fs = new FileStream(CurrentUserData, FileMode.Open))
            {
                var Serialiseur = new XmlSerializer(typeof(Personne));
                return Serialiseur.Deserialize(fs) as Personne;
            }
        }
        
    }
}
