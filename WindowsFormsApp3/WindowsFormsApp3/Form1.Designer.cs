namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timeMosckow = new System.Windows.Forms.Label();
            this.timeLondon = new System.Windows.Forms.Label();
            this.timeTokio = new System.Windows.Forms.Label();
            this.timeNewYork = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "МОСКВА";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(3, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 89);
            this.label2.TabIndex = 1;
            this.label2.Text = "НЬЮ-ЙОРК";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 89);
            this.label3.TabIndex = 2;
            this.label3.Text = "ЛОНДОН";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Location = new System.Drawing.Point(3, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 89);
            this.label4.TabIndex = 3;
            this.label4.Text = "ТОКИО";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.68225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.31775F));
            this.tableLayoutPanel1.Controls.Add(this.timeMosckow, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.timeLondon, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.timeTokio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.timeNewYork, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 356);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // timeMosckow
            // 
            this.timeMosckow.AutoSize = true;
            this.timeMosckow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeMosckow.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMosckow.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.timeMosckow.Location = new System.Drawing.Point(367, 0);
            this.timeMosckow.Name = "timeMosckow";
            this.timeMosckow.Size = new System.Drawing.Size(571, 89);
            this.timeMosckow.TabIndex = 5;
            this.timeMosckow.Text = "МОСКВА";
            this.timeMosckow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLondon
            // 
            this.timeLondon.AutoSize = true;
            this.timeLondon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLondon.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLondon.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.timeLondon.Location = new System.Drawing.Point(367, 89);
            this.timeLondon.Name = "timeLondon";
            this.timeLondon.Size = new System.Drawing.Size(571, 89);
            this.timeLondon.TabIndex = 7;
            this.timeLondon.Text = "МОСКВА";
            this.timeLondon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeTokio
            // 
            this.timeTokio.AutoSize = true;
            this.timeTokio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTokio.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTokio.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.timeTokio.Location = new System.Drawing.Point(367, 178);
            this.timeTokio.Name = "timeTokio";
            this.timeTokio.Size = new System.Drawing.Size(571, 89);
            this.timeTokio.TabIndex = 6;
            this.timeTokio.Text = "МОСКВА";
            this.timeTokio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeNewYork
            // 
            this.timeNewYork.AutoSize = true;
            this.timeNewYork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeNewYork.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeNewYork.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.timeNewYork.Location = new System.Drawing.Point(367, 267);
            this.timeNewYork.Name = "timeNewYork";
            this.timeNewYork.Size = new System.Drawing.Size(571, 89);
            this.timeNewYork.TabIndex = 4;
            this.timeNewYork.Text = "МОСКВА";
            this.timeNewYork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(941, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label timeMosckow;
        private System.Windows.Forms.Label timeLondon;
        private System.Windows.Forms.Label timeTokio;
        private System.Windows.Forms.Label timeNewYork;
        private System.Windows.Forms.Timer timer1;
    }
}

