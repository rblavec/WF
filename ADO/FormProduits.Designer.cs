namespace ADO
{
    partial class FormProduits
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
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_moins = new System.Windows.Forms.Button();
            this.dgv_listeprod = new System.Windows.Forms.DataGridView();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeprod)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(27, 24);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(34, 33);
            this.btn_plus.TabIndex = 0;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            // 
            // btn_moins
            // 
            this.btn_moins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moins.Location = new System.Drawing.Point(67, 24);
            this.btn_moins.Name = "btn_moins";
            this.btn_moins.Size = new System.Drawing.Size(36, 33);
            this.btn_moins.TabIndex = 0;
            this.btn_moins.Text = "-";
            this.btn_moins.UseVisualStyleBackColor = true;
            // 
            // dgv_listeprod
            // 
            this.dgv_listeprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listeprod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_listeprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeprod.Location = new System.Drawing.Point(27, 75);
            this.dgv_listeprod.Name = "dgv_listeprod";
            this.dgv_listeprod.Size = new System.Drawing.Size(592, 368);
            this.dgv_listeprod.TabIndex = 1;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(127, 24);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(77, 33);
            this.btn_enregistrer.TabIndex = 2;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // FormProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(643, 476);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.dgv_listeprod);
            this.Controls.Add(this.btn_moins);
            this.Controls.Add(this.btn_plus);
            this.Name = "FormProduits";
            this.Text = "Produits";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeprod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_moins;
        private System.Windows.Forms.DataGridView dgv_listeprod;
        private System.Windows.Forms.Button btn_enregistrer;
    }
}