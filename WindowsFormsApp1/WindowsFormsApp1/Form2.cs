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
    public partial class Колонны_Form2 : Form
    {
        public Колонны_Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_ADD_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(Convert.ToDouble(textBox1.Text),Convert.ToDouble(textBox2.Text));
        }
    }
}
