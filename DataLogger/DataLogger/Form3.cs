using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataLogger
{
    public partial class Form3 : Form
    {
        private Form1 mainForm = null;

        Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series
        {
            Name = "Series1",
            Color = System.Drawing.Color.Green,
            IsVisibleInLegend = true,
            IsXValueIndexed = true,
            ChartType = SeriesChartType.Line
        };
        Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series
        {
            Name = "Series2",
            Color = System.Drawing.Color.Red,
            IsVisibleInLegend = true,
            IsXValueIndexed = true,
            ChartType = SeriesChartType.Line
        };
        public Form3(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            series1.YAxisType = AxisType.Secondary;

            for (int i=0; i < 3650; i++)
            {
                series1.Points.AddXY(i, i);
                series2.Points.AddXY(i, i-10);
            }
            chart1.Invalidate();
        }
        public void UpdateChart(Form1.DataSeriesObject dataSeriesLocal1)
        {
            /*try
            {
                dataSeriesX[SeriesIndex] = double.Parse(data[0]);
                dataSeriesY[SeriesIndex] = double.Parse(data[1]);
            }catch (Exception ex)
            {
                MessageBox.Show("UpdateChart exception:" + ex);
            }
            */
            int indexer = dataSeriesLocal1.SeriesIndex;
            series1.Points.Clear();
            series2.Points.Clear();
            for (int i = 0; i < dataSeriesLocal1.getSeriesLength(); i++)
            {
                //series1.Points.AddXY(dataSeriesX[i], dataSeriesY[i]);
                series1.Points.AddXY(i, dataSeriesLocal1.dataSeriesY[indexer]);
                series2.Points.AddXY(i, dataSeriesLocal1.dataSeriesX[indexer]);
                if (indexer < (dataSeriesLocal1.getSeriesLength() - 1))
                {
                    indexer = indexer + 1;
                } else
                {
                    indexer = 0;
                }
            }
            /*
            //series1.Points.AddXY(SeriesIndex,double.Parse(data));
            if(SeriesIndex>=SeriesLength-1)
            {
                SeriesIndex = 0;
            }
            else
            {
                SeriesIndex = SeriesIndex + 1;
            }
            
            //return 0;*/
        }

        private void timerUpdateChart_Tick(object sender, EventArgs e)
        {
            //printDebug("", "UpdateChart");
            
            UpdateChart(this.mainForm.getDataSeries());
        }

        private void numericUpDownChartRefreshRate_ValueChanged(object sender, EventArgs e)
        {
            timerUpdateChart.Interval = (int)(numericUpDownChartRefreshRate.Value);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timerUpdateChart.Enabled = checkBoxAutoUpdateEnabled.Checked;
        }
    }
}
