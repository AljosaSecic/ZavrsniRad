using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZavrsniRad
{
    public partial class Form2 : Form
    {
        string value;

        public Form2()
        {
            InitializeComponent();
        }
        public void save(string value)
        {
            this.value = value;
        }


        private void Da_Click(object sender, EventArgs e)
        {
            value = value + " E";
            this.Hide();
            Form3 f = new Form3();
            f.save(value);
            f.Show();
        }


        private void SesnPlus_Click(object sender, EventArgs e)
        {
            value = value + " T";
            this.Hide();
            Form3 f = new Form3();
            f.save(value);
            f.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            value = value + " R";
            this.Hide();
            Form3 f = new Form3();
            f.save(value);
            f.Show();
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
