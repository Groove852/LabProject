using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public partial class TaskSelection_Form : Form
    {
        private string SelectedCells;

        private int upperBorder;
        private int lowerBorder;


        //Конструктор класса TaskSelection_Form
        public TaskSelection_Form()
        {
            InitializeComponent();
        }

        //Выбор значения диапазонов
        private void Choice_Selection(object sender, EventArgs e)
        {  
            SelectedCells = comboBox1.SelectedItem.ToString();

            if(SelectedCells == "Без выбора")
            {
                label2.Visible = false;
                label3.Visible = false;
                textBox_Lower.Visible = false;
                textBox_Upper.Visible = false;
            }
            if(SelectedCells == "Выбрать")
            {
                label2.Visible = true;
                label3.Visible = true;
                textBox_Lower.Visible = true;
                textBox_Upper.Visible = true;
            }
        }

        //Получение данных для создания 
        private void Calculation_button_Click(object sender, EventArgs e)
        {
            if (SelectedCells == "Без выбора")
            {
                upperBorder = 10;
                lowerBorder = -3;
            }
            if (SelectedCells == "Выбрать")
            {
                try { 
                    upperBorder = int.Parse(textBox_Upper.Text.ToString());
                    lowerBorder = int.Parse(textBox_Lower.Text.ToString());
                }
                catch
                {
                    MessageBox.Show("Вы должны указать значение", "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            //Проверки на ошибки пользователя
            if (upperBorder < lowerBorder)
            {
                MessageBox.Show("Нижняя граница не может быть больше верхней", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if ((SelectedCells != "Без выбора") && (SelectedCells != "Выбрать"))
            {
                MessageBox.Show("Вы не выбрали диапазон", "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DisplayCalculation_Form displayCalculation_Form = new DisplayCalculation_Form(upperBorder, lowerBorder);
                displayCalculation_Form.Show();
            }
        }

    }
}
