using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace FullStackedLineChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // Create a new chart.
            ChartControl fullStackedLineChart = new ChartControl();

            // Create two full-stacked line series.
            Series series1 = new Series("Series 1", ViewType.FullStackedLine);
            Series series2 = new Series("Series 2", ViewType.FullStackedLine);

            // Add points to them.
            series1.Points.Add(new SeriesPoint(new DateTime(1997, 1, 11), 10));
            series1.Points.Add(new SeriesPoint(new DateTime(1999, 1, 11), 962));
            series1.Points.Add(new SeriesPoint(new DateTime(2001, 1, 11), 18832));
            series1.Points.Add(new SeriesPoint(new DateTime(2003, 1, 11), 264332));
            series1.Points.Add(new SeriesPoint(new DateTime(2005, 1, 11), 1112753));
            series1.Points.Add(new SeriesPoint(new DateTime(2007, 1, 11), 4169758));

            series2.Points.Add(new SeriesPoint(new DateTime(1997, 1, 11), 391));
            series2.Points.Add(new SeriesPoint(new DateTime(1999, 1, 11), 4082));
            series2.Points.Add(new SeriesPoint(new DateTime(2001, 1, 11), 21932));
            series2.Points.Add(new SeriesPoint(new DateTime(2003, 1, 11), 64195));
            series2.Points.Add(new SeriesPoint(new DateTime(2005, 1, 11), 78473));
            series2.Points.Add(new SeriesPoint(new DateTime(2007, 1, 11), 101830));

            // Add both series to the chart.
            fullStackedLineChart.Series.AddRange(new Series[] { series1, series2 });

            // Access the type-specific options of the diagram.
            ((XYDiagram)fullStackedLineChart.Diagram).EnableAxisXZooming = true;
            ((XYDiagram)fullStackedLineChart.Diagram).AxisY.Label.TextPattern = "{VP:P0}";

            // Hide the legend (if necessary).
            fullStackedLineChart.Legend.Visible = false;

            // Add a title to the chart (if necessary).
            fullStackedLineChart.Titles.Add(new ChartTitle());
            fullStackedLineChart.Titles[0].Text = "Full Stacked Line Chart";

            // Add the chart to the form.
            fullStackedLineChart.Dock = DockStyle.Fill;
            this.Controls.Add(fullStackedLineChart);
        }
    }
}
