
namespace lab3_TP_Git
{
    partial class Form1
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
            this.groupBoxRun = new System.Windows.Forms.GroupBox();
            this.WeekendDistance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRun = new System.Windows.Forms.ListBox();
            this.ButtonOpenFIleRun = new System.Windows.Forms.Button();
            this.btnChooseTemp = new System.Windows.Forms.Button();
            this.bthChooseRun = new System.Windows.Forms.Button();
            this.groupBoxTemp = new System.Windows.Forms.GroupBox();
            this.listBoxTemp = new System.Windows.Forms.ListBox();
            this.ChangeTemp = new System.Windows.Forms.Label();
            this.buttonOpenFileTemp = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxRun.SuspendLayout();
            this.groupBoxTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRun
            // 
            this.groupBoxRun.Controls.Add(this.WeekendDistance);
            this.groupBoxRun.Controls.Add(this.label2);
            this.groupBoxRun.Controls.Add(this.listBoxRun);
            this.groupBoxRun.Controls.Add(this.ButtonOpenFIleRun);
            this.groupBoxRun.Location = new System.Drawing.Point(10, 66);
            this.groupBoxRun.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRun.Name = "groupBoxRun";
            this.groupBoxRun.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRun.Size = new System.Drawing.Size(842, 301);
            this.groupBoxRun.TabIndex = 9;
            this.groupBoxRun.TabStop = false;
            this.groupBoxRun.Visible = false;
            // 
            // WeekendDistance
            // 
            this.WeekendDistance.AutoSize = true;
            this.WeekendDistance.Location = new System.Drawing.Point(387, 267);
            this.WeekendDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeekendDistance.Name = "WeekendDistance";
            this.WeekendDistance.Size = new System.Drawing.Size(21, 13);
            this.WeekendDistance.TabIndex = 8;
            this.WeekendDistance.Text = "км";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "За выходные дни пройдено: ";
            // 
            // listBoxRun
            // 
            this.listBoxRun.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRun.FormattingEnabled = true;
            this.listBoxRun.HorizontalScrollbar = true;
            this.listBoxRun.ItemHeight = 19;
            this.listBoxRun.Location = new System.Drawing.Point(8, 61);
            this.listBoxRun.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxRun.Name = "listBoxRun";
            this.listBoxRun.ScrollAlwaysVisible = true;
            this.listBoxRun.Size = new System.Drawing.Size(823, 194);
            this.listBoxRun.TabIndex = 5;
            // 
            // ButtonOpenFIleRun
            // 
            this.ButtonOpenFIleRun.BackColor = System.Drawing.Color.Teal;
            this.ButtonOpenFIleRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOpenFIleRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonOpenFIleRun.Location = new System.Drawing.Point(348, 17);
            this.ButtonOpenFIleRun.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonOpenFIleRun.Name = "ButtonOpenFIleRun";
            this.ButtonOpenFIleRun.Size = new System.Drawing.Size(126, 39);
            this.ButtonOpenFIleRun.TabIndex = 4;
            this.ButtonOpenFIleRun.Text = "Открыть файл";
            this.ButtonOpenFIleRun.UseVisualStyleBackColor = false;
            // 
            // btnChooseTemp
            // 
            this.btnChooseTemp.AutoEllipsis = true;
            this.btnChooseTemp.BackColor = System.Drawing.Color.Teal;
            this.btnChooseTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChooseTemp.Location = new System.Drawing.Point(247, 11);
            this.btnChooseTemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseTemp.Name = "btnChooseTemp";
            this.btnChooseTemp.Size = new System.Drawing.Size(155, 42);
            this.btnChooseTemp.TabIndex = 8;
            this.btnChooseTemp.Text = "Работать с данными о температуре";
            this.btnChooseTemp.UseVisualStyleBackColor = false;
            // 
            // bthChooseRun
            // 
            this.bthChooseRun.AutoEllipsis = true;
            this.bthChooseRun.BackColor = System.Drawing.Color.Teal;
            this.bthChooseRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bthChooseRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bthChooseRun.Location = new System.Drawing.Point(427, 11);
            this.bthChooseRun.Margin = new System.Windows.Forms.Padding(2);
            this.bthChooseRun.Name = "bthChooseRun";
            this.bthChooseRun.Size = new System.Drawing.Size(155, 42);
            this.bthChooseRun.TabIndex = 7;
            this.bthChooseRun.Text = "Работать с данными о пробежках";
            this.bthChooseRun.UseVisualStyleBackColor = false;
            // 
            // groupBoxTemp
            // 
            this.groupBoxTemp.Controls.Add(this.listBoxTemp);
            this.groupBoxTemp.Controls.Add(this.ChangeTemp);
            this.groupBoxTemp.Controls.Add(this.buttonOpenFileTemp);
            this.groupBoxTemp.Location = new System.Drawing.Point(9, 66);
            this.groupBoxTemp.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTemp.Name = "groupBoxTemp";
            this.groupBoxTemp.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTemp.Size = new System.Drawing.Size(842, 301);
            this.groupBoxTemp.TabIndex = 11;
            this.groupBoxTemp.TabStop = false;
            this.groupBoxTemp.Visible = false;
            // 
            // listBoxTemp
            // 
            this.listBoxTemp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTemp.FormattingEnabled = true;
            this.listBoxTemp.HorizontalScrollbar = true;
            this.listBoxTemp.ItemHeight = 19;
            this.listBoxTemp.Location = new System.Drawing.Point(18, 60);
            this.listBoxTemp.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTemp.Name = "listBoxTemp";
            this.listBoxTemp.Size = new System.Drawing.Size(811, 194);
            this.listBoxTemp.TabIndex = 9;
            // 
            // ChangeTemp
            // 
            this.ChangeTemp.AutoSize = true;
            this.ChangeTemp.Location = new System.Drawing.Point(235, 267);
            this.ChangeTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChangeTemp.Name = "ChangeTemp";
            this.ChangeTemp.Size = new System.Drawing.Size(54, 13);
            this.ChangeTemp.TabIndex = 8;
            this.ChangeTemp.Text = "Перепад:";
            // 
            // buttonOpenFileTemp
            // 
            this.buttonOpenFileTemp.BackColor = System.Drawing.Color.Teal;
            this.buttonOpenFileTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFileTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFileTemp.Location = new System.Drawing.Point(340, 17);
            this.buttonOpenFileTemp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFileTemp.Name = "buttonOpenFileTemp";
            this.buttonOpenFileTemp.Size = new System.Drawing.Size(126, 39);
            this.buttonOpenFileTemp.TabIndex = 4;
            this.buttonOpenFileTemp.Text = "Открыть файл";
            this.buttonOpenFileTemp.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Azure;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(226, 381);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(393, 177);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(868, 574);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBoxRun);
            this.Controls.Add(this.btnChooseTemp);
            this.Controls.Add(this.bthChooseRun);
            this.Controls.Add(this.groupBoxTemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRun.ResumeLayout(false);
            this.groupBoxRun.PerformLayout();
            this.groupBoxTemp.ResumeLayout(false);
            this.groupBoxTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRun;
        private System.Windows.Forms.Label WeekendDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRun;
        private System.Windows.Forms.Button ButtonOpenFIleRun;
        private System.Windows.Forms.Button btnChooseTemp;
        private System.Windows.Forms.Button bthChooseRun;
        private System.Windows.Forms.GroupBox groupBoxTemp;
        private System.Windows.Forms.ListBox listBoxTemp;
        private System.Windows.Forms.Label ChangeTemp;
        private System.Windows.Forms.Button buttonOpenFileTemp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

