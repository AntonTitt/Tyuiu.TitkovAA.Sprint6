
namespace Tyuiu.TitkovAA.Sprint6.Task2.V19
{
    partial class FormMain_TAA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_TAA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox_task_TAA = new System.Windows.Forms.GroupBox();
            this.pictureBox_Task_TAA = new System.Windows.Forms.PictureBox();
            this.textBox_Task_TAA = new System.Windows.Forms.TextBox();
            this.groupBox_Input_TAA = new System.Windows.Forms.GroupBox();
            this.button_About_TAA = new System.Windows.Forms.Button();
            this.button_Do_TAA = new System.Windows.Forms.Button();
            this.Textbox_inputend_TAA = new System.Windows.Forms.TextBox();
            this.Textbox_Inputstart_TAA = new System.Windows.Forms.TextBox();
            this.step_end_TAA = new System.Windows.Forms.Label();
            this.step_start_TAA = new System.Windows.Forms.Label();
            this.groupBox_output_TAA = new System.Windows.Forms.GroupBox();
            this.chart_Function_TAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_out_TAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_task_TAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Task_TAA)).BeginInit();
            this.groupBox_Input_TAA.SuspendLayout();
            this.groupBox_output_TAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Function_TAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_out_TAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_task_TAA
            // 
            this.groupBox_task_TAA.Controls.Add(this.pictureBox_Task_TAA);
            this.groupBox_task_TAA.Controls.Add(this.textBox_Task_TAA);
            this.groupBox_task_TAA.Location = new System.Drawing.Point(12, 12);
            this.groupBox_task_TAA.Name = "groupBox_task_TAA";
            this.groupBox_task_TAA.Size = new System.Drawing.Size(400, 320);
            this.groupBox_task_TAA.TabIndex = 0;
            this.groupBox_task_TAA.TabStop = false;
            this.groupBox_task_TAA.Text = "Условие";
            // 
            // pictureBox_Task_TAA
            // 
            this.pictureBox_Task_TAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Task_TAA.Image")));
            this.pictureBox_Task_TAA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Task_TAA.InitialImage")));
            this.pictureBox_Task_TAA.Location = new System.Drawing.Point(17, 95);
            this.pictureBox_Task_TAA.Name = "pictureBox_Task_TAA";
            this.pictureBox_Task_TAA.Size = new System.Drawing.Size(311, 52);
            this.pictureBox_Task_TAA.TabIndex = 1;
            this.pictureBox_Task_TAA.TabStop = false;
            // 
            // textBox_Task_TAA
            // 
            this.textBox_Task_TAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Task_TAA.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Task_TAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_Task_TAA.Location = new System.Drawing.Point(17, 31);
            this.textBox_Task_TAA.Multiline = true;
            this.textBox_Task_TAA.Name = "textBox_Task_TAA";
            this.textBox_Task_TAA.ReadOnly = true;
            this.textBox_Task_TAA.Size = new System.Drawing.Size(366, 48);
            this.textBox_Task_TAA.TabIndex = 0;
            this.textBox_Task_TAA.Text = "Написать программу, которая выводит таблицу значений функции на заданном диапазон" +
    "е [-5; 5]:";
            // 
            // groupBox_Input_TAA
            // 
            this.groupBox_Input_TAA.Controls.Add(this.button_About_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.button_Do_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.Textbox_inputend_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.Textbox_Inputstart_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.step_end_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.step_start_TAA);
            this.groupBox_Input_TAA.Location = new System.Drawing.Point(12, 338);
            this.groupBox_Input_TAA.Name = "groupBox_Input_TAA";
            this.groupBox_Input_TAA.Size = new System.Drawing.Size(400, 100);
            this.groupBox_Input_TAA.TabIndex = 2;
            this.groupBox_Input_TAA.TabStop = false;
            this.groupBox_Input_TAA.Text = "Ввод данных";
            // 
            // button_About_TAA
            // 
            this.button_About_TAA.BackColor = System.Drawing.SystemColors.Control;
            this.button_About_TAA.Location = new System.Drawing.Point(240, 19);
            this.button_About_TAA.Name = "button_About_TAA";
            this.button_About_TAA.Size = new System.Drawing.Size(61, 75);
            this.button_About_TAA.TabIndex = 5;
            this.button_About_TAA.Text = "Справка";
            this.button_About_TAA.UseVisualStyleBackColor = false;
            this.button_About_TAA.Click += new System.EventHandler(this.button_About_TAA_Click);
            // 
            // button_Do_TAA
            // 
            this.button_Do_TAA.BackColor = System.Drawing.SystemColors.Control;
            this.button_Do_TAA.Location = new System.Drawing.Point(307, 19);
            this.button_Do_TAA.Name = "button_Do_TAA";
            this.button_Do_TAA.Size = new System.Drawing.Size(87, 75);
            this.button_Do_TAA.TabIndex = 4;
            this.button_Do_TAA.Text = "Выполнить";
            this.button_Do_TAA.UseVisualStyleBackColor = false;
            this.button_Do_TAA.Click += new System.EventHandler(this.button_Do_TAA_Click);
            // 
            // Textbox_inputend_TAA
            // 
            this.Textbox_inputend_TAA.Location = new System.Drawing.Point(134, 47);
            this.Textbox_inputend_TAA.Name = "Textbox_inputend_TAA";
            this.Textbox_inputend_TAA.Size = new System.Drawing.Size(100, 20);
            this.Textbox_inputend_TAA.TabIndex = 3;
            // 
            // Textbox_Inputstart_TAA
            // 
            this.Textbox_Inputstart_TAA.Location = new System.Drawing.Point(28, 47);
            this.Textbox_Inputstart_TAA.Name = "Textbox_Inputstart_TAA";
            this.Textbox_Inputstart_TAA.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Inputstart_TAA.TabIndex = 2;
            // 
            // step_end_TAA
            // 
            this.step_end_TAA.AutoSize = true;
            this.step_end_TAA.Location = new System.Drawing.Point(131, 31);
            this.step_end_TAA.Name = "step_end_TAA";
            this.step_end_TAA.Size = new System.Drawing.Size(66, 13);
            this.step_end_TAA.TabIndex = 1;
            this.step_end_TAA.Text = "Конец шага";
            // 
            // step_start_TAA
            // 
            this.step_start_TAA.AutoSize = true;
            this.step_start_TAA.Location = new System.Drawing.Point(25, 31);
            this.step_start_TAA.Name = "step_start_TAA";
            this.step_start_TAA.Size = new System.Drawing.Size(64, 13);
            this.step_start_TAA.TabIndex = 0;
            this.step_start_TAA.Text = "Старт шага";
            // 
            // groupBox_output_TAA
            // 
            this.groupBox_output_TAA.Controls.Add(this.chart_Function_TAA);
            this.groupBox_output_TAA.Controls.Add(this.dataGridView_out_TAA);
            this.groupBox_output_TAA.Location = new System.Drawing.Point(418, 19);
            this.groupBox_output_TAA.Name = "groupBox_output_TAA";
            this.groupBox_output_TAA.Size = new System.Drawing.Size(599, 419);
            this.groupBox_output_TAA.TabIndex = 3;
            this.groupBox_output_TAA.TabStop = false;
            this.groupBox_output_TAA.Text = "Вывод данных";
            // 
            // chart_Function_TAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Function_TAA.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart_Function_TAA.Legends.Add(legend2);
            this.chart_Function_TAA.Location = new System.Drawing.Point(115, 19);
            this.chart_Function_TAA.Name = "chart_Function_TAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_Function_TAA.Series.Add(series2);
            this.chart_Function_TAA.Size = new System.Drawing.Size(478, 394);
            this.chart_Function_TAA.TabIndex = 1;
            this.chart_Function_TAA.Text = "chart1";
            this.chart_Function_TAA.Click += new System.EventHandler(this.chart_Function_TAA_Click);
            // 
            // dataGridView_out_TAA
            // 
            this.dataGridView_out_TAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_out_TAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView_out_TAA.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_out_TAA.Name = "dataGridView_out_TAA";
            this.dataGridView_out_TAA.RowHeadersVisible = false;
            this.dataGridView_out_TAA.Size = new System.Drawing.Size(103, 394);
            this.dataGridView_out_TAA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 50;
            // 
            // FormMain_TAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.groupBox_output_TAA);
            this.Controls.Add(this.groupBox_Input_TAA);
            this.Controls.Add(this.groupBox_task_TAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_TAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 19 | Титков А. А.";
            this.groupBox_task_TAA.ResumeLayout(false);
            this.groupBox_task_TAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Task_TAA)).EndInit();
            this.groupBox_Input_TAA.ResumeLayout(false);
            this.groupBox_Input_TAA.PerformLayout();
            this.groupBox_output_TAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Function_TAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_out_TAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_task_TAA;
        private System.Windows.Forms.PictureBox pictureBox_Task_TAA;
        private System.Windows.Forms.TextBox textBox_Task_TAA;
        private System.Windows.Forms.GroupBox groupBox_Input_TAA;
        private System.Windows.Forms.Button button_About_TAA;
        private System.Windows.Forms.Button button_Do_TAA;
        private System.Windows.Forms.TextBox Textbox_inputend_TAA;
        private System.Windows.Forms.TextBox Textbox_Inputstart_TAA;
        private System.Windows.Forms.Label step_end_TAA;
        private System.Windows.Forms.Label step_start_TAA;
        private System.Windows.Forms.GroupBox groupBox_output_TAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Function_TAA;
        private System.Windows.Forms.DataGridView dataGridView_out_TAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

