namespace WinFormsLista
{
    partial class FormList
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxList = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.Location = new System.Drawing.Point(67, 68);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(120, 95);
            this.lbxList.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(83, 183);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listar";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(64, 38);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(112, 13);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "Listagem de Números:";
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 251);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lbxList);
            this.Name = "FormList";
            this.Text = "Formulário de Listagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblList;
    }
}

