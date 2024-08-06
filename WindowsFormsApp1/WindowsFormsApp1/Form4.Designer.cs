namespace WindowsFormsApp1
{
    partial class Области_FORM4
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
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ADD_BUTTON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // LABEL_X
            // 
            this.LABEL_X.AutoSize = true;
            this.LABEL_X.Location = new System.Drawing.Point(12, 9);
            this.LABEL_X.Name = "LABEL_X";
            this.LABEL_X.Size = new System.Drawing.Size(14, 13);
            this.LABEL_X.TabIndex = 0;
            this.LABEL_X.Text = "X";
            // 
            // LABEL_Y
            // 
            this.LABEL_Y.AutoSize = true;
            this.LABEL_Y.Location = new System.Drawing.Point(113, 6);
            this.LABEL_Y.Name = "LABEL_Y";
            this.LABEL_Y.Size = new System.Drawing.Size(14, 13);
            this.LABEL_Y.TabIndex = 1;
            this.LABEL_Y.Text = "Y";
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(261, 22);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(503, 399);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // ADD_BUTTON
            // 
            this.ADD_BUTTON.Location = new System.Drawing.Point(73, 48);
            this.ADD_BUTTON.Name = "ADD_BUTTON";
            this.ADD_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.ADD_BUTTON.TabIndex = 5;
            this.ADD_BUTTON.Text = "Add";
            this.ADD_BUTTON.UseVisualStyleBackColor = true;
            this.ADD_BUTTON.Click += new System.EventHandler(this.ADD_BUTTON_Click);
            // 
            // Области_FORM4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ADD_BUTTON);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.LABEL_Y);
            this.Controls.Add(this.LABEL_X);
            this.Name = "Области_FORM4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_X;
        private System.Windows.Forms.Label LABEL_Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ADD_BUTTON;
    }
}