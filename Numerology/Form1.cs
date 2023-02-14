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

namespace Numerology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnCalculation_Click(object sender, EventArgs e)
        {
            var dayMonth = Convert.ToInt32(dtTmPckrBirthday.Value.Day.ToString() + dtTmPckrBirthday.Value.Month.ToString());
            var calculationNumber = dayMonth * dtTmPckrBirthday.Value.Year;
            var digits = GetDigits(calculationNumber);
            List<int> arr = Enumerable.Range(17, 40).ToList();

            this.chartMariage.Series.Clear();

            Series series = this.chartMariage.Series.Add("Chart");
            series.ChartType = SeriesChartType.Spline;
            //  series.LineMarkerOptions.StarPointCount = 5;
            chartMariage.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            chartMariage.ChartAreas.FirstOrDefault().AxisY.Interval = 1;

            series.MarkerStep= 1;
            series.MarkerSize = 1;
            for (int i = 0, j = 0; i < arr.Count; i++, j++)
            {
                series.Points.AddXY(arr[i], digits[j]);
                if (j == calculationNumber.ToString().Length - 1) 
                { 
                    j = 0; 
                }
            }
        }

        public static List<int> GetDigits(int source)
        {
            List<int> digits = new List<int>();
            while (source > 0)
            {
                var digit = source % 10;
                source /= 10;
                digits.Add(digit);
            }
            digits.Reverse();
            return digits;
        }
    }
}
