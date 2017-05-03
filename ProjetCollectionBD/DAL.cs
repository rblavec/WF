using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetCollectionBD
{
    class DAL
    {

        // Récupérer les titres des albums qui sont sortis dans les années 60
        public static void Album1960()
        {
            // On charge le fichier Xml en mémoire. Pour cela, on utilise XDocument.load.
            XDocument doc60 = XDocument.Load(@"D:\Exercices\XML\CollectionsBD.xml");

            // On souhaite obtenir tout les titres des albums sortis dans les années 60.
            // Pour cela on cherche le descendant Album puis on regarde les Albums dont la valeur de l'année est 1960. 
            var titres = doc60.Descendants("Album").Where (a => a.Attribute("Année").Value == "1960").Select(c=>c.Attribute("Titre").Value).ToList();
            // Autre méthode
            // var titres = doc60.Descendants("Album").Where(a => a.Attribute("Année").Value.StartsWith("1960")).Select(c => c.Attribute("Titre").Value).ToList();
            doc60.Save(@"D:\Exercices\XML\CollectionsBD.xml");
        }


        // Ajouter l'auteur Pascal Dabère dans la liste des auteurs de Lucky Luke
        public static void AjoutAuteurPascal()
        {

            // On charge le fichier Xml en mémoire. Pour cela, on utilise XDocument.load.
            XDocument docLucky = XDocument.Load(@"D:\Exercices\XML\CollectionsBD.xml");

            // On souhaite premièrement obtenir tout les Albumes de Lucky Luke.
            var titreLuckyLuke = docLucky.Descendants("CollectionBD").Where(b => b.Attribute("Nom").Value == "Lucky Luke").FirstOrDefault();

            // Désormais, on souhaite rajouter un Auteur à cette Bande Dessiné.
            // Il faut donc modifier ses Auteurs.                     
            titreLuckyLuke.Elements("Auteurs").FirstOrDefault().Add(new XElement("Auteur", "Pascal Dabère"));
             
            // Puis on sauvegarde la modification effectuée.
            docLucky.Save(@"D:\Exercices\XML\CollectionsBD.xml");

        }

        // Ajouter l'album suivant dans la collection des Lucky Luke : "Le pont sur le Mississippi", écrit par Morris et sorti en 1994
        public static void AjoutPontMississippi()
        {
            // On charge le fichier Xml en mémoire. Pour cela, on utilise XDocument.load.
            XDocument docMissi = XDocument.Load(@"D:\Exercices\XML\CollectionsBD.xml");

            // On souhaite premièrement obtenir tout les Albums de Lucky Luke.
            var titreLuckyLuke = docMissi.Descendants("CollectionBD").Where(b => b.Attribute("Nom").Value == "Lucky Luke").FirstOrDefault();


            // On recupere l'id maximum
            var id = titreLuckyLuke.Descendants("Album").Attributes("Id").Max(a => int.Parse(a.Value));

            // Désormais, on souhaite rajouter l'Album "Le pont sur le Mississippi", écrit par Morris et sorti en 1994.
            // Il faut donc modifier ses Albums. 
            titreLuckyLuke.Element("Albums").Add(new XElement("Album", new XAttribute("Titre", "Le pont sur le Mississippi"), 
                                                                       new XAttribute("Année", "1994"), 
                                                                       new XAttribute("Id",++id)));

            docMissi.Save(@"D:\Exercices\XML\CollectionsBD.xml");

        }


        // Mettre en majuscules le titre de l’album N° 15 d’Astérix
        public static void MajAlbum15()
        {
            // On charge le fichier Xml en mémoire. Pour cela, on utilise XDocument.load.
            XDocument docGaulois = XDocument.Load(@"D:\Exercices\XML\CollectionsBD.xml");

            // On souhaite premièrement obtenir tout les Albums d'Asterix. Puis on recherche celui dont l'Id est égal à 15.
            var titreAsterix = docGaulois.Descendants("CollectionBD").Where(b => b.Attribute("Nom").Value == "Astérix");
            var titreAsterix2 = titreAsterix.Descendants("Album").Where(f => f.Attribute("Id").Value == "15").Attributes("Titre").FirstOrDefault();

            titreAsterix2.Value = titreAsterix2.Value.ToUpper();
            docGaulois.Save(@"D:\Exercices\XML\CollectionsBD.xml");
        }

    }
}
