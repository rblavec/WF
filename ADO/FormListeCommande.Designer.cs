namespace ADO
{
    partial class FormListeCommande
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
            this.dgv_Commandes = new System.Windows.Forms.DataGridView();
            this.dgv_ListeCommande = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.Commandes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_importer = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeCommande)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Commandes
            // 
            this.dgv_Commandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Commandes.Location = new System.Drawing.Point(12, 83);
            this.dgv_Commandes.Name = "dgv_Commandes";
            this.dgv_Commandes.Size = new System.Drawing.Size(352, 365);
            this.dgv_Commandes.TabIndex = 0;
            // 
            // dgv_ListeCommande
            // 
            this.dgv_ListeCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeCommande.Location = new System.Drawing.Point(383, 83);
            this.dgv_ListeCommande.Name = "dgv_ListeCommande";
            this.dgv_ListeCommande.Size = new System.Drawing.Size(336, 365);
            this.dgv_ListeCommande.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(383, 6);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // Commandes
            // 
            this.Commandes.AutoSize = true;
            this.Commandes.BackColor = System.Drawing.Color.DarkGray;
            this.Commandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commandes.ForeColor = System.Drawing.Color.Cornsilk;
            this.Commandes.Location = new System.Drawing.Point(100, 6);
            this.Commandes.Name = "Commandes";
            this.Commandes.Size = new System.Drawing.Size(127, 24);
            this.Commandes.TabIndex = 3;
            this.Commandes.Text = "Commandes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lignes de commandes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.Commandes);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 37);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(383, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 37);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_export.Location = new System.Drawing.Point(615, 6);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(104, 27);
            this.btn_export.TabIndex = 6;
            this.btn_export.Text = "Export to XML";
            this.btn_export.UseVisualStyleBackColor = false;
            // 
            // btn_importer
            // 
            this.btn_importer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_importer.Location = new System.Drawing.Point(495, 6);
            this.btn_importer.Name = "btn_importer";
            this.btn_importer.Size = new System.Drawing.Size(104, 27);
            this.btn_importer.TabIndex = 6;
            this.btn_importer.Text = "Import to XML";
            this.btn_importer.UseVisualStyleBackColor = false;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(644, 466);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 7;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            // 
            // FormListeCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 501);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_importer);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_ListeCommande);
            this.Controls.Add(this.dgv_Commandes);
            this.Name = "FormListeCommande";
            this.Text = "Details_Commande";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Commandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeCommande)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Commandes;
        private System.Windows.Forms.DataGridView dgv_ListeCommande;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label Commandes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_importer;
        private System.Windows.Forms.Button btn_test;
    }
}