namespace ADO
{
    partial class FormSaisieProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaisieProduit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_categorie = new System.Windows.Forms.TextBox();
            this.txt_fournisseur = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.msktbox_prixunit = new System.Windows.Forms.MaskedTextBox();
            this.msktbox_uniteenstock = new System.Windows.Forms.MaskedTextBox();
            this.txt_quantite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Catégorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantité unitaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prix unitaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Unités en stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fournisseur";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(96, 18);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(213, 20);
            this.txt_nom.TabIndex = 1;
            // 
            // txt_categorie
            // 
            this.txt_categorie.Location = new System.Drawing.Point(95, 54);
            this.txt_categorie.Name = "txt_categorie";
            this.txt_categorie.Size = new System.Drawing.Size(94, 20);
            this.txt_categorie.TabIndex = 2;
            // 
            // txt_fournisseur
            // 
            this.txt_fournisseur.Location = new System.Drawing.Point(95, 205);
            this.txt_fournisseur.Name = "txt_fournisseur";
            this.txt_fournisseur.Size = new System.Drawing.Size(94, 20);
            this.txt_fournisseur.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btn_cancel.Location = new System.Drawing.Point(234, 245);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(153, 245);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // msktbox_prixunit
            // 
            this.msktbox_prixunit.Location = new System.Drawing.Point(95, 132);
            this.msktbox_prixunit.Mask = "999.99";
            this.msktbox_prixunit.Name = "msktbox_prixunit";
            this.msktbox_prixunit.Size = new System.Drawing.Size(94, 20);
            this.msktbox_prixunit.TabIndex = 4;
            // 
            // msktbox_uniteenstock
            // 
            this.msktbox_uniteenstock.Location = new System.Drawing.Point(95, 169);
            this.msktbox_uniteenstock.Mask = "99";
            this.msktbox_uniteenstock.Name = "msktbox_uniteenstock";
            this.msktbox_uniteenstock.Size = new System.Drawing.Size(94, 20);
            this.msktbox_uniteenstock.TabIndex = 6;
            // 
            // txt_quantite
            // 
            this.txt_quantite.Location = new System.Drawing.Point(95, 94);
            this.txt_quantite.Name = "txt_quantite";
            this.txt_quantite.Size = new System.Drawing.Size(94, 20);
            this.txt_quantite.TabIndex = 3;
            // 
            // FormSaisieProduit
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(335, 284);
            this.ControlBox = false;
            this.Controls.Add(this.txt_quantite);
            this.Controls.Add(this.msktbox_uniteenstock);
            this.Controls.Add(this.msktbox_prixunit);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_fournisseur);
            this.Controls.Add(this.txt_categorie);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSaisieProduit";
            this.Text = "Saisie du produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_categorie;
        private System.Windows.Forms.TextBox txt_fournisseur;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.MaskedTextBox msktbox_prixunit;
        private System.Windows.Forms.MaskedTextBox msktbox_uniteenstock;
        private System.Windows.Forms.TextBox txt_quantite;
    }
}