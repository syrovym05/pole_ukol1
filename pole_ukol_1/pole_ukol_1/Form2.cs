using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole_ukol_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            numericUpDown2.Value = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pole;
            int n = Convert.ToInt32(numericUpDown1.Value);
            int b = Convert.ToInt32(numericUpDown2.Value);
            Random rnd = new Random();    
            pole = new int[n];
            
            for(int i = 0;i < n; i++) pole[i] = rnd.Next(0, 100);

            //Array.Sort(pole);
            listBox1.Items.Clear();
            foreach (int i in pole)
            {
                listBox1.Items.Add(i);
            }

            Array.Sort(pole);
            int[] pole2 = pole;
            int[] pole3 = pole;
            int poradi_B = 0;


            Array.Sort(pole2);
           
            for (int i = 0; i < n; i++)
            {
                if (pole2[i] < b)
                {
                    poradi_B = i;                    
                }
            }

            
            pole2 = pole2.Take(poradi_B+1).ToArray();
            listBox2.Items.Clear();
            foreach (int i in pole2)
            {
                listBox2.Items.Add(i);
            }

            //poradi_B = n - poradi_B-1;

            Array.Reverse(pole3);
            for (int i = 0; i < n; i++)
            {
                if (pole3[i] > b)
                {
                    poradi_B = i+1;   
                }
            }

            Array.Sort(pole3);
            pole3 = pole3.Skip(n - poradi_B).ToArray();
            
            listBox3.Items.Clear();
            foreach (int i in pole3)
            {
                listBox3.Items.Add(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
