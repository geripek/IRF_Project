namespace IRF_YMOOIX
{
    partial class Kezdolap
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
            this.gombok2 = new IRF_YMOOIX.Osztalyok.Gombok();
            this.szovegek1 = new IRF_YMOOIX.Osztalyok.Szovegek();
            this.SuspendLayout();
            // 
            // gombok2
            // 
            this.gombok2.BackColor = System.Drawing.Color.Fuchsia;
            this.gombok2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.gombok2.Location = new System.Drawing.Point(815, 266);
            this.gombok2.Name = "gombok2";
            this.gombok2.Size = new System.Drawing.Size(85, 35);
            this.gombok2.TabIndex = 4;
            this.gombok2.Text = "gombok2";
            this.gombok2.UseVisualStyleBackColor = false;
            this.gombok2.Click += new System.EventHandler(this.gombok2_Click);
            // 
            // szovegek1
            // 
            this.szovegek1.AutoSize = true;
            this.szovegek1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.szovegek1.Location = new System.Drawing.Point(12, 9);
            this.szovegek1.Name = "szovegek1";
            this.szovegek1.Size = new System.Drawing.Size(82, 19);
            this.szovegek1.TabIndex = 2;
            this.szovegek1.Text = "szovegek1";
            // 
            // Kezdolap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(912, 313);
            this.Controls.Add(this.gombok2);
            this.Controls.Add(this.szovegek1);
            this.Name = "Kezdolap";
            this.Text = "Kezdőlap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Osztalyok.Szovegek szovegek1;
        private Osztalyok.Gombok gombok2;
    }
}

