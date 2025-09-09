namespace WinFormsLista
{
    partial class FormEx2
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
            this.lbxNum = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(74, 39);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(86, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Digite o Número:";
            // 
            // tbxNum
            // 
            this.tbxNum.Location = new System.Drawing.Point(75, 67);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(100, 20);
            this.tbxNum.TabIndex = 1;
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(76, 111);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 23);
            this.btnNum.TabIndex = 2;
            this.btnNum.Text = "Calcular";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // lbxNum
            // 
            this.lbxNum.FormattingEnabled = true;
            this.lbxNum.Location = new System.Drawing.Point(75, 198);
            this.lbxNum.Name = "lbxNum";
            this.lbxNum.Size = new System.Drawing.Size(120, 95);
            this.lbxNum.TabIndex = 3;
            // 
            // FormEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 349);
            this.Controls.Add(this.lbxNum);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.tbxNum);
            this.Controls.Add(this.lblNum);
            this.Name = "FormEx2";
            this.Text = "Num pares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.ListBox lbxNum;
    }
}