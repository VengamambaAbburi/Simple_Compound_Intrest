namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textP = new System.Windows.Forms.TextBox();
            this.textR = new System.Windows.Forms.TextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.textRe = new System.Windows.Forms.TextBox();
            this.simpleInt = new System.Windows.Forms.Button();
            this.CmpInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interest rate  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Term of the loan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result";
            // 
            // textP
            // 
            this.textP.Location = new System.Drawing.Point(656, 68);
            this.textP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(148, 26);
            this.textP.TabIndex = 4;
            // 
            // textR
            // 
            this.textR.Location = new System.Drawing.Point(656, 132);
            this.textR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textR.Name = "textR";
            this.textR.Size = new System.Drawing.Size(148, 26);
            this.textR.TabIndex = 5;
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(656, 192);
            this.textN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(148, 26);
            this.textN.TabIndex = 6;
            // 
            // textRe
            // 
            this.textRe.Location = new System.Drawing.Point(656, 260);
            this.textRe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textRe.Name = "textRe";
            this.textRe.ReadOnly = true;
            this.textRe.Size = new System.Drawing.Size(148, 26);
            this.textRe.TabIndex = 7;
            // 
            // simpleInt
            // 
            this.simpleInt.Location = new System.Drawing.Point(380, 349);
            this.simpleInt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.simpleInt.Name = "simpleInt";
            this.simpleInt.Size = new System.Drawing.Size(273, 35);
            this.simpleInt.TabIndex = 12;
            this.simpleInt.Text = "Simple Interest";
            this.simpleInt.UseVisualStyleBackColor = true;
            this.simpleInt.Click += new System.EventHandler(this.SimpleInt_Click);
            // 
            // CmpInt
            // 
            this.CmpInt.Location = new System.Drawing.Point(772, 349);
            this.CmpInt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmpInt.Name = "CmpInt";
            this.CmpInt.Size = new System.Drawing.Size(273, 35);
            this.CmpInt.TabIndex = 13;
            this.CmpInt.Text = "Compound Interest";
            this.CmpInt.UseVisualStyleBackColor = true;
            this.CmpInt.Click += new System.EventHandler(this.CmpInt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.CmpInt);
            this.Controls.Add(this.simpleInt);
            this.Controls.Add(this.textRe);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.textR);
            this.Controls.Add(this.textP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.TextBox textR;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.TextBox textRe;
        private System.Windows.Forms.Button simpleInt;
        private System.Windows.Forms.Button CmpInt;
    }
}

