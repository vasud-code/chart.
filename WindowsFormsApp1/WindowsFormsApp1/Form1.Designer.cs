namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(30D, 50D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 10D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Диаграммы_Main = new System.Windows.Forms.Label();
            this.Вид_Графика = new System.Windows.Forms.Label();
            this.Колонны_Main = new System.Windows.Forms.Button();
            this.Пончик_Main = new System.Windows.Forms.Button();
            this.Области_Main = new System.Windows.Forms.Button();
            this.Полосы_Main = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.колонныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.полосыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.областиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.пончикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Диаграммы_Main
            // 
            this.Диаграммы_Main.AutoSize = true;
            this.Диаграммы_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Диаграммы_Main.Location = new System.Drawing.Point(622, 110);
            this.Диаграммы_Main.Name = "Диаграммы_Main";
            this.Диаграммы_Main.Size = new System.Drawing.Size(135, 25);
            this.Диаграммы_Main.TabIndex = 0;
            this.Диаграммы_Main.Text = "Диаграммa";
            this.Диаграммы_Main.Click += new System.EventHandler(this.label1_Click);
            // 
            // Вид_Графика
            // 
            this.Вид_Графика.AutoSize = true;
            this.Вид_Графика.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вид_Графика.Location = new System.Drawing.Point(12, 110);
            this.Вид_Графика.Name = "Вид_Графика";
            this.Вид_Графика.Size = new System.Drawing.Size(155, 25);
            this.Вид_Графика.TabIndex = 5;
            this.Вид_Графика.Text = "Вид Графика";
            // 
            // Колонны_Main
            // 
            this.Колонны_Main.Location = new System.Drawing.Point(17, 175);
            this.Колонны_Main.Name = "Колонны_Main";
            this.Колонны_Main.Size = new System.Drawing.Size(75, 23);
            this.Колонны_Main.TabIndex = 6;
            this.Колонны_Main.Text = "Колонны";
            this.Колонны_Main.UseVisualStyleBackColor = true;
            this.Колонны_Main.Click += new System.EventHandler(this.Колонны_Main_Click);
            // 
            // Пончик_Main
            // 
            this.Пончик_Main.Location = new System.Drawing.Point(17, 376);
            this.Пончик_Main.Name = "Пончик_Main";
            this.Пончик_Main.Size = new System.Drawing.Size(75, 23);
            this.Пончик_Main.TabIndex = 7;
            this.Пончик_Main.Text = "Пончик";
            this.Пончик_Main.UseVisualStyleBackColor = true;
            this.Пончик_Main.Click += new System.EventHandler(this.Пончик_Main_Click);
            // 
            // Области_Main
            // 
            this.Области_Main.Location = new System.Drawing.Point(17, 314);
            this.Области_Main.Name = "Области_Main";
            this.Области_Main.Size = new System.Drawing.Size(75, 23);
            this.Области_Main.TabIndex = 8;
            this.Области_Main.Text = "Области";
            this.Области_Main.UseVisualStyleBackColor = true;
            this.Области_Main.Click += new System.EventHandler(this.Области_Main_Click);
            // 
            // Полосы_Main
            // 
            this.Полосы_Main.Location = new System.Drawing.Point(17, 243);
            this.Полосы_Main.Name = "Полосы_Main";
            this.Полосы_Main.Size = new System.Drawing.Size(75, 23);
            this.Полосы_Main.TabIndex = 9;
            this.Полосы_Main.Text = "Полосы";
            this.Полосы_Main.UseVisualStyleBackColor = true;
            this.Полосы_Main.Click += new System.EventHandler(this.Полосы_Main_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(500, 138);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(300, 300);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колонныToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 72);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // колонныToolStripMenuItem
            // 
            this.колонныToolStripMenuItem.Name = "колонныToolStripMenuItem";
            this.колонныToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.колонныToolStripMenuItem.Text = "Колонны";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полосыToolStripMenuItem,
            this.открытьToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 48);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // полосыToolStripMenuItem
            // 
            this.полосыToolStripMenuItem.Name = "полосыToolStripMenuItem";
            this.полосыToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.полосыToolStripMenuItem.Text = "Полосы";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.областиToolStripMenuItem,
            this.открытьToolStripMenuItem2});
            this.menuStrip3.Location = new System.Drawing.Point(0, 24);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 13;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // областиToolStripMenuItem
            // 
            this.областиToolStripMenuItem.Name = "областиToolStripMenuItem";
            this.областиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.областиToolStripMenuItem.Text = "Области";
            // 
            // открытьToolStripMenuItem2
            // 
            this.открытьToolStripMenuItem2.Name = "открытьToolStripMenuItem2";
            this.открытьToolStripMenuItem2.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem2.Text = "Открыть";
            this.открытьToolStripMenuItem2.Click += new System.EventHandler(this.открытьToolStripMenuItem2_Click_1);
            // 
            // menuStrip4
            // 
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пончикToolStripMenuItem,
            this.открытьToolStripMenuItem3});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(800, 24);
            this.menuStrip4.TabIndex = 14;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // пончикToolStripMenuItem
            // 
            this.пончикToolStripMenuItem.Name = "пончикToolStripMenuItem";
            this.пончикToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.пончикToolStripMenuItem.Text = "Пончик";
            // 
            // открытьToolStripMenuItem3
            // 
            this.открытьToolStripMenuItem3.Name = "открытьToolStripMenuItem3";
            this.открытьToolStripMenuItem3.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem3.Text = "Открыть";
            this.открытьToolStripMenuItem3.Click += new System.EventHandler(this.открытьToolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.Полосы_Main);
            this.Controls.Add(this.Области_Main);
            this.Controls.Add(this.Пончик_Main);
            this.Controls.Add(this.Колонны_Main);
            this.Controls.Add(this.Вид_Графика);
            this.Controls.Add(this.Диаграммы_Main);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.menuStrip4);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Диаграммы_Main;
        private System.Windows.Forms.Label Вид_Графика;
        private System.Windows.Forms.Button Колонны_Main;
        private System.Windows.Forms.Button Пончик_Main;
        private System.Windows.Forms.Button Области_Main;
        private System.Windows.Forms.Button Полосы_Main;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem колонныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem полосыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem областиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem пончикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem3;
    }
}

