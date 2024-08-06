using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Области_FORM4 : Form
    {
        public Области_FORM4()
        {
            InitializeComponent();
        }

        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            chart3.Series[0].Points.AddXY(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }
    }
}
