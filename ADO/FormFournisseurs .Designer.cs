namespace ADO
{
    partial class FormFournisseurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFournisseurs));
            this.dvgFournisseurs = new System.Windows.Forms.DataGridView();
            this.cbox_Pays = new System.Windows.Forms.ComboBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NbProdPays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFournisseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgFournisseurs
            // 
            this.dvgFournisseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgFournisseurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFournisseurs.Location = new System.Drawing.Point(27, 67);
            this.dvgFournisseurs.Name = "dvgFournisseurs";
            this.dvgFournisseurs.Size = new System.Drawing.Size(658, 354);
            this.dvgFournisseurs.TabIndex = 0;
            // 
            // cbox_Pays
            // 
            this.cbox_Pays.FormattingEnabled = true;
            this.cbox_Pays.Location = new System.Drawing.Point(161, 29);
            this.cbox_Pays.Name = "cbox_Pays";
            this.cbox_Pays.Size = new System.Drawing.Size(377, 21);
            this.cbox_Pays.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(610, 27);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(24, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de produits fournis par l\'ensemble des fournisseurs du pays sélectionné :";
            // 
            // txt_NbProdPays
            // 
            this.txt_NbProdPays.AutoSize = true;
            this.txt_NbProdPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NbProdPays.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txt_NbProdPays.Location = new System.Drawing.Point(521, 434);
            this.txt_NbProdPays.Name = "txt_NbProdPays";
            this.txt_NbProdPays.Size = new System.Drawing.Size(29, 16);
            this.txt_NbProdPays.TabIndex = 5;
            this.txt_NbProdPays.Text = "000";
            // 
            // FormFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 470);
            this.Controls.Add(this.txt_NbProdPays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.cbox_Pays);
            this.Controls.Add(this.dvgFournisseurs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFournisseurs";
            this.Text = "FormFournisseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dvgFournisseurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgFournisseurs;
        private System.Windows.Forms.ComboBox cbox_Pays;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_NbProdPays;
    }
}