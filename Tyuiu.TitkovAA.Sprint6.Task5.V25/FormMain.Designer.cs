
namespace Tyuiu.TitkovAA.Sprint6.Task5.V25
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.paneltop_TAA = new System.Windows.Forms.Panel();
            this.groupBoxTAsk_TAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_TAA = new System.Windows.Forms.TextBox();
            this.buttonAbout_TAA = new System.Windows.Forms.Button();
            this.buttonOpen_TAA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelright_TAA = new System.Windows.Forms.Panel();
            this.panelleft_TAA = new System.Windows.Forms.Panel();
            this.groupBoxOutput_TAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_TAA = new System.Windows.Forms.DataGridView();
            this.chartResult_TAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltop_TAA.SuspendLayout();
            this.groupBoxTAsk_TAA.SuspendLayout();
            this.panelright_TAA.SuspendLayout();
            this.panelleft_TAA.SuspendLayout();
            this.groupBoxOutput_TAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_TAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_TAA)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop_TAA
            // 
            this.paneltop_TAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.paneltop_TAA.Controls.Add(this.groupBoxTAsk_TAA);
            this.paneltop_TAA.Controls.Add(this.buttonAbout_TAA);
            this.paneltop_TAA.Controls.Add(this.buttonOpen_TAA);
            this.paneltop_TAA.Controls.Add(this.button2);
            this.paneltop_TAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop_TAA.Location = new System.Drawing.Point(0, 0);
            this.paneltop_TAA.Name = "paneltop_TAA";
            this.paneltop_TAA.Size = new System.Drawing.Size(1032, 100);
            this.paneltop_TAA.TabIndex = 2;
            // 
            // groupBoxTAsk_TAA
            // 
            this.groupBoxTAsk_TAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxTAsk_TAA.Controls.Add(this.textBoxTask_TAA);
            this.groupBoxTAsk_TAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTAsk_TAA.Name = "groupBoxTAsk_TAA";
            this.groupBoxTAsk_TAA.Size = new System.Drawing.Size(537, 72);
            this.groupBoxTAsk_TAA.TabIndex = 0;
            this.groupBoxTAsk_TAA.TabStop = false;
            this.groupBoxTAsk_TAA.Text = "Условие:";
            // 
            // textBoxTask_TAA
            // 
            this.textBoxTask_TAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxTask_TAA.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxTask_TAA.Location = new System.Drawing.Point(6, 16);
            this.textBoxTask_TAA.Multiline = true;
            this.textBoxTask_TAA.Name = "textBoxTask_TAA";
            this.textBoxTask_TAA.ReadOnly = true;
            this.textBoxTask_TAA.Size = new System.Drawing.Size(525, 50);
            this.textBoxTask_TAA.TabIndex = 0;
            this.textBoxTask_TAA.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в dataGridView. Дан спис" +
    "ок из чисел. Вывести все числа, не равные 0. Построить диаграмму по этим значени" +
    "ям.";
            // 
            // buttonAbout_TAA
            // 
            this.buttonAbout_TAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout_TAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAbout_TAA.Location = new System.Drawing.Point(774, 6);
            this.buttonAbout_TAA.Name = "buttonAbout_TAA";
            this.buttonAbout_TAA.Size = new System.Drawing.Size(106, 72);
            this.buttonAbout_TAA.TabIndex = 4;
            this.buttonAbout_TAA.Text = "Справка";
            this.buttonAbout_TAA.UseVisualStyleBackColor = false;
            this.buttonAbout_TAA.Click += new System.EventHandler(this.buttonAbout_TAA_Click);
            // 
            // buttonOpen_TAA
            // 
            this.buttonOpen_TAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_TAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOpen_TAA.Location = new System.Drawing.Point(667, 6);
            this.buttonOpen_TAA.Name = "buttonOpen_TAA";
            this.buttonOpen_TAA.Size = new System.Drawing.Size(101, 72);
            this.buttonOpen_TAA.TabIndex = 3;
            this.buttonOpen_TAA.Text = "Открыть Файл";
            this.buttonOpen_TAA.UseVisualStyleBackColor = false;
            this.buttonOpen_TAA.Click += new System.EventHandler(this.buttonOpen_TAA_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(555, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 72);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelright_TAA
            // 
            this.panelright_TAA.BackColor = System.Drawing.SystemColors.Info;
            this.panelright_TAA.Controls.Add(this.chartResult_TAA);
            this.panelright_TAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelright_TAA.Location = new System.Drawing.Point(195, 100);
            this.panelright_TAA.Name = "panelright_TAA";
            this.panelright_TAA.Size = new System.Drawing.Size(837, 401);
            this.panelright_TAA.TabIndex = 5;
            // 
            // panelleft_TAA
            // 
            this.panelleft_TAA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelleft_TAA.Controls.Add(this.groupBoxOutput_TAA);
            this.panelleft_TAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft_TAA.Location = new System.Drawing.Point(0, 100);
            this.panelleft_TAA.Name = "panelleft_TAA";
            this.panelleft_TAA.Size = new System.Drawing.Size(195, 401);
            this.panelleft_TAA.TabIndex = 4;
            // 
            // groupBoxOutput_TAA
            // 
            this.groupBoxOutput_TAA.Controls.Add(this.dataGridViewResult_TAA);
            this.groupBoxOutput_TAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_TAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_TAA.Name = "groupBoxOutput_TAA";
            this.groupBoxOutput_TAA.Size = new System.Drawing.Size(195, 401);
            this.groupBoxOutput_TAA.TabIndex = 0;
            this.groupBoxOutput_TAA.TabStop = false;
            this.groupBoxOutput_TAA.Text = "Вывод:";
            // 
            // dataGridViewResult_TAA
            // 
            this.dataGridViewResult_TAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_TAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewResult_TAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_TAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_TAA.Name = "dataGridViewResult_TAA";
            this.dataGridViewResult_TAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_TAA.Size = new System.Drawing.Size(189, 382);
            this.dataGridViewResult_TAA.TabIndex = 0;
            this.dataGridViewResult_TAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_TAA_CellContentClick);
            // 
            // chartResult_TAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_TAA.ChartAreas.Add(chartArea1);
            this.chartResult_TAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartResult_TAA.Legends.Add(legend1);
            this.chartResult_TAA.Location = new System.Drawing.Point(0, 0);
            this.chartResult_TAA.Name = "chartResult_TAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_TAA.Series.Add(series1);
            this.chartResult_TAA.Size = new System.Drawing.Size(837, 401);
            this.chartResult_TAA.TabIndex = 0;
            this.chartResult_TAA.Text = "chartResult";
            // 
            // Column1
            // 
            this.Column1.HeaderText = " ";
            this.Column1.Name = "Column1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 501);
            this.Controls.Add(this.panelright_TAA);
            this.Controls.Add(this.panelleft_TAA);
            this.Controls.Add(this.paneltop_TAA);
            this.MinimumSize = new System.Drawing.Size(1048, 540);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.paneltop_TAA.ResumeLayout(false);
            this.groupBoxTAsk_TAA.ResumeLayout(false);
            this.groupBoxTAsk_TAA.PerformLayout();
            this.panelright_TAA.ResumeLayout(false);
            this.panelleft_TAA.ResumeLayout(false);
            this.groupBoxOutput_TAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_TAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_TAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop_TAA;
        private System.Windows.Forms.GroupBox groupBoxTAsk_TAA;
        private System.Windows.Forms.TextBox textBoxTask_TAA;
        private System.Windows.Forms.Button buttonAbout_TAA;
        private System.Windows.Forms.Button buttonOpen_TAA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelright_TAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_TAA;
        private System.Windows.Forms.Panel panelleft_TAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_TAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_TAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

