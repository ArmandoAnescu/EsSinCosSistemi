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

namespace SenoCosenoCirconferenzaGrafico
{
    public partial class Form1 : Form
    {
        double coseno, seno,angolo;
        int raggio, omega;


        Series graficoCoseno = new Series("Coseno")
        {
            ChartType = SeriesChartType.Spline
        };
        Series graficoSeno = new Series("Seno")
        {
            ChartType = SeriesChartType.Spline
        };

       
        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Series graficoCos = chart1.Series["Coseno"];
            Series graficoSin = chart1.Series["Seno"];
            graficoCos.Points.Clear();
            graficoSin.Points.Clear();
            if (String.IsNullOrEmpty(textBox1.Text)) 
            {
                omega = 1;
            }
            else 
            {
                omega = Convert.ToInt32(textBox1.Text);
            }
            for (double i = 0;i<24;i++) 
            {
                angolo=Math.PI+(Math.PI*i);
                coseno=Math.Cos(angolo)*omega;
                seno=Math.Sin(angolo)*omega;
                graficoCos.Points.AddXY(angolo,coseno);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
