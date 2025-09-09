namespace WinFormsLista
{
    partial class FormEx3
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
            this.lblTI = new System.Windows.Forms.Label();
            this.tbxTI = new System.Windows.Forms.TextBox();
            this.lblQT = new System.Windows.Forms.Label();
            this.tbxQT = new System.Windows.Forms.TextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.tbxRazao = new System.Windows.Forms.TextBox();
            this.btnPG = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTI
            // 
            this.lblTI.AutoSize = true;
            this.lblTI.Location = new System.Drawing.Point(82, 21);
            this.lblTI.Name = "lblTI";
            this.lblTI.Size = new System.Drawing.Size(69, 13);
            this.lblTI.TabIndex = 0;
            this.lblTI.Text = "Termo inicial:";
            // 
            // tbxTI
            // 
            this.tbxTI.Location = new System.Drawing.Point(85, 46);
            this.tbxTI.Name = "tbxTI";
            this.tbxTI.Size = new System.Drawing.Size(100, 20);
            this.tbxTI.TabIndex = 1;
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(82, 79);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(114, 13);
            this.lblQT.TabIndex = 2;
            this.lblQT.Text = "Quantidade de termos:";
            // 
            // tbxQT
            // 
            this.tbxQT.Location = new System.Drawing.Point(85, 110);
            this.tbxQT.Name = "tbxQT";
            this.tbxQT.Size = new System.Drawing.Size(100, 20);
            this.tbxQT.TabIndex = 3;
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(272, 43);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 23);
            this.btnNum.TabIndex = 4;
            this.btnNum.Text = "PA";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(85, 294);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(120, 95);
            this.lbxLista.TabIndex = 5;
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Location = new System.Drawing.Point(93, 147);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(41, 13);
            this.lblRazao.TabIndex = 6;
            this.lblRazao.Text = "Razão:";
            // 
            // tbxRazao
            // 
            this.tbxRazao.Location = new System.Drawing.Point(85, 172);
            this.tbxRazao.Name = "tbxRazao";
            this.tbxRazao.Size = new System.Drawing.Size(100, 20);
            this.tbxRazao.TabIndex = 7;
            // 
            // btnPG
            // 
            this.btnPG.Location = new System.Drawing.Point(272, 79);
            this.btnPG.Name = "btnPG";
            this.btnPG.Size = new System.Drawing.Size(75, 23);
            this.btnPG.TabIndex = 8;
            this.btnPG.Text = "PG";
            this.btnPG.UseVisualStyleBackColor = true;
            this.btnPG.Click += new System.EventHandler(this.btnPG_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(82, 265);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(110, 13);
            this.lblLista.TabIndex = 9;
            this.lblLista.Text = "Listagem de números:";
            // 
            // FormEx3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 401);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnPG);
            this.Controls.Add(this.tbxRazao);
            this.Controls.Add(this.lblRazao);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.tbxQT);
            this.Controls.Add(this.lblQT);
            this.Controls.Add(this.tbxTI);
            this.Controls.Add(this.lblTI);
            this.Name = "FormEx3";
            this.Text = "Progressão Aritmética";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTI;
        private System.Windows.Forms.TextBox tbxTI;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.TextBox tbxQT;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.TextBox tbxRazao;
        private System.Windows.Forms.Button btnPG;
        private System.Windows.Forms.Label lblLista;
    }
}