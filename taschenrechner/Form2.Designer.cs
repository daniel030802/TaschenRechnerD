namespace taschenrechner
{
    partial class Form2
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
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.btnWurzel = new System.Windows.Forms.Button();
            this.txtbZahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.BackColor = System.Drawing.Color.White;
            this.lblErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErgebnis.Location = new System.Drawing.Point(472, 101);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(0, 26);
            this.lblErgebnis.TabIndex = 0;
            // 
            // btnWurzel
            // 
            this.btnWurzel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWurzel.Location = new System.Drawing.Point(352, 96);
            this.btnWurzel.Name = "btnWurzel";
            this.btnWurzel.Size = new System.Drawing.Size(59, 35);
            this.btnWurzel.TabIndex = 1;
            this.btnWurzel.Text = "✔";
            this.btnWurzel.UseVisualStyleBackColor = true;
            this.btnWurzel.Click += new System.EventHandler(this.btnWurzel_Click);
            // 
            // txtbZahl
            // 
            this.txtbZahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbZahl.Location = new System.Drawing.Point(69, 98);
            this.txtbZahl.MaxLength = 20;
            this.txtbZahl.Name = "txtbZahl";
            this.txtbZahl.Size = new System.Drawing.Size(252, 32);
            this.txtbZahl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wurzelrechner";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(602, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbZahl);
            this.Controls.Add(this.btnWurzel);
            this.Controls.Add(this.lblErgebnis);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Wurzelrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Button btnWurzel;
        private System.Windows.Forms.TextBox txtbZahl;
        private System.Windows.Forms.Label label1;
    }
}