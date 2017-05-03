using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class Produit
    {
        public int? ProduitId { get; set; }

        public string NomProduit { get; set; }

        public int? Categorie { get; set; }

        public string QuantiteUnitaire { get; set; }

        public decimal? PrixUnit { get; set; }

        public int? UnitinStock { get; set; }

        public int? Fournisseur { get; set; }

        public bool Obsolete { get; set; }

    }


}
