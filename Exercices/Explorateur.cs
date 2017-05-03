using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    public class Explorateur
    {

        #region Méthodes
        public static void Explorer(string chemin, DelegueExplorateur deleg)
        {

            // Create a DirectoryInfo of the directory of the files to enumerate.
            DirectoryInfo DirInfo = new DirectoryInfo(chemin);

            // LINQ query for all files.
            var files = DirInfo.EnumerateFiles("*", SearchOption.AllDirectories);
            //PAR DEFAULT SANS RIEN ENTRE PARATHESE ON A QUE LES TOP DIRECTORY ONLY SANS LES SOUS DOSSIERS
            //* veut dire on prend tout.

            // Montre les résultats.
            foreach (var a in files)
            {
                deleg(a);
            }

        }


        #endregion

    }

    public delegate void DelegueExplorateur(FileInfo f);
}
