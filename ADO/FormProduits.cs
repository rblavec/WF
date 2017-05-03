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
    public partial class FormProduits : Form
    {
        //création d'un champ produits qui correspond à une bindinglist
        private BindingList<Produit> _Produits;
        private List<Produit> _produitsAjoutés;
        private List<Produit> _produitsSupprimés;

        public FormProduits()
        {
            InitializeComponent();

            _Produits = DAL.Produits();
            dgv_listeprod.DataSource = _Produits;
            _produitsAjoutés = new List<Produit>();
            _produitsSupprimés = new List<Produit>();

            // On s'abonne au bouton Plus
            btn_plus.Click += Btn_plus_Click;

            // On s'abonne au bouton Moins
            btn_moins.Click += Btn_moins_Click;

            // On s'abonne au bouton enregistrer

            btn_enregistrer.Click += Btn_enregistrer_Click;

        }

        private void Btn_enregistrer_Click(object sender, EventArgs e)
        {
            DAL.InsertionProdMAsse(_produitsAjoutés);
            DAL.SupressionDeMasse(_produitsSupprimés.Select(a => a.ProduitId));
        }

        private void Btn_moins_Click(object sender, EventArgs e)
        {
            try
            {
                _produitsSupprimés.Remove((Produit)dgv_listeprod.CurrentRow.DataBoundItem);
                //DAL.SuppressionProduit((Produit)dgv_listeprod.CurrentRow.DataBoundItem);
                _Produits.Remove((Produit)dgv_listeprod.CurrentRow.DataBoundItem);
            }
            catch (System.Data.SqlClient.SqlException exeption1)
            {
                if (exeption1.Number == 547)
                    MessageBox.Show("Attention, le produit selectionné est reférencé dans la liste des commandes");
                else throw;
            }


        }

        // Click sur le bouton plus
        // Permet l'ouverture de la fenetre modale FormSaisieProduit
        private void Btn_plus_Click(object sender, EventArgs e)
        {

            using (var form = new FormSaisieProduit())
            {
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {

                    _produitsAjoutés.Add(form.ProduitSaisi);
                    _Produits.Add(form.ProduitSaisi);
                    //DAL.AjoutProduit(form.ProduitSaisi);  
                    // Rafraichi les ID
                    _Produits = DAL.Produits();
                    dgv_listeprod.DataSource = _Produits;
                }
            }

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }


    }
}
