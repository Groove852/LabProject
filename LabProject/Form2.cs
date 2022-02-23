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
    public partial class DisplayCalculation_Form : Form
    { 
        Random random = new Random();

        private int firstNegative;
        private int lastNegative;
        private int upperBorder;
        private int lowerBorder;
        private int sum = 0;

        private int[] array = new int[20];
        private int[] newArr;


        public DisplayCalculation_Form(int upperBorder, int lowerBorder)
        {
            InitializeComponent();
            this.lowerBorder = lowerBorder;
            this.upperBorder = upperBorder;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(lowerBorder, upperBorder);
            }

            //Поиск индекса первого отрицательного числа
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNegative = i;
                    break;
                }
            }

            //Поиск индекса последнего отрицательного числа
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] < 0)
                {
                    lastNegative = i;
                    break;
                }
            }

            newArr = new int[lastNegative - firstNegative - 1];

            for (int i = firstNegative + 1; i < lastNegative; i++)
            {
                sum += array[i];
                newArr[i - firstNegative - 1] = array[i];
            }
        }

        private void DisplayCalculation_Form_Load(object sender, EventArgs e)
        { 
            //
            label1.Text = "Диапазон - ";
            label3.Text = "Эллементы массива - ";
            label5.Text = "Сумма элементов между [" + firstNegative + "] и [" + lastNegative + "] -   ";
            label7.Text = "Сформированный массив - ";

            //
            label2.Text = "от " + lowerBorder + " до " + upperBorder;
            label4.Text = "[ " + string.Join(", ", array) + " ]";
            label6.Text = sum.ToString();
            label8.Text = "[ " + string.Join(", ", newArr) + " ]";
        }

    }
}
