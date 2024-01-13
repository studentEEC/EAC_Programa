namespace Calculator
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.btn_Calculate = new System.Windows.Forms.Button();
			this.rd_Serie = new System.Windows.Forms.RadioButton();
			this.rd_parallel = new System.Windows.Forms.RadioButton();
			this.gB_Resistors = new System.Windows.Forms.GroupBox();
			this.btn_removeResistor = new System.Windows.Forms.Button();
			this.btn_AddResistor = new System.Windows.Forms.Button();
			this.txtResistor = new System.Windows.Forms.TextBox();
			this.listResistors = new System.Windows.Forms.ListView();
			this.gB_SignalGenerator = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Generator = new System.Windows.Forms.Button();
			this.txtAmplitude = new System.Windows.Forms.TextBox();
			this.txtFrequency = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblResResistor = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.gB_Resistors.SuspendLayout();
			this.gB_SignalGenerator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Calculate
			// 
			this.btn_Calculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_Calculate.Location = new System.Drawing.Point(165, 143);
			this.btn_Calculate.Name = "btn_Calculate";
			this.btn_Calculate.Size = new System.Drawing.Size(149, 36);
			this.btn_Calculate.TabIndex = 0;
			this.btn_Calculate.Text = "Calcular";
			this.btn_Calculate.UseVisualStyleBackColor = false;
			this.btn_Calculate.Click += new System.EventHandler(this.button1_Click);
			// 
			// rd_Serie
			// 
			this.rd_Serie.AutoSize = true;
			this.rd_Serie.Location = new System.Drawing.Point(11, 112);
			this.rd_Serie.Name = "rd_Serie";
			this.rd_Serie.Size = new System.Drawing.Size(49, 17);
			this.rd_Serie.TabIndex = 1;
			this.rd_Serie.TabStop = true;
			this.rd_Serie.Text = "Série";
			this.rd_Serie.UseVisualStyleBackColor = true;
			// 
			// rd_parallel
			// 
			this.rd_parallel.AutoSize = true;
			this.rd_parallel.Location = new System.Drawing.Point(77, 112);
			this.rd_parallel.Name = "rd_parallel";
			this.rd_parallel.Size = new System.Drawing.Size(63, 17);
			this.rd_parallel.TabIndex = 2;
			this.rd_parallel.TabStop = true;
			this.rd_parallel.Text = "Paralelo";
			this.rd_parallel.UseVisualStyleBackColor = true;
			// 
			// gB_Resistors
			// 
			this.gB_Resistors.Controls.Add(this.lblResResistor);
			this.gB_Resistors.Controls.Add(this.label3);
			this.gB_Resistors.Controls.Add(this.btn_removeResistor);
			this.gB_Resistors.Controls.Add(this.btn_AddResistor);
			this.gB_Resistors.Controls.Add(this.txtResistor);
			this.gB_Resistors.Controls.Add(this.listResistors);
			this.gB_Resistors.Controls.Add(this.rd_parallel);
			this.gB_Resistors.Controls.Add(this.btn_Calculate);
			this.gB_Resistors.Controls.Add(this.rd_Serie);
			this.gB_Resistors.Location = new System.Drawing.Point(12, 21);
			this.gB_Resistors.Name = "gB_Resistors";
			this.gB_Resistors.Size = new System.Drawing.Size(330, 191);
			this.gB_Resistors.TabIndex = 3;
			this.gB_Resistors.TabStop = false;
			this.gB_Resistors.Text = "Resistências";
			// 
			// btn_removeResistor
			// 
			this.btn_removeResistor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_removeResistor.Location = new System.Drawing.Point(73, 78);
			this.btn_removeResistor.Name = "btn_removeResistor";
			this.btn_removeResistor.Size = new System.Drawing.Size(24, 23);
			this.btn_removeResistor.TabIndex = 6;
			this.btn_removeResistor.Text = "-";
			this.btn_removeResistor.UseVisualStyleBackColor = true;
			this.btn_removeResistor.Click += new System.EventHandler(this.btn_removeResistor_Click);
			// 
			// btn_AddResistor
			// 
			this.btn_AddResistor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_AddResistor.Location = new System.Drawing.Point(103, 78);
			this.btn_AddResistor.Name = "btn_AddResistor";
			this.btn_AddResistor.Size = new System.Drawing.Size(24, 23);
			this.btn_AddResistor.TabIndex = 5;
			this.btn_AddResistor.Text = "+";
			this.btn_AddResistor.UseVisualStyleBackColor = true;
			this.btn_AddResistor.Click += new System.EventHandler(this.btn_AddResistor_Click);
			// 
			// txtResistor
			// 
			this.txtResistor.Location = new System.Drawing.Point(20, 50);
			this.txtResistor.Name = "txtResistor";
			this.txtResistor.Size = new System.Drawing.Size(108, 20);
			this.txtResistor.TabIndex = 4;
			// 
			// listResistors
			// 
			this.listResistors.HideSelection = false;
			this.listResistors.Location = new System.Drawing.Point(165, 19);
			this.listResistors.Name = "listResistors";
			this.listResistors.Size = new System.Drawing.Size(149, 110);
			this.listResistors.TabIndex = 3;
			this.listResistors.UseCompatibleStateImageBehavior = false;
			// 
			// gB_SignalGenerator
			// 
			this.gB_SignalGenerator.Controls.Add(this.chart1);
			this.gB_SignalGenerator.Controls.Add(this.label2);
			this.gB_SignalGenerator.Controls.Add(this.label1);
			this.gB_SignalGenerator.Controls.Add(this.btn_Generator);
			this.gB_SignalGenerator.Controls.Add(this.txtAmplitude);
			this.gB_SignalGenerator.Controls.Add(this.txtFrequency);
			this.gB_SignalGenerator.Location = new System.Drawing.Point(12, 218);
			this.gB_SignalGenerator.Name = "gB_SignalGenerator";
			this.gB_SignalGenerator.Size = new System.Drawing.Size(329, 403);
			this.gB_SignalGenerator.TabIndex = 4;
			this.gB_SignalGenerator.TabStop = false;
			this.gB_SignalGenerator.Text = "Gerador Sinal";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Amplitude (V):";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Frequência(Hz):";
			// 
			// btn_Generator
			// 
			this.btn_Generator.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_Generator.Location = new System.Drawing.Point(165, 115);
			this.btn_Generator.Name = "btn_Generator";
			this.btn_Generator.Size = new System.Drawing.Size(149, 36);
			this.btn_Generator.TabIndex = 5;
			this.btn_Generator.Text = "Gerar";
			this.btn_Generator.UseVisualStyleBackColor = false;
			this.btn_Generator.Click += new System.EventHandler(this.btn_Generator_Click);
			// 
			// txtAmplitude
			// 
			this.txtAmplitude.Location = new System.Drawing.Point(103, 71);
			this.txtAmplitude.Name = "txtAmplitude";
			this.txtAmplitude.Size = new System.Drawing.Size(108, 20);
			this.txtAmplitude.TabIndex = 6;
			// 
			// txtFrequency
			// 
			this.txtFrequency.Location = new System.Drawing.Point(103, 33);
			this.txtFrequency.Name = "txtFrequency";
			this.txtFrequency.Size = new System.Drawing.Size(108, 20);
			this.txtFrequency.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "R.Equivalente:";
			// 
			// lblResResistor
			// 
			this.lblResResistor.AutoSize = true;
			this.lblResResistor.Location = new System.Drawing.Point(85, 157);
			this.lblResResistor.Name = "lblResResistor";
			this.lblResResistor.Size = new System.Drawing.Size(0, 13);
			this.lblResResistor.TabIndex = 8;
			// 
			// chart1
			// 
			this.chart1.AllowDrop = true;
			chartArea1.Name = "ChartArea";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(6, 157);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			this.chart1.Size = new System.Drawing.Size(317, 235);
			this.chart1.TabIndex = 9;
			this.chart1.Text = "chart1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 633);
			this.Controls.Add(this.gB_SignalGenerator);
			this.Controls.Add(this.gB_Resistors);
			this.Name = "Form1";
			this.Text = "EletricalTool";
			this.gB_Resistors.ResumeLayout(false);
			this.gB_Resistors.PerformLayout();
			this.gB_SignalGenerator.ResumeLayout(false);
			this.gB_SignalGenerator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_Calculate;
		private System.Windows.Forms.RadioButton rd_Serie;
		private System.Windows.Forms.RadioButton rd_parallel;
		private System.Windows.Forms.GroupBox gB_Resistors;
		private System.Windows.Forms.Button btn_AddResistor;
		private System.Windows.Forms.TextBox txtResistor;
		private System.Windows.Forms.ListView listResistors;
		private System.Windows.Forms.GroupBox gB_SignalGenerator;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Generator;
		private System.Windows.Forms.TextBox txtAmplitude;
		private System.Windows.Forms.TextBox txtFrequency;
		private System.Windows.Forms.Button btn_removeResistor;
		private System.Windows.Forms.Label lblResResistor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}

