using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormSaisieProduit : Form
    {
        public Produit ProduitSaisi { get; private set; }

        public FormSaisieProduit()
        {

            InitializeComponent();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                ProduitSaisi = new Produit();
                ProduitSaisi.NomProduit = txt_nom.Text;
                ProduitSaisi.Categorie = Convert.ToInt32(txt_categorie.Text);
                ProduitSaisi.QuantiteUnitaire = txt_quantite.Text;
                ProduitSaisi.PrixUnit = Convert.ToDecimal(msktbox_prixunit.Text);
                ProduitSaisi.UnitinStock = int.Parse(msktbox_uniteenstock.Text);
                ProduitSaisi.Fournisseur = Convert.ToInt32(txt_fournisseur.Text);
            }

            base.OnClosing(e);
            
        }

    }
}
