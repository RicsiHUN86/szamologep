using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace naonjo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Összeadás
            double szam1 = (double)numericUpDown1.Value;
            double szam2 = (double)numericUpDown2.Value;

            double osszeg = szam1 + szam2;
            MessageBox.Show($"Az eredmény: {osszeg}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Kivonás
            double szam1 = (double)numericUpDown1.Value;
            double szam2 = (double)numericUpDown2.Value;

            double result = szam1 - szam2;
            MessageBox.Show($"Az eredmény: {result}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Szorzás
            double szam1 = (double)numericUpDown1.Value;
            double szam2 = (double)numericUpDown2.Value;

            double result = szam1 * szam2;
            MessageBox.Show($"Az eredmény: {result}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Osztás
            double szam1 = (double)numericUpDown1.Value;
            double szam2 = (double)numericUpDown2.Value;

            if (szam2 != 0)
            {
                double result = szam1 / szam2;
                MessageBox.Show($"Az eredmény: {result}");
            }
            else
            {
                MessageBox.Show("Nullával nem lehet osztani!");
            }
        }
    }
}