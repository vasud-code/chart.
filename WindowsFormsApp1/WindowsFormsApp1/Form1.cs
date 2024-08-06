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

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Колонны_Main_Click(object sender, EventArgs e)
        {
     
        }

        private void Полосы_Main_Click(object sender, EventArgs e)
        {

        }

        private void Области_Main_Click(object sender, EventArgs e)
        {

        }

        private void Пончик_Main_Click(object sender, EventArgs e)
        {

        }
        Колонны_Form2 f2;
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Колонны_Form2();
            f2.Show();
        }
        Полосы_Form3 F3;
        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F3 = new Полосы_Form3();
            F3.Show();  
        }

        private void оТкрытьToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        Области_FORM4 F4;
        private void открытьToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            F4 = new Области_FORM4 ();
            F4.Show();
        }
        Пончик_Form5 F5;
        private void открытьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            F5 = new Пончик_Form5();
            F5.Show();
        }
    }
}
