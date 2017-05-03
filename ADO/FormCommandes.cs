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
    public partial class FormCommandes : Form
    {
        public FormCommandes()
        {
            InitializeComponent();
            btn_voircommandes.Click += (object sender, EventArgs e) => dgv_afficherlisteclients.DataSource = DAL.ListClients(txt_idclient.Text);
            //Btn_voircommandes_Click; 
        }

        //private void Btn_voircommandes_Click(object sender, EventArgs e)
        //{
        //    dgv_afficherlisteclients.DataSource = DAL.ListClients(txt_idclient.Text);
        //}

        private void Txt_idclient_Enter(object sender, EventArgs e)
        {

            dgv_afficherlisteclients.DataSource = DAL.ListClients(txt_idclient.SelectedText);
            //dvg_.DataSource = DAL.ListFournisseur((string)cbox_Pays.SelectedValue);
            //  txt_NbProdPays.Text = DAL.NbProdFourni((string)cbox_Pays.SelectedValue).ToString();
        }
    }
}
