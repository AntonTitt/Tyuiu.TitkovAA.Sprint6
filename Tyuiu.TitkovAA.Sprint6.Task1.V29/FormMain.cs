using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TitkovAA.Sprint6.Task1.V29.Lib;

namespace Tyuiu.TitkovAA.Sprint6.Task1.V29
{
    public partial class FormMain_TAA : Form
    {
        public FormMain_TAA()
        {
            InitializeComponent();
        }
        DataService dt = new DataService();

        private void button_Do_TAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(Textbox_Inputstart_TAA.Text);
                int stopValue = Convert.ToInt32(Textbox_inputend_TAA.Text);

                string strLine;

                int len = dt.GetMassFunction(startValue, stopValue).Length;


                double[] valarray = new double[len];

                valarray = dt.GetMassFunction(startValue, stopValue);

                textBox_output_TAA.Text = "";
                textBox_output_TAA.AppendText("+----------+----------+" + Environment.NewLine);
                textBox_output_TAA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBox_output_TAA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 7:f}  |", startValue, valarray[i]);
                    textBox_output_TAA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBox_output_TAA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка");
            }
            

        }

        private void button_About_TAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task1 выполнил студент группы РПСб 23-1 Титков Антон Алексеевич", "Сообщение");
        }
    }
}
