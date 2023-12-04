
namespace Tyuiu.TitkovAA.Sprint6.Task1.V29
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
            this.groupBox_Task_TAA = new System.Windows.Forms.GroupBox();
            this.pictureBox_Function_TAA = new System.Windows.Forms.PictureBox();
            this.Task_textbox_TAA = new System.Windows.Forms.TextBox();
            this.groupBox_Input_TAA = new System.Windows.Forms.GroupBox();
            this.button_About_TAA = new System.Windows.Forms.Button();
            this.button_Do_TAA = new System.Windows.Forms.Button();
            this.Textbox_inputend_TAA = new System.Windows.Forms.TextBox();
            this.Textbox_Inputstart_TAA = new System.Windows.Forms.TextBox();
            this.step_end_TAA = new System.Windows.Forms.Label();
            this.step_start_TAA = new System.Windows.Forms.Label();
            this.Groupbox_output_TAA = new System.Windows.Forms.GroupBox();
            this.textBox_output_TAA = new System.Windows.Forms.TextBox();
            this.label_result_TAA = new System.Windows.Forms.Label();
            this.groupBox_Task_TAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Function_TAA)).BeginInit();
            this.groupBox_Input_TAA.SuspendLayout();
            this.Groupbox_output_TAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Task_TAA
            // 
            this.groupBox_Task_TAA.Controls.Add(this.pictureBox_Function_TAA);
            this.groupBox_Task_TAA.Controls.Add(this.Task_textbox_TAA);
            this.groupBox_Task_TAA.Location = new System.Drawing.Point(19, 29);
            this.groupBox_Task_TAA.Name = "groupBox_Task_TAA";
            this.groupBox_Task_TAA.Size = new System.Drawing.Size(541, 295);
            this.groupBox_Task_TAA.TabIndex = 0;
            this.groupBox_Task_TAA.TabStop = false;
            this.groupBox_Task_TAA.Text = "Условие";
            // 
            // pictureBox_Function_TAA
            // 
            this.pictureBox_Function_TAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Function_TAA.Image")));
            this.pictureBox_Function_TAA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Function_TAA.InitialImage")));
            this.pictureBox_Function_TAA.Location = new System.Drawing.Point(6, 70);
            this.pictureBox_Function_TAA.Name = "pictureBox_Function_TAA";
            this.pictureBox_Function_TAA.Size = new System.Drawing.Size(424, 50);
            this.pictureBox_Function_TAA.TabIndex = 1;
            this.pictureBox_Function_TAA.TabStop = false;
            // 
            // Task_textbox_TAA
            // 
            this.Task_textbox_TAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Task_textbox_TAA.Enabled = false;
            this.Task_textbox_TAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Task_textbox_TAA.Location = new System.Drawing.Point(6, 31);
            this.Task_textbox_TAA.Multiline = true;
            this.Task_textbox_TAA.Name = "Task_textbox_TAA";
            this.Task_textbox_TAA.ReadOnly = true;
            this.Task_textbox_TAA.Size = new System.Drawing.Size(471, 73);
            this.Task_textbox_TAA.TabIndex = 0;
            this.Task_textbox_TAA.Text = "Протабулировать функцию в диапазоне [-5: 5]";
            // 
            // groupBox_Input_TAA
            // 
            this.groupBox_Input_TAA.Controls.Add(this.button_About_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.button_Do_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.Textbox_inputend_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.Textbox_Inputstart_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.step_end_TAA);
            this.groupBox_Input_TAA.Controls.Add(this.step_start_TAA);
            this.groupBox_Input_TAA.Location = new System.Drawing.Point(19, 338);
            this.groupBox_Input_TAA.Name = "groupBox_Input_TAA";
            this.groupBox_Input_TAA.Size = new System.Drawing.Size(541, 100);
            this.groupBox_Input_TAA.TabIndex = 1;
            this.groupBox_Input_TAA.TabStop = false;
            this.groupBox_Input_TAA.Text = "Ввод данных";
            // 
            // button_About_TAA
            // 
            this.button_About_TAA.BackColor = System.Drawing.SystemColors.Control;
            this.button_About_TAA.Location = new System.Drawing.Point(360, 19);
            this.button_About_TAA.Name = "button_About_TAA";
            this.button_About_TAA.Size = new System.Drawing.Size(75, 75);
            this.button_About_TAA.TabIndex = 5;
            this.button_About_TAA.Text = "Справка";
            this.button_About_TAA.UseVisualStyleBackColor = false;
            this.button_About_TAA.Click += new System.EventHandler(this.button_About_TAA_Click);
            // 
            // button_Do_TAA
            // 
            this.button_Do_TAA.BackColor = System.Drawing.SystemColors.Control;
            this.button_Do_TAA.Location = new System.Drawing.Point(441, 19);
            this.button_Do_TAA.Name = "button_Do_TAA";
            this.button_Do_TAA.Size = new System.Drawing.Size(94, 75);
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
            // Groupbox_output_TAA
            // 
            this.Groupbox_output_TAA.Controls.Add(this.textBox_output_TAA);
            this.Groupbox_output_TAA.Controls.Add(this.label_result_TAA);
            this.Groupbox_output_TAA.Location = new System.Drawing.Point(566, 29);
            this.Groupbox_output_TAA.Name = "Groupbox_output_TAA";
            this.Groupbox_output_TAA.Size = new System.Drawing.Size(222, 409);
            this.Groupbox_output_TAA.TabIndex = 2;
            this.Groupbox_output_TAA.TabStop = false;
            this.Groupbox_output_TAA.Text = "Вывод данных";
            // 
            // textBox_output_TAA
            // 
            this.textBox_output_TAA.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_output_TAA.Location = new System.Drawing.Point(9, 31);
            this.textBox_output_TAA.Multiline = true;
            this.textBox_output_TAA.Name = "textBox_output_TAA";
            this.textBox_output_TAA.ReadOnly = true;
            this.textBox_output_TAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output_TAA.Size = new System.Drawing.Size(207, 372);
            this.textBox_output_TAA.TabIndex = 1;
            // 
            // label_result_TAA
            // 
            this.label_result_TAA.AutoSize = true;
            this.label_result_TAA.Location = new System.Drawing.Point(6, 16);
            this.label_result_TAA.Name = "label_result_TAA";
            this.label_result_TAA.Size = new System.Drawing.Size(62, 13);
            this.label_result_TAA.TabIndex = 0;
            this.label_result_TAA.Text = "Результат:";
            // 
            // FormMain_TAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Groupbox_output_TAA);
            this.Controls.Add(this.groupBox_Input_TAA);
            this.Controls.Add(this.groupBox_Task_TAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_TAA";
            this.Text = "Спринт 6 | Таск1 | Вариант 29 | Титков А. А.";
            this.groupBox_Task_TAA.ResumeLayout(false);
            this.groupBox_Task_TAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Function_TAA)).EndInit();
            this.groupBox_Input_TAA.ResumeLayout(false);
            this.groupBox_Input_TAA.PerformLayout();
            this.Groupbox_output_TAA.ResumeLayout(false);
            this.Groupbox_output_TAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Task_TAA;
        private System.Windows.Forms.TextBox Task_textbox_TAA;
        private System.Windows.Forms.GroupBox groupBox_Input_TAA;
        private System.Windows.Forms.Label step_end_TAA;
        private System.Windows.Forms.Label step_start_TAA;
        private System.Windows.Forms.TextBox Textbox_inputend_TAA;
        private System.Windows.Forms.TextBox Textbox_Inputstart_TAA;
        private System.Windows.Forms.PictureBox pictureBox_Function_TAA;
        private System.Windows.Forms.GroupBox Groupbox_output_TAA;
        private System.Windows.Forms.TextBox textBox_output_TAA;
        private System.Windows.Forms.Label label_result_TAA;
        private System.Windows.Forms.Button button_About_TAA;
        private System.Windows.Forms.Button button_Do_TAA;
    }
}

