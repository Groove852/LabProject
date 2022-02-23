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
        int upperBorder;
        int lowerBorder;
        int[] array = new int[20];
        Random random = new Random(); 

        public DisplayCalculation_Form(int upperBorder, int lowerBorder)
        {
            InitializeComponent();
            this.upperBorder = upperBorder;
            this.lowerBorder = lowerBorder;
        }

        private void DisplayCalculation_Form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(lowerBorder, upperBorder);
            }
            label3.Text = "от " + lowerBorder + " до " + upperBorder;
            label4.Text = "[ " + string.Join(", ", array) + " ]";

        }

    }
}
