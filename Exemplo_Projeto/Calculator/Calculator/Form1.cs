using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		List<float> ResistorsList = new List<float>();

		#region Form Events
		private void button1_Click(object sender, EventArgs e)
		{
			float res = 0;
			if (rd_parallel.Checked)
			{
				res = resistorParallel(ResistorsList.Count, ResistorsList.ToArray());
			}
			else if (rd_Serie.Checked)
			{
				res = resistorSerie(ResistorsList.Count, ResistorsList.ToArray());
			}

			res = (float)Math.Round(res, 2);
			lblResResistor.Text= res.ToString() + " Ohm";
		}
		private void btn_AddResistor_Click(object sender, EventArgs e)
		{
			if (txtResistor.Text != null)
			{
				listResistors.Items.Add(txtResistor.Text);
				ResistorsList.Add(float.Parse(txtResistor.Text.Replace('.', ',')));
			}
			txtResistor.Text = "";
		}
		private void btn_removeResistor_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem eachItem in listResistors.SelectedItems)
			{
				ResistorsList.RemoveAt(eachItem.Index);
				listResistors.Items.Remove(eachItem);
				
			}
		}
		private void btn_Generator_Click(object sender, EventArgs e)
		{
			GenerateSignal(
				float.Parse(txtFrequency.Text.Replace('.', ',')),
				float.Parse(txtAmplitude.Text.Replace('.', ',')));
		}
		#endregion


		#region methods to calculate resistors
		private float resistorParallel(int n, float[] resistencias)
		{
			double res_paralelo = 0;
			for (int i = 0; i < n; i++)
			{
				res_paralelo += (1.0 / resistencias[i]);
			}
			return ((float)(1.0 / res_paralelo));
		
		}
		private float resistorSerie(int n, float[] resistencias)
		{
			float res_serie = 0;
			for (int i = 0; i < n; i++)
			{
				res_serie += resistencias[i];
			}
			return res_serie;
		}


		#endregion

		#region methods to generate signal
		private void GenerateSignal(float frequency, float amplitude)
		{
			double fase = 0.0;          
			double period = 1.0 / frequency;
			
			ChartArea chartArea = new ChartArea();
			chartArea.Name = "ChartArea";
			chartArea.AxisX.Minimum = 0;
			chartArea.AxisX.Maximum = period;
			chartArea.AxisY.Minimum = -amplitude;
			chartArea.AxisY.Maximum = amplitude;


			Series series = new Series();
			series.ChartArea = "ChartArea";
			series.ChartType = SeriesChartType.Line;
			series.IsVisibleInLegend = false;

			int points = 50;
			double sample = period / points;

			for (int i = 0; i < points; i++)
			{
				double time = i * sample;
				double valor = amplitude * Math.Sin(2 * Math.PI * frequency * time + fase);
				series.Points.AddXY(time, valor);
			}
			chart1.ChartAreas.Clear();
			chart1.ChartAreas.Add(chartArea);

			chart1.Series.Clear();
			chart1.Series.Add(series);
			chart1.Size = new System.Drawing.Size(300, 200);
			
		}
		#endregion
	}
}
