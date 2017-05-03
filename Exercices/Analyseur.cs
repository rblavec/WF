using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    public static class Analyseur
    {
        public static int NbFichiers { get; private set; } //private set affecte de façon privée à cette classe.
        public static int NbFichiercs { get; private set; }
        public static string FichierPlusLong { get; private set; }
        public static string FichierPlusCourt { get; private set; }
        public static List<string> FichierProjets { get; set; }


        public static void AnalyserDossier(string chemin)
        {

            NbFichiercs = 0;
            FichierPlusLong = string.Empty;
            FichierPlusCourt = string.Empty;
            NbFichiers = 0;
            FichierProjets = new List<string>();
            FichierProjets.Clear();

            DelegueExplorateur d1 = null;
            d1 += CompterFichiers;
            d1 += AnalyserNom;
            d1 += FiltrerProjet;

            Explorateur.Explorer(chemin, d1);

        }

        static public void CompterFichiers(FileInfo f)
        {
            NbFichiers++;
            if (f.Extension.ToLower() == ".cs")
            {
                NbFichiercs++;
            }

        }


        static public void AnalyserNom(FileInfo f)
        {

            if (f.Name.Length > FichierPlusLong.Length)
                FichierPlusLong = f.Name;

            if (f.Name.Length < FichierPlusCourt.Length)
                FichierPlusCourt = f.Name;

        }


        static public void FiltrerProjet(FileInfo f)
        {
            if (f.Extension == ".csproj")
            {
                FichierProjets.Add(Path.GetFileNameWithoutExtension(f.Name));
            }

        }

    }
}
