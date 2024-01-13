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
			if (rd_parallel.Checked)
			{
				resistorParallel(ResistorsList.Count, ResistorsList.ToArray());
			}
			else if (rd_Serie.Checked)
			{
				resistorSerie(ResistorsList.Count, ResistorsList.ToArray());
			}
		}
		private void btn_AddResistor_Click(object sender, EventArgs e)
		{
			if (txtResistor.Text != null)
			{
				listResistors.Items.Add(txtResistor.Text);
				ResistorsList.Add(float.Parse(txtResistor.Text));
			}
			txtResistor.Text = "";
		}
		private void btn_removeResistor_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem eachItem in listResistors.SelectedItems)
			{
				listResistors.Items.Remove(eachItem);
				ResistorsList.Remove(eachItem.Index);
			}
		}
		private void btn_Generator_Click(object sender, EventArgs e)
		{

		}
		#endregion


		#region methods to calculate resistors
		private double resistorParallel(int n, float[] resistencias)
		{
			float res_paralelo = 0;
			for (int i = 0; i < n; i++)
			{
				//res_paralelo += (1.0 / resistencias[i]);
			}
			return (1.0 / res_paralelo);
		
		}
		private double resistorSerie(int n, float[] resistencias)
		{
			float res_serie = 0;
			for (int i = 0; i < n; i++)
			{
				res_serie += resistencias[i];
			}
			return res_serie;
		}


		#endregion

	}
}
