namespace ADO
{
    partial class FormCommandes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommandes));
            this.txt_idclient = new System.Windows.Forms.TextBox();
            this.btn_voircommandes = new System.Windows.Forms.Button();
            this.dgv_afficherlisteclients = new System.Windows.Forms.DataGridView();
            this.ListClients = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_afficherlisteclients)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_idclient
            // 
            this.txt_idclient.Location = new System.Drawing.Point(37, 31);
            this.txt_idclient.Name = "txt_idclient";
            this.txt_idclient.Size = new System.Drawing.Size(518, 20);
            this.txt_idclient.TabIndex = 0;
            this.txt_idclient.Text = "Identifiant du Client ...";
            // 
            // btn_voircommandes
            // 
            this.btn_voircommandes.Location = new System.Drawing.Point(207, 57);
            this.btn_voircommandes.Name = "btn_voircommandes";
            this.btn_voircommandes.Size = new System.Drawing.Size(180, 23);
            this.btn_voircommandes.TabIndex = 1;
            this.btn_voircommandes.Text = "Voir les Commandes";
            this.btn_voircommandes.UseVisualStyleBackColor = true;
            // 
            // dgv_afficherlisteclients
            // 
            this.dgv_afficherlisteclients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_afficherlisteclients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_afficherlisteclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_afficherlisteclients.Location = new System.Drawing.Point(37, 103);
            this.dgv_afficherlisteclients.Name = "dgv_afficherlisteclients";
            this.dgv_afficherlisteclients.Size = new System.Drawing.Size(518, 141);
            this.dgv_afficherlisteclients.TabIndex = 2;
            // 
            // ListClients
            // 
            this.ListClients.FormattingEnabled = true;
            this.ListClients.Location = new System.Drawing.Point(37, 269);
            this.ListClients.Name = "ListClients";
            this.ListClients.Size = new System.Drawing.Size(518, 17);
            this.ListClients.TabIndex = 3;
            // 
            // FormCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 535);
            this.Controls.Add(this.ListClients);
            this.Controls.Add(this.dgv_afficherlisteclients);
            this.Controls.Add(this.btn_voircommandes);
            this.Controls.Add(this.txt_idclient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommandes";
            this.Text = "FormCommandes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_afficherlisteclients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idclient;
        private System.Windows.Forms.Button btn_voircommandes;
        private System.Windows.Forms.DataGridView dgv_afficherlisteclients;
        private System.Windows.Forms.ListBox ListClients;
    }
}