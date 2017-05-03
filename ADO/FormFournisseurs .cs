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
    public partial class FormFournisseurs : Form
    {
        public FormFournisseurs()
        {
            InitializeComponent();
            dvgFournisseurs.DataSource = DAL.ListFournisseur();
            cbox_Pays.DataSource = DAL.PaysList();
            cbox_Pays.SelectedIndexChanged += Cbox_Pays_SelectedIndexChanged;
            btn_Reset.Click += Btn_Reset_Click;    
                  
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            dvgFournisseurs.DataSource = DAL.ListFournisseur();
        }

        private void Cbox_Pays_SelectedIndexChanged(object sender, EventArgs e)
        {          
            dvgFournisseurs.DataSource = DAL.ListFournisseur((string)cbox_Pays.SelectedValue);
            txt_NbProdPays.Text = DAL.NbProdFourni((string)cbox_Pays.SelectedValue).ToString();
        }

        protected override void OnLoad(EventArgs e)
        {
            dvgFournisseurs.DataSource = DAL.Produits();
            base.OnLoad(e); 
        }
    }
}
