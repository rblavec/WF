using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            //Passe la langue en anglais
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

            InitializeComponent();
                        
            btn_search.Click += Btn_search_Click;
            chk_NbTotFich.CheckedChanged += Chk_NbTotFich_Click;
            chk_NbFichCS.CheckedChanged += Chk_NbFichCS_CheckedChanged;

            //chk_NomFichLong.CheckedChanged += Chk_NomFichLong_CheckedChanged;

            //Exemple d'utilisation d'une expression lambda à la place d'une méthode
            chk_NomFichLong.CheckedChanged += (object sender, EventArgs e) =>
            {
                lbl_VraiNomLong.Visible = chk_NomFichLong.Checked;
                txt_NomLong.Visible = chk_NomFichLong.Checked;
            };

            chk_ListProj.CheckedChanged += Chk_ListProj_CheckedChanged;
            btn_Analyser.Click += Btn_Analyser_Click;

            this.Load += Form1_Load;
            //this.FormClosed += Form1_FormClosed;
            this.FormClosing += Form1_FormClosing;
            this.Text = Properties.Resources.TitreAplli;
        }

        private void Btn_Analyser_Click(object sender, EventArgs e)
        {
            
            col_liste.Items.Clear();
            Analyseur.AnalyserDossier(txt_search.Text);
            txt_NbFichiers.Text = string.Format("{0}", Analyseur.NbFichiers);
            txt_NbrFichiersCS.Text = string.Format("{0}", Analyseur.NbFichiercs);
            lbl_VraiNomLong.Text = Analyseur.FichierPlusLong;
            foreach (var a in Analyseur.FichierProjets)
            {
                col_liste.Items.Add(a);
            }
           

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons savedConfig = MessageBoxButtons.YesNoCancel;

            DialogResult result = MessageBox.Show(Properties.Resources.TexteMessageBox, "Sauvegarde", savedConfig);
            if (result == DialogResult.Yes)
            {

                Properties.Settings.Default.NomDossier = txt_search.Text;

                //////////////////////////////////////////////////////////////////////
                //les checked ne sont pas indispensables car il y a une sauvegarde auto SI le settings est créé depuis la propriété du component
                Properties.Settings.Default.ParaNbFichier = chk_NbTotFich.Checked;

                Properties.Settings.Default.ParaNbFichierCS = chk_NbFichCS.Checked;

                Properties.Settings.Default.ParaNomfichier = chk_NomFichLong.Checked;

                Properties.Settings.Default.ParaListeProjet = chk_ListProj.Checked;
                //////////////////////////////////////////////////////////////////////

                Properties.Settings.Default.Save();

            }

            if (result == DialogResult.Cancel)
            e.Cancel = true;
        }

        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{


        //    MessageBoxButtons savedConfig = MessageBoxButtons.YesNo;

        //    DialogResult result = MessageBox.Show("Voulez-vous sauvegarder ?", "Sauvegarde", savedConfig);
        //    if (result == DialogResult.Yes)
        //    {

        //        Properties.Settings.Default.NomDossier = txt_search.Text;

        //        Properties.Settings.Default.ParaNbFichier = chk_NbTotFich.Checked;

        //        Properties.Settings.Default.ParaNbFichierCS = chk_NbFichCS.Checked;

        //        Properties.Settings.Default.ParaNomfichier = chk_NomFichLong.Checked;

        //        Properties.Settings.Default.ParaListeProjet = chk_ListProj.Checked;

        //        Properties.Settings.Default.Save();

        //    }
            

        //}

        private void Form1_Load(object sender, EventArgs e)
        {

            txt_search.Text = Properties.Settings.Default.NomDossier;

            chk_NbTotFich.Checked = Properties.Settings.Default.ParaNbFichier;

            chk_NbFichCS.Checked = Properties.Settings.Default.ParaNbFichierCS;

            chk_NomFichLong.Checked = Properties.Settings.Default.ParaNomfichier;

            chk_ListProj.Checked = Properties.Settings.Default.ParaListeProjet;

        }

        private void Chk_ListProj_CheckedChanged(object sender, EventArgs e)
        {

        
            if (chk_ListProj.Checked)
            {
                col_liste.Show();
                pan_fichProj.Show();
            }
            else
            {
                col_liste.Hide();
                pan_fichProj.Hide();
            }
        }

        private void Chk_NomFichLong_CheckedChanged(object sender, EventArgs e)
        {

            //txt_NomLong.Visible = chk_NomFichLong.Checked;

            txt_NomLong.Visible = chk_NomFichLong.Checked ? true : false;
            // si chk_NomFichLong.Checked = true,  txt_NomLong.Visible = true. si chk_NomFichLong.Checked = false,  txt_NomLong.Visible = false. 
            //ou
            //if (chk_NomFichLong.Checked)
            //{ txt_NomLong.Show(); }
            //else
            //{ txt_NomLong.Hide(); }

        }

        private void Chk_NbFichCS_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NbFichCS.Checked)
            { txt_NbrFichiersCS.Show(); }
            else
            { txt_NbrFichiersCS.Hide(); }

        }

        private void Chk_NbTotFich_Click(object sender, EventArgs e)
        {

            txt_NbFichiers.Visible = chk_NbTotFich.Checked ? true : false;

            //if (chk_NbTotFich.Checked)
            //{ txt_NbFichiers.Show(); }
            //else
            //{ txt_NbFichiers.Hide(); }


        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            var deleg = new FolderBrowserDialog();

            if (deleg.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(deleg.SelectedPath))
            {
                txt_search.Text = deleg.SelectedPath;

                //Properties.Settings.Default.NomDossier = deleg.SelectedPath;
                //Properties.Settings.Default.Save();
            }


        }

     
    }


}
