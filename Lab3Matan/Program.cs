using Lab3Matan;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ScottPlot;

namespace Lab3Matan
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
           




            // —оздание графика
            //Chart chart = new Chart();
            //chart.Size = new System.Drawing.Size(600, 400);
            //chart.ChartAreas.Add(new ChartArea("Interpolation"));
            //Series series1 = new Series();
            ////Series series2 = new Series();
            //series1.ChartType = SeriesChartType.Line;
            //series1.Color = System.Drawing.Color.Blue;

            ////series2.Color = System.Drawing.Color.Red;
            ////series2.ChartType = SeriesChartType.Line;

            //for (double xi = -1; xi <= 7; xi += 0.01)
            //{
            //    double interpolatedValue = LagrangeInterpolation.LagrangeBasis(x, y, x.Length, xi);
            //    series1.Points.AddXY(xi, interpolatedValue);
            //}

            ////for (double xi = -1; xi <= 7; xi += 0.01)
            ////{
            ////    double interpolatedValue = NewtonInterpolation.NewtonInterpolate(x, y, x.Length, xi);
            ////    series2.Points.AddXY(xi, interpolatedValue);
            ////}

            //chart.ChartAreas[0].AxisX.Interval = 0.5f; // интервал между делени€ми на оси X
            //chart.ChartAreas[0].AxisX.IntervalOffset = 0; // смещение делений на оси X
            //chart.ChartAreas[0].AxisY.Interval = 5; // интервал между делени€ми на оси Y
            //chart.ChartAreas[0].AxisY.IntervalOffset = 0; // смещение делений на оси 


            //// ƒобавление графика на форму
            //chart.Series.Add(series1);
            ////chart.Series.Add(series2);
            //Form form = new Form();
            //form.Controls.Add(chart);
            //form.ShowDialog();

           


        }

    }
}