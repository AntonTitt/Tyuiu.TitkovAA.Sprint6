using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TitkovAA.Sprint6.Task4.V29.Lib;
namespace Tyuiu.TitkovAA.Sprint6.Task4.V29
{
    public partial class FormMain : Form
    {
        DataService dt = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonSave_TAA.BackColor = Color.LightSkyBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask4.txt";
                File.WriteAllText(path, textBoxResult_TAA.Text);
                DialogResult dialogresult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task4 выполнил студент группы РПСб 23-1 Титков Антон Алексеевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_TAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_TAA.Text);

                int len = dt.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[len];
                valueArray = dt.GetMassFunction(startStep, stopStep);
                this.chartFunction_TAA.Titles.Add("График функции");
                this.chartFunction_TAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_TAA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_TAA.Text = "";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_TAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_TAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_TAA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;

                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }



        }


       


        private void mouseleaveEx_TAA(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
        }

        private void mouseenterEx_TAA(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void mouseentersave_TAA(object sender, EventArgs e)
        {
            buttonSave_TAA.BackColor = Color.LightBlue;
        }

        private void mouseleavesave_TAA(object sender, EventArgs e)
        {
            buttonSave_TAA.BackColor = Color.LightSkyBlue;
        }
    }
}
