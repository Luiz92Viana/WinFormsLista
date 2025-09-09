namespace WinFormsLista
{
    partial class FormEx8
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
            this.lblNum = new System.Windows.Forms.Label();
            this.tbxNum = new System.Windows.Forms.TextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(38, 21);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(84, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Digite o número:";
            // 
            // tbxNum
            // 
            this.tbxNum.Location = new System.Drawing.Point(39, 45);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(100, 20);
            this.tbxNum.TabIndex = 1;
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(42, 81);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 23);
            this.btnNum.TabIndex = 2;
            this.btnNum.Text = "Calcular";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(38, 210);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(90, 13);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "Lista de números:";
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(39, 238);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(120, 95);
            this.lbxLista.TabIndex = 4;
            // 
            // FormEx8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 373);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.tbxNum);
            this.Controls.Add(this.lblNum);
            this.Name = "FormEx8";
            this.Text = "Números primos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ListBox lbxLista;
    }
}