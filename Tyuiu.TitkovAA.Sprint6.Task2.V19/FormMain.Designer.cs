
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
            this.groupBox_task_TAA = new System.Windows.Forms.GroupBox();
            this.textBox_Task_TAA = new System.Windows.Forms.TextBox();
            this.pictureBox_Task_TAA = new System.Windows.Forms.PictureBox();
            this.groupBox_Input_TAA = new System.Windows.Forms.GroupBox();
            this.button_About_TAA = new System.Windows.Forms.Button();
            this.button_Do_TAA = new System.Windows.Forms.Button();
            this.Textbox_inputend_TAA = new System.Windows.Forms.TextBox();
            this.Textbox_Inputstart_TAA = new System.Windows.Forms.TextBox();
            this.step_end_TAA = new System.Windows.Forms.Label();
            this.step_start_TAA = new System.Windows.Forms.Label();
            this.groupBox_output_TAA = new System.Windows.Forms.GroupBox();
            this.groupBox_task_TAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Task_TAA)).BeginInit();
            this.groupBox_Input_TAA.SuspendLayout();
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
            // textBox_Task_TAA
            // 
            this.textBox_Task_TAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            // pictureBox_Task_TAA
            // 
            this.pictureBox_Task_TAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Task_TAA.Image")));
            this.pictureBox_Task_TAA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Task_TAA.InitialImage")));
            this.pictureBox_Task_TAA.Location = new System.Drawing.Point(17, 85);
            this.pictureBox_Task_TAA.Name = "pictureBox_Task_TAA";
            this.pictureBox_Task_TAA.Size = new System.Drawing.Size(311, 52);
            this.pictureBox_Task_TAA.TabIndex = 1;
            this.pictureBox_Task_TAA.TabStop = false;
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
            this.groupBox_output_TAA.Location = new System.Drawing.Point(418, 19);
            this.groupBox_output_TAA.Name = "groupBox_output_TAA";
            this.groupBox_output_TAA.Size = new System.Drawing.Size(599, 419);
            this.groupBox_output_TAA.TabIndex = 3;
            this.groupBox_output_TAA.TabStop = false;
            this.groupBox_output_TAA.Text = "Вывод данных";
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
            this.Text = "Спринт 6 | Таск 2 | Париант 19 | Титков А. А.";
            this.groupBox_task_TAA.ResumeLayout(false);
            this.groupBox_task_TAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Task_TAA)).EndInit();
            this.groupBox_Input_TAA.ResumeLayout(false);
            this.groupBox_Input_TAA.PerformLayout();
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
    }
}

