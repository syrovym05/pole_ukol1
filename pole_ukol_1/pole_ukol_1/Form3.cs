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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] cisla = new int[50];
            
            Random rnd = new Random();
            bool jeNula = false;
            int poziceNula = 1;

            listBox1.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                cisla[i] = rnd.Next(0, 100);
                listBox1.Items.Add(cisla[i]);

                if (cisla[i] == 0)
                {
                    poziceNula = i;
                    jeNula = true;
                }
                if (i == 39 && jeNula == false)
                {
                    listBox1.Items.Clear();
                    i = 0;
                }
            }
            
            int[] pole = cisla.Take(poziceNula).ToArray();

            double podil = Math.Round(Convert.ToDouble(pole.First()) / Convert.ToDouble(pole.Last()),3);
            label2.Text = "Podíl prvního a posledního prvku: " + podil;


            //foreach(int i in pole)
            //{
            //    listBox2.Items.Add(i);
            //}

            listBox2.Items.Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < pole.Last()) listBox2.Items.Add(i + ".\t" + pole[i]);
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
