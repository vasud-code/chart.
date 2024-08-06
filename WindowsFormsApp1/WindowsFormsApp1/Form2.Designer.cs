namespace WindowsFormsApp1
{
    partial class Колонны_Form2
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BUTTON_ADD = new System.Windows.Forms.Button();
            this.X_POINT = new System.Windows.Forms.Label();
            this.Y_POINT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(465, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(323, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // BUTTON_ADD
            // 
            this.BUTTON_ADD.Location = new System.Drawing.Point(85, 61);
            this.BUTTON_ADD.Name = "BUTTON_ADD";
            this.BUTTON_ADD.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_ADD.TabIndex = 3;
            this.BUTTON_ADD.Text = "Add";
            this.BUTTON_ADD.UseVisualStyleBackColor = true;
            this.BUTTON_ADD.Click += new System.EventHandler(this.BUTTON_ADD_Click);
            // 
            // X_POINT
            // 
            this.X_POINT.AutoSize = true;
            this.X_POINT.Location = new System.Drawing.Point(18, 19);
            this.X_POINT.Name = "X_POINT";
            this.X_POINT.Size = new System.Drawing.Size(14, 13);
            this.X_POINT.TabIndex = 4;
            this.X_POINT.Text = "X";
            this.X_POINT.Click += new System.EventHandler(this.label1_Click);
            // 
            // Y_POINT
            // 
            this.Y_POINT.AutoSize = true;
            this.Y_POINT.Location = new System.Drawing.Point(124, 19);
            this.Y_POINT.Name = "Y_POINT";
            this.Y_POINT.Size = new System.Drawing.Size(14, 13);
            this.Y_POINT.TabIndex = 5;
            this.Y_POINT.Text = "Y";
            // 
            // Колонны_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Y_POINT);
            this.Controls.Add(this.X_POINT);
            this.Controls.Add(this.BUTTON_ADD);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Name = "Колонны_Form2";
            this.Text = "Колонны";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BUTTON_ADD;
        private System.Windows.Forms.Label X_POINT;
        private System.Windows.Forms.Label Y_POINT;
    }
}