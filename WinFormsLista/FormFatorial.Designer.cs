namespace WinFormsLista
{
    partial class FormFatorial
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
            this.tbnCalc = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(62, 51);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(84, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Digite o número:";
            // 
            // tbxNum
            // 
            this.tbxNum.Location = new System.Drawing.Point(65, 87);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(100, 20);
            this.tbxNum.TabIndex = 1;
            // 
            // tbnCalc
            // 
            this.tbnCalc.Location = new System.Drawing.Point(65, 136);
            this.tbnCalc.Name = "tbnCalc";
            this.tbnCalc.Size = new System.Drawing.Size(75, 23);
            this.tbnCalc.TabIndex = 2;
            this.tbnCalc.Text = "Calcular";
            this.tbnCalc.UseVisualStyleBackColor = true;
            this.tbnCalc.Click += new System.EventHandler(this.tbnCalc_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(72, 196);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 3;
            // 
            // FormFatorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 382);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.tbnCalc);
            this.Controls.Add(this.tbxNum);
            this.Controls.Add(this.lblNum);
            this.Name = "FormFatorial";
            this.Text = "Fatorial de N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.Button tbnCalc;
        private System.Windows.Forms.Label lblAnswer;
    }
}