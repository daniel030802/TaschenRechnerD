namespace taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbZahl1 = new System.Windows.Forms.TextBox();
            this.txtbErgebnis = new System.Windows.Forms.TextBox();
            this.txtbZahl2 = new System.Windows.Forms.TextBox();
            this.btnGleich = new System.Windows.Forms.Button();
            this.listbOperationen = new System.Windows.Forms.ListBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnKomma = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.btnWurzel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbZahl1
            // 
            this.txtbZahl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbZahl1.Location = new System.Drawing.Point(26, 95);
            this.txtbZahl1.MaxLength = 30;
            this.txtbZahl1.Name = "txtbZahl1";
            this.txtbZahl1.ReadOnly = true;
            this.txtbZahl1.Size = new System.Drawing.Size(155, 32);
            this.txtbZahl1.TabIndex = 0;
            this.txtbZahl1.Click += new System.EventHandler(this.txtbZahl1_Click);
            // 
            // txtbErgebnis
            // 
            this.txtbErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbErgebnis.Location = new System.Drawing.Point(646, 95);
            this.txtbErgebnis.Name = "txtbErgebnis";
            this.txtbErgebnis.ReadOnly = true;
            this.txtbErgebnis.Size = new System.Drawing.Size(181, 32);
            this.txtbErgebnis.TabIndex = 1;
            // 
            // txtbZahl2
            // 
            this.txtbZahl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbZahl2.Location = new System.Drawing.Point(281, 95);
            this.txtbZahl2.MaxLength = 30;
            this.txtbZahl2.Name = "txtbZahl2";
            this.txtbZahl2.ReadOnly = true;
            this.txtbZahl2.Size = new System.Drawing.Size(175, 32);
            this.txtbZahl2.TabIndex = 2;
            this.txtbZahl2.Click += new System.EventHandler(this.txtbZahl2_Click);
            // 
            // btnGleich
            // 
            this.btnGleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGleich.Location = new System.Drawing.Point(502, 87);
            this.btnGleich.Name = "btnGleich";
            this.btnGleich.Size = new System.Drawing.Size(104, 39);
            this.btnGleich.TabIndex = 3;
            this.btnGleich.Text = "=";
            this.btnGleich.UseVisualStyleBackColor = true;
            this.btnGleich.Click += new System.EventHandler(this.btnGleich_Click);
            // 
            // listbOperationen
            // 
            this.listbOperationen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbOperationen.FormattingEnabled = true;
            this.listbOperationen.ItemHeight = 25;
            this.listbOperationen.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            ":"});
            this.listbOperationen.Location = new System.Drawing.Point(208, 95);
            this.listbOperationen.Name = "listbOperationen";
            this.listbOperationen.ScrollAlwaysVisible = true;
            this.listbOperationen.Size = new System.Drawing.Size(41, 29);
            this.listbOperationen.TabIndex = 4;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(89, 182);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(116, 62);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(266, 182);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(116, 62);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(442, 182);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(116, 62);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(89, 267);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(116, 62);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(266, 267);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(116, 62);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(442, 267);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(116, 62);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(89, 353);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(116, 62);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(266, 353);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(116, 62);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(442, 353);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(116, 62);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(266, 434);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(116, 62);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnKomma
            // 
            this.btnKomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKomma.Location = new System.Drawing.Point(442, 434);
            this.btnKomma.Name = "btnKomma";
            this.btnKomma.Size = new System.Drawing.Size(116, 62);
            this.btnKomma.TabIndex = 15;
            this.btnKomma.Text = ",";
            this.btnKomma.UseVisualStyleBackColor = true;
            this.btnKomma.Click += new System.EventHandler(this.btnKomma_Click);
            // 
            // btnCls
            // 
            this.btnCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCls.Location = new System.Drawing.Point(646, 182);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(116, 62);
            this.btnCls.TabIndex = 16;
            this.btnCls.Text = "C";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // btnWurzel
            // 
            this.btnWurzel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWurzel.Location = new System.Drawing.Point(646, 353);
            this.btnWurzel.Name = "btnWurzel";
            this.btnWurzel.Size = new System.Drawing.Size(192, 62);
            this.btnWurzel.TabIndex = 17;
            this.btnWurzel.Text = "Wurzelfunktion";
            this.btnWurzel.UseVisualStyleBackColor = true;
            this.btnWurzel.Click += new System.EventHandler(this.btnWurzel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(893, 526);
            this.Controls.Add(this.btnWurzel);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnKomma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.listbOperationen);
            this.Controls.Add(this.btnGleich);
            this.Controls.Add(this.txtbZahl2);
            this.Controls.Add(this.txtbErgebnis);
            this.Controls.Add(this.txtbZahl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "taschenrechner 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbZahl1;
        private System.Windows.Forms.TextBox txtbErgebnis;
        private System.Windows.Forms.TextBox txtbZahl2;
        private System.Windows.Forms.Button btnGleich;
        private System.Windows.Forms.ListBox listbOperationen;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnKomma;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Button btnWurzel;
    }
}

