using System;
using System.Windows.Forms;
using Tyuiu.TitkovAA.Sprint6.Task0.V18.Lib;
namespace Tyuiu.TitkovAA.Sprint6.Task0.V18
{
    public partial class FormMain_TAA : Form
    {
        public FormMain_TAA()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Text_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputBox_Enter(object sender, EventArgs e)
        {

        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            DataService dt = new DataService();


            try
            {
                int a = Convert.ToInt32(Text_Input_x_TAA.Text);
                double c = dt.Calculate(a);
                Text_Output_TAA.Text = Convert.ToString(c);
            }
            catch
            {
                MessageBox.Show("Неверно введенные данные", "Ошибка");
            }
        }

        private void Questionmarkbutton_TAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task0 выполнил студент группы РПСб 23-1 Титков Антон Алексеевич", "Сообщение");
        }


    }


}

