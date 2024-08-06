using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Полосы_Form3 : Form
    {
        public Полосы_Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BUTTON_ADD_WINFORM3_Click(object sender, EventArgs e)
        {
            chart2.Series[0].Points.AddXY(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }
    }
}
