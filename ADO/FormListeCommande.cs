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


    public partial class FormListeCommande : Form
    {
        private List<Commande> _liste { get; set; }

        public FormListeCommande()
        {
            InitializeComponent();
            dgv_Commandes.CellClick += Dgv_Commandes_SelectionChanged;
            btn_ok.Click += Btn_ok_Click;
            btn_export.Click += Btn_export_Click;
            btn_importer.Click += Btn_importer_Click;
            btn_test.Click += Btn_test_Click;   
        }

        private void Btn_test_Click(object sender, EventArgs e)
        {
            DAL.ExporterXml_XmlWriter(_liste);
        }

        private void Btn_importer_Click(object sender, EventArgs e)
        {
            DAL.ImporterXml();
        }

        private void Btn_export_Click(object sender, EventArgs e)
        {
            DAL.ExporterXml(_liste);
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            dgv_ListeCommande.DataSource = _liste.Where(c => c.CustomerID == textBox1.Text).First().DetailCommande;
            //.DetailCommande s'assure que l'on renvoie une liste.
        }

        private void Dgv_Commandes_SelectionChanged(object sender, EventArgs e)
        {
            Commande selection = (Commande)dgv_Commandes.CurrentRow.DataBoundItem;
            dgv_ListeCommande.DataSource = _liste.Where(c => c.OrderId == selection.OrderId).First().DetailCommande;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _liste = DAL.ListeCommande();
            dgv_Commandes.DataSource = _liste;
        }
    }
}
