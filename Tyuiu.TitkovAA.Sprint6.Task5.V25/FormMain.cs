using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TitkovAA.Sprint6.Task5.V25.Lib;

namespace Tyuiu.TitkovAA.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService dt = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewResult_TAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string path = @"C:\Users\123\source\repos\AntonTitt\Tyuiu.TitkovAA.Sprint6\Tyuiu.TitkovAA.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";


        private void button2_Click(object sender, EventArgs e)
        {

            dataGridViewResult_TAA.ColumnCount = 2;
            dataGridViewResult_TAA.Columns[0].Width = 20;
            dataGridViewResult_TAA.Columns[1].Width = 50;

            this.chartResult_TAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_TAA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult_TAA.Series[0].Points.Clear();
            double[] numsMass = new double[dt.len];
            numsMass = dt.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_TAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_TAA.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void buttonOpen_TAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonAbout_TAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task4 выполнил студент группы РПСб 23-1 Титков Антон Алексеевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
