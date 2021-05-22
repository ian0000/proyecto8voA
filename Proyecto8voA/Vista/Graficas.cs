using LiveCharts;
using LiveCharts.Wpf;
using Proyecto8voA.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8voA.Vista
{
    public partial class Graficas : Form
    {
        public Graficas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controlador controladores = new Controlador();
            List<object> datos = new List<object>();
            int tamanio = controladores.contador_partido();
            datos = controladores.obtener_nombre();
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection piechartData = new SeriesCollection();
            System.Windows.Media.Brush[] color = { System.Windows.Media.Brushes.Thistle, System.Windows.Media.Brushes.Maroon, System.Windows.Media.Brushes.MediumTurquoise, System.Windows.Media.Brushes.LightSteelBlue, System.Windows.Media.Brushes.MediumSlateBlue,
                                                    System.Windows.Media.Brushes.Plum,System.Windows.Media.Brushes.SkyBlue, System.Windows.Media.Brushes.IndianRed,System.Windows.Media.Brushes.Tan,System.Windows.Media.Brushes.Wheat,System.Windows.Media.Brushes.DarkOliveGreen};
            Random r = new Random();
            ///maldicion funciona
            for (int i = 0; i < tamanio ; i++)
                {
                Console.WriteLine(controladores.obtener_votos(datos[i].ToString()));
                    double num_votos = (double)controladores.obtener_votos(datos[i].ToString());
                    var randomValue = color[r.Next(0, 11)];
                    piechartData.Add
                    (
                        new PieSeries
                        {   
                            Title = datos[i].ToString(),
                            Values = new ChartValues<double> { num_votos },
                            DataLabels = true,
                            LabelPoint = labelPoint,

                            // Define a custom Color 
                            Fill = randomValue
                        }
                    );
                }
            pieChart1.Series = piechartData;
            pieChart1.LegendLocation = LegendLocation.Right;
        }

    }
}
