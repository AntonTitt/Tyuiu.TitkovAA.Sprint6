using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Tyuiu.TitkovAA.Sprint6.Task2.V19.Lib;
namespace Tyuiu.TitkovAA.Sprint6.Task2.V19
{
    public partial class FormMain_TAA : Form
    {
        public FormMain_TAA()
        {
            InitializeComponent();
        }
        DataService dt = new DataService();

        private void button_About_TAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task2 выполнил студент группы РПСб 23-1 Титков Антон Алексеевич", "Сообщение");
        }

        private void button_Do_TAA_Click(object sender, EventArgs e)
        {
            try
            {

                int startValue = Convert.ToInt32(Textbox_Inputstart_TAA.Text);
                int stopValue = Convert.ToInt32(Textbox_inputend_TAA.Text);


                int len = dt.GetMassFunction(startValue, stopValue).Length;

                double[] valarray = new double[len];

                valarray = dt.GetMassFunction(startValue, stopValue);

                this.chart_Function_TAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_Function_TAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_out_TAA.Rows.Add(Convert.ToString(startValue), Convert.ToString(valarray[i]));
                    this.chart_Function_TAA.Series[0].Points.AddXY(startValue, valarray[i]);
                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Неверно введенные данные", "Ошибка");
            }
        }
    }
}
