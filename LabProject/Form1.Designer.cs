namespace LabProject
{
    partial class TaskSelection_Form
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Calculation_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Lower = new System.Windows.Forms.TextBox();
            this.textBox_Upper = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Без выбора",
            "Выбрать"});
            this.comboBox1.Location = new System.Drawing.Point(187, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Choice_Selection);
            // 
            // Calculation_button
            // 
            this.Calculation_button.Location = new System.Drawing.Point(202, 226);
            this.Calculation_button.Name = "Calculation_button";
            this.Calculation_button.Size = new System.Drawing.Size(87, 23);
            this.Calculation_button.TabIndex = 1;
            this.Calculation_button.Text = "Просчитать";
            this.Calculation_button.UseVisualStyleBackColor = true;
            this.Calculation_button.Click += new System.EventHandler(this.Calculation_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Диапазон";
            // 
            // textBox_Lower
            // 
            this.textBox_Lower.Location = new System.Drawing.Point(205, 143);
            this.textBox_Lower.Name = "textBox_Lower";
            this.textBox_Lower.Size = new System.Drawing.Size(80, 20);
            this.textBox_Lower.TabIndex = 3;
            this.textBox_Lower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Lower.Visible = false;
            // 
            // textBox_Upper
            // 
            this.textBox_Upper.Location = new System.Drawing.Point(205, 186);
            this.textBox_Upper.Name = "textBox_Upper";
            this.textBox_Upper.Size = new System.Drawing.Size(80, 20);
            this.textBox_Upper.TabIndex = 4;
            this.textBox_Upper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Upper.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(202, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Нижняя граница";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(199, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Верхняя граница";
            this.label3.Visible = false;
            // 
            // TaskSelection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Upper);
            this.Controls.Add(this.textBox_Lower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculation_button);
            this.Controls.Add(this.comboBox1);
            this.Name = "TaskSelection_Form";
            this.Text = "Задание 1 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Calculation_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Lower;
        private System.Windows.Forms.TextBox textBox_Upper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

