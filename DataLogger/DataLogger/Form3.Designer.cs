namespace DataLogger
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerUpdateChart = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownChartRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxAutoUpdateEnabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChartRefreshRate)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(183, 56);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(527, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timerUpdateChart
            // 
            this.timerUpdateChart.Interval = 5000;
            this.timerUpdateChart.Tick += new System.EventHandler(this.timerUpdateChart_Tick);
            // 
            // numericUpDownChartRefreshRate
            // 
            this.numericUpDownChartRefreshRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownChartRefreshRate.Location = new System.Drawing.Point(610, 28);
            this.numericUpDownChartRefreshRate.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.numericUpDownChartRefreshRate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownChartRefreshRate.Name = "numericUpDownChartRefreshRate";
            this.numericUpDownChartRefreshRate.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownChartRefreshRate.TabIndex = 25;
            this.numericUpDownChartRefreshRate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownChartRefreshRate.ValueChanged += new System.EventHandler(this.numericUpDownChartRefreshRate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Chart Refresh Rate (mS)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // checkBoxAutoUpdateEnabled
            // 
            this.checkBoxAutoUpdateEnabled.AutoSize = true;
            this.checkBoxAutoUpdateEnabled.Location = new System.Drawing.Point(717, 28);
            this.checkBoxAutoUpdateEnabled.Name = "checkBoxAutoUpdateEnabled";
            this.checkBoxAutoUpdateEnabled.Size = new System.Drawing.Size(74, 21);
            this.checkBoxAutoUpdateEnabled.TabIndex = 26;
            this.checkBoxAutoUpdateEnabled.Text = "Enable";
            this.checkBoxAutoUpdateEnabled.UseVisualStyleBackColor = true;
            this.checkBoxAutoUpdateEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 481);
            this.Controls.Add(this.checkBoxAutoUpdateEnabled);
            this.Controls.Add(this.numericUpDownChartRefreshRate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chart1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChartRefreshRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timerUpdateChart;
        private System.Windows.Forms.NumericUpDown numericUpDownChartRefreshRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxAutoUpdateEnabled;
    }
}