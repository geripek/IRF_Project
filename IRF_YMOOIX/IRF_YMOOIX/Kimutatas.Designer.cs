﻿namespace IRF_YMOOIX
{
    partial class Kimutatas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gombok5 = new IRF_YMOOIX.Osztalyok.Gombok();
            this.szovegek3 = new IRF_YMOOIX.Osztalyok.Szovegek();
            this.gombok4 = new IRF_YMOOIX.Osztalyok.Gombok();
            this.gombok3 = new IRF_YMOOIX.Osztalyok.Gombok();
            this.gombok2 = new IRF_YMOOIX.Osztalyok.Gombok();
            this.gombok1 = new IRF_YMOOIX.Osztalyok.Gombok();
            this.szovegek2 = new IRF_YMOOIX.Osztalyok.Szovegek();
            this.szovegek1 = new IRF_YMOOIX.Osztalyok.Szovegek();
            this.automata1 = new IRF_YMOOIX.Osztalyok.Automata();
            this.automata2 = new IRF_YMOOIX.Osztalyok.Automata();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 260);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 260);
            this.dataGridView1.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 335);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(730, 248);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "title";
            title1.Text = "Népességváltozás 2008-2019";
            this.chart1.Titles.Add(title1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gombok5
            // 
            this.gombok5.BackColor = System.Drawing.Color.Orange;
            this.gombok5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.gombok5.Location = new System.Drawing.Point(821, 277);
            this.gombok5.Name = "gombok5";
            this.gombok5.Size = new System.Drawing.Size(185, 35);
            this.gombok5.TabIndex = 12;
            this.gombok5.Text = "gombok5";
            this.gombok5.UseVisualStyleBackColor = false;
            this.gombok5.Click += new System.EventHandler(this.gombok5_Click);
            // 
            // szovegek3
            // 
            this.szovegek3.AutoSize = true;
            this.szovegek3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.szovegek3.Location = new System.Drawing.Point(538, 344);
            this.szovegek3.Name = "szovegek3";
            this.szovegek3.Size = new System.Drawing.Size(82, 19);
            this.szovegek3.TabIndex = 11;
            this.szovegek3.Text = "szovegek3";
            // 
            // gombok4
            // 
            this.gombok4.BackColor = System.Drawing.Color.Orange;
            this.gombok4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.gombok4.Location = new System.Drawing.Point(956, 548);
            this.gombok4.Name = "gombok4";
            this.gombok4.Size = new System.Drawing.Size(85, 35);
            this.gombok4.TabIndex = 10;
            this.gombok4.Text = "gombok4";
            this.gombok4.UseVisualStyleBackColor = false;
            this.gombok4.Click += new System.EventHandler(this.gombok4_Click);
            // 
            // gombok3
            // 
            this.gombok3.BackColor = System.Drawing.Color.Orange;
            this.gombok3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.gombok3.Location = new System.Drawing.Point(821, 318);
            this.gombok3.Name = "gombok3";
            this.gombok3.Size = new System.Drawing.Size(185, 35);
            this.gombok3.TabIndex = 9;
            this.gombok3.Text = "gombok3";
            this.gombok3.UseVisualStyleBackColor = false;
            this.gombok3.Click += new System.EventHandler(this.gombok3_Click);
            // 
            // gombok2
            // 
            this.gombok2.BackColor = System.Drawing.Color.Orange;
            this.gombok2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.gombok2.Location = new System.Drawing.Point(921, 236);
            this.gombok2.Name = "gombok2";
            this.gombok2.Size = new System.Drawing.Size(85, 35);
            this.gombok2.TabIndex = 8;
            this.gombok2.Text = "gombok2";
            this.gombok2.UseVisualStyleBackColor = false;
            this.gombok2.Click += new System.EventHandler(this.gombok2_Click);
            // 
            // gombok1
            // 
            this.gombok1.BackColor = System.Drawing.Color.Orange;
            this.gombok1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.gombok1.Location = new System.Drawing.Point(821, 236);
            this.gombok1.Name = "gombok1";
            this.gombok1.Size = new System.Drawing.Size(85, 35);
            this.gombok1.TabIndex = 7;
            this.gombok1.Text = "gombok1";
            this.gombok1.UseVisualStyleBackColor = false;
            this.gombok1.Click += new System.EventHandler(this.gombok1_Click);
            // 
            // szovegek2
            // 
            this.szovegek2.AutoSize = true;
            this.szovegek2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.szovegek2.Location = new System.Drawing.Point(817, 191);
            this.szovegek2.Name = "szovegek2";
            this.szovegek2.Size = new System.Drawing.Size(82, 19);
            this.szovegek2.TabIndex = 6;
            this.szovegek2.Text = "szovegek2";
            // 
            // szovegek1
            // 
            this.szovegek1.AutoSize = true;
            this.szovegek1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.szovegek1.Location = new System.Drawing.Point(8, 9);
            this.szovegek1.Name = "szovegek1";
            this.szovegek1.Size = new System.Drawing.Size(82, 19);
            this.szovegek1.TabIndex = 5;
            this.szovegek1.Text = "szovegek1";
            // 
            // automata1
            // 
            this.automata1.Interval = 4000;
            this.automata1.Tick += new System.EventHandler(this.automata1_Tick);
            // 
            // automata2
            // 
            this.automata2.Interval = 4000;
            this.automata2.Tick += new System.EventHandler(this.automata2_Tick);
            // 
            // Kimutatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1123, 621);
            this.Controls.Add(this.gombok5);
            this.Controls.Add(this.szovegek3);
            this.Controls.Add(this.gombok4);
            this.Controls.Add(this.gombok3);
            this.Controls.Add(this.gombok2);
            this.Controls.Add(this.gombok1);
            this.Controls.Add(this.szovegek2);
            this.Controls.Add(this.szovegek1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "Kimutatas";
            this.Text = "Kimutatás";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private Osztalyok.Szovegek szovegek1;
        private Osztalyok.Szovegek szovegek2;
        private Osztalyok.Gombok gombok3;
        private Osztalyok.Gombok gombok2;
        private Osztalyok.Gombok gombok1;
        private Osztalyok.Gombok gombok4;
        private Osztalyok.Szovegek szovegek3;
        private Osztalyok.Gombok gombok5;
        private Osztalyok.Automata automata2;
        private Osztalyok.Automata automata1;
    }
}