namespace WindowsFormsApp1
{
    partial class Полосы_Form3
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
            this.LABEL_X = new System.Windows.Forms.Label();
            this.LABEL_Y = new System.Windows.Forms.Label();
            this.BUTTON_ADD_WINFORM3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // LABEL_X
            // 
            this.LABEL_X.AutoSize = true;
            this.LABEL_X.Location = new System.Drawing.Point(9, 9);
            this.LABEL_X.Name = "LABEL_X";
            this.LABEL_X.Size = new System.Drawing.Size(14, 13);
            this.LABEL_X.TabIndex = 0;
            this.LABEL_X.Text = "X";
            // 
            // LABEL_Y
            // 
            this.LABEL_Y.AutoSize = true;
            this.LABEL_Y.Location = new System.Drawing.Point(115, 8);
            this.LABEL_Y.Name = "LABEL_Y";
            this.LABEL_Y.Size = new System.Drawing.Size(14, 13);
            this.LABEL_Y.TabIndex = 1;
            this.LABEL_Y.Text = "Y";
            // 
            // BUTTON_ADD_WINFORM3
            // 
            this.BUTTON_ADD_WINFORM3.Location = new System.Drawing.Point(84, 50);
            this.BUTTON_ADD_WINFORM3.Name = "BUTTON_ADD_WINFORM3";
            this.BUTTON_ADD_WINFORM3.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_ADD_WINFORM3.TabIndex = 2;
            this.BUTTON_ADD_WINFORM3.Text = "Add";
            this.BUTTON_ADD_WINFORM3.UseVisualStyleBackColor = true;
            this.BUTTON_ADD_WINFORM3.Click += new System.EventHandler(this.BUTTON_ADD_WINFORM3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(498, 24);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(300, 398);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart1";
            // 
            // Полосы_Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BUTTON_ADD_WINFORM3);
            this.Controls.Add(this.LABEL_Y);
            this.Controls.Add(this.LABEL_X);
            this.Name = "Полосы_Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_X;
        private System.Windows.Forms.Label LABEL_Y;
        private System.Windows.Forms.Button BUTTON_ADD_WINFORM3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}