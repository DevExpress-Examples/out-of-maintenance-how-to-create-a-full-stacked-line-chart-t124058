Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace FullStackedLineChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			' Create a new chart.
			Dim fullStackedLineChart As New ChartControl()

			' Create two full-stacked line series.
			Dim series1 As New Series("Series 1", ViewType.FullStackedLine)
			Dim series2 As New Series("Series 2", ViewType.FullStackedLine)

			' Add points to them.
			series1.Points.Add(New SeriesPoint(New DateTime(1997, 1, 11), 10))
			series1.Points.Add(New SeriesPoint(New DateTime(1999, 1, 11), 962))
			series1.Points.Add(New SeriesPoint(New DateTime(2001, 1, 11), 18832))
			series1.Points.Add(New SeriesPoint(New DateTime(2003, 1, 11), 264332))
			series1.Points.Add(New SeriesPoint(New DateTime(2005, 1, 11), 1112753))
			series1.Points.Add(New SeriesPoint(New DateTime(2007, 1, 11), 4169758))

			series2.Points.Add(New SeriesPoint(New DateTime(1997, 1, 11), 391))
			series2.Points.Add(New SeriesPoint(New DateTime(1999, 1, 11), 4082))
			series2.Points.Add(New SeriesPoint(New DateTime(2001, 1, 11), 21932))
			series2.Points.Add(New SeriesPoint(New DateTime(2003, 1, 11), 64195))
			series2.Points.Add(New SeriesPoint(New DateTime(2005, 1, 11), 78473))
			series2.Points.Add(New SeriesPoint(New DateTime(2007, 1, 11), 101830))

			' Add both series to the chart.
			fullStackedLineChart.Series.AddRange(New Series() { series1, series2 })

			' Access the type-specific options of the diagram.
			CType(fullStackedLineChart.Diagram, XYDiagram).EnableAxisXZooming = True
			CType(fullStackedLineChart.Diagram, XYDiagram).AxisY.Label.TextPattern = "{VP:P0}"

			' Hide the legend (if necessary).
			fullStackedLineChart.Legend.Visible = False

			' Add a title to the chart (if necessary).
			fullStackedLineChart.Titles.Add(New ChartTitle())
			fullStackedLineChart.Titles(0).Text = "Full Stacked Line Chart"

			' Add the chart to the form.
			fullStackedLineChart.Dock = DockStyle.Fill
			Me.Controls.Add(fullStackedLineChart)
		End Sub
	End Class
End Namespace
