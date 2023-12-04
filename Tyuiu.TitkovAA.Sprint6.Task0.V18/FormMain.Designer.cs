
namespace Tyuiu.TitkovAA.Sprint6.Task0.V18
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
            this.Task_Requirements_TAA = new System.Windows.Forms.GroupBox();
            this.Text_TaskReq_TAA = new System.Windows.Forms.TextBox();
            this.Picture_Task_Formula_TAA = new System.Windows.Forms.PictureBox();
            this.OutputBox_TAA = new System.Windows.Forms.GroupBox();
            this.button_calculate_TAA = new System.Windows.Forms.Button();
            this.Text_Output_TAA = new System.Windows.Forms.TextBox();
            this.InputBox_TAA = new System.Windows.Forms.GroupBox();
            this.Text_Input_x_TAA = new System.Windows.Forms.TextBox();
            this.xEquals_TAA = new System.Windows.Forms.Label();
            this.Questionmarkbutton_TAA = new System.Windows.Forms.Button();
            this.Task_Requirements_TAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Task_Formula_TAA)).BeginInit();
            this.OutputBox_TAA.SuspendLayout();
            this.InputBox_TAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // Task_Requirements_TAA
            // 
            this.Task_Requirements_TAA.Controls.Add(this.Questionmarkbutton_TAA);
            this.Task_Requirements_TAA.Controls.Add(this.Text_TaskReq_TAA);
            this.Task_Requirements_TAA.Controls.Add(this.Picture_Task_Formula_TAA);
            this.Task_Requirements_TAA.Location = new System.Drawing.Point(12, 12);
            this.Task_Requirements_TAA.Name = "Task_Requirements_TAA";
            this.Task_Requirements_TAA.Size = new System.Drawing.Size(776, 276);
            this.Task_Requirements_TAA.TabIndex = 0;
            this.Task_Requirements_TAA.TabStop = false;
            this.Task_Requirements_TAA.Text = "Задание";
            this.Task_Requirements_TAA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Text_TaskReq_TAA
            // 
            this.Text_TaskReq_TAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_TaskReq_TAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Text_TaskReq_TAA.Location = new System.Drawing.Point(6, 39);
            this.Text_TaskReq_TAA.Multiline = true;
            this.Text_TaskReq_TAA.Name = "Text_TaskReq_TAA";
            this.Text_TaskReq_TAA.ReadOnly = true;
            this.Text_TaskReq_TAA.Size = new System.Drawing.Size(526, 50);
            this.Text_TaskReq_TAA.TabIndex = 1;
            this.Text_TaskReq_TAA.Text = "Вычислить значение выражения при x = 3, округлить до 3 знаков после запятой";
            // 
            // Picture_Task_Formula_TAA
            // 
            this.Picture_Task_Formula_TAA.ImageLocation = "C:\\Users\\vipta\\source\\repos\\Tyuiu.TitkovAA.Sprint6\\3323.png";
            this.Picture_Task_Formula_TAA.InitialImage = ((System.Drawing.Image)(resources.GetObject("Picture_Task_Formula_TAA.InitialImage")));
            this.Picture_Task_Formula_TAA.Location = new System.Drawing.Point(653, 68);
            this.Picture_Task_Formula_TAA.Name = "Picture_Task_Formula_TAA";
            this.Picture_Task_Formula_TAA.Size = new System.Drawing.Size(117, 72);
            this.Picture_Task_Formula_TAA.TabIndex = 0;
            this.Picture_Task_Formula_TAA.TabStop = false;
            // 
            // OutputBox_TAA
            // 
            this.OutputBox_TAA.Controls.Add(this.button_calculate_TAA);
            this.OutputBox_TAA.Controls.Add(this.Text_Output_TAA);
            this.OutputBox_TAA.Location = new System.Drawing.Point(385, 303);
            this.OutputBox_TAA.Name = "OutputBox_TAA";
            this.OutputBox_TAA.Size = new System.Drawing.Size(403, 113);
            this.OutputBox_TAA.TabIndex = 1;
            this.OutputBox_TAA.TabStop = false;
            this.OutputBox_TAA.Text = "Вывод данных";
            this.OutputBox_TAA.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_calculate_TAA
            // 
            this.button_calculate_TAA.Location = new System.Drawing.Point(257, 39);
            this.button_calculate_TAA.Name = "button_calculate_TAA";
            this.button_calculate_TAA.Size = new System.Drawing.Size(75, 23);
            this.button_calculate_TAA.TabIndex = 1;
            this.button_calculate_TAA.Text = "Вычислить";
            this.button_calculate_TAA.UseVisualStyleBackColor = true;
            this.button_calculate_TAA.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // Text_Output_TAA
            // 
            this.Text_Output_TAA.Location = new System.Drawing.Point(6, 44);
            this.Text_Output_TAA.Name = "Text_Output_TAA";
            this.Text_Output_TAA.ReadOnly = true;
            this.Text_Output_TAA.Size = new System.Drawing.Size(214, 20);
            this.Text_Output_TAA.TabIndex = 0;
            this.Text_Output_TAA.TextChanged += new System.EventHandler(this.Text_Output_TextChanged);
            // 
            // InputBox_TAA
            // 
            this.InputBox_TAA.Controls.Add(this.Text_Input_x_TAA);
            this.InputBox_TAA.Controls.Add(this.xEquals_TAA);
            this.InputBox_TAA.Location = new System.Drawing.Point(12, 303);
            this.InputBox_TAA.Name = "InputBox_TAA";
            this.InputBox_TAA.Size = new System.Drawing.Size(367, 113);
            this.InputBox_TAA.TabIndex = 2;
            this.InputBox_TAA.TabStop = false;
            this.InputBox_TAA.Text = "Ввод данных";
            this.InputBox_TAA.Enter += new System.EventHandler(this.InputBox_Enter);
            // 
            // Text_Input_x_TAA
            // 
            this.Text_Input_x_TAA.Location = new System.Drawing.Point(30, 44);
            this.Text_Input_x_TAA.Name = "Text_Input_x_TAA";
            this.Text_Input_x_TAA.Size = new System.Drawing.Size(186, 20);
            this.Text_Input_x_TAA.TabIndex = 1;
            this.Text_Input_x_TAA.TextChanged += new System.EventHandler(this.Text_Input_TextChanged);
            // 
            // xEquals_TAA
            // 
            this.xEquals_TAA.AutoSize = true;
            this.xEquals_TAA.Location = new System.Drawing.Point(6, 47);
            this.xEquals_TAA.Name = "xEquals_TAA";
            this.xEquals_TAA.Size = new System.Drawing.Size(18, 13);
            this.xEquals_TAA.TabIndex = 0;
            this.xEquals_TAA.Text = "x=";
            // 
            // Questionmarkbutton_TAA
            // 
            this.Questionmarkbutton_TAA.Location = new System.Drawing.Point(714, 19);
            this.Questionmarkbutton_TAA.Name = "Questionmarkbutton_TAA";
            this.Questionmarkbutton_TAA.Size = new System.Drawing.Size(35, 35);
            this.Questionmarkbutton_TAA.TabIndex = 2;
            this.Questionmarkbutton_TAA.Text = "?";
            this.Questionmarkbutton_TAA.UseVisualStyleBackColor = true;
            this.Questionmarkbutton_TAA.Click += new System.EventHandler(this.Questionmarkbutton_TAA_Click);
            // 
            // FormMain_TAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputBox_TAA);
            this.Controls.Add(this.OutputBox_TAA);
            this.Controls.Add(this.Task_Requirements_TAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain_TAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск0 | Вариант 18 | Титков А. А.";
            this.Task_Requirements_TAA.ResumeLayout(false);
            this.Task_Requirements_TAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Task_Formula_TAA)).EndInit();
            this.OutputBox_TAA.ResumeLayout(false);
            this.OutputBox_TAA.PerformLayout();
            this.InputBox_TAA.ResumeLayout(false);
            this.InputBox_TAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Task_Requirements_TAA;
        private System.Windows.Forms.PictureBox Picture_Task_Formula_TAA;
        private System.Windows.Forms.GroupBox OutputBox_TAA;
        private System.Windows.Forms.GroupBox InputBox_TAA;
        private System.Windows.Forms.TextBox Text_TaskReq_TAA;
        private System.Windows.Forms.Button button_calculate_TAA;
        private System.Windows.Forms.TextBox Text_Output_TAA;
        private System.Windows.Forms.TextBox Text_Input_x_TAA;
        private System.Windows.Forms.Label xEquals_TAA;
        private System.Windows.Forms.Button Questionmarkbutton_TAA;
    }
}

