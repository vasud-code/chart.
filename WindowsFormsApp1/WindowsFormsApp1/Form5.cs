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
    public partial class Пончик_Form5 : Form
    {
        public Пончик_Form5()
        {
            InitializeComponent();
        }

        private void BUTTON_ADD_Click(object sender, EventArgs e)
        {
          
            chart4.Series[0].Points.AddXY(Convert.ToString(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }
    }
}
