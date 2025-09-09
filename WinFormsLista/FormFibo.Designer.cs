namespace WinFormsLista
{
    partial class FormFibo
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(58, 42);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(84, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Digite o número:";
            // 
            // tbxNum
            // 
            this.tbxNum.Location = new System.Drawing.Point(58, 68);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(100, 20);
            this.tbxNum.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(58, 119);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(58, 192);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(90, 13);
            this.lblLista.TabIndex = 3;
            this.lblLista.Text = "Lista de números:";
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(58, 220);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(120, 95);
            this.lbxLista.TabIndex = 4;
            // 
            // FormFibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 347);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbxNum);
            this.Controls.Add(this.lblNum);
            this.Name = "FormFibo";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ListBox lbxLista;
    }
}