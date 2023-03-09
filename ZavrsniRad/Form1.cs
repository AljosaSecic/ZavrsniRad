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
    public partial class Form1 : Form
    {
        string value;
        public Form1()
        {
            InitializeComponent();
        }

        private void FPS_Click(object sender, EventArgs e)
        {
            value = value + "FPS none";
            this.Hide();
            Form3 f = new Form3();
            f.save(value);
            f.Show();
        }

        private void RPG_Click(object sender, EventArgs e)
        {
            value = value + "RPG";
            this.Hide();
            Form2 f = new Form2();
            f.save(value);
            f.Show();
        }

        private void Simulacija_Click(object sender, EventArgs e)
        {
            value = value + "Simulation";
            this.Hide();
            Form2 f = new Form2();
            f.save(value);
            f.Show();
        }

        private void Sport_Click(object sender, EventArgs e)
        {
            value = value + "Sport";
            this.Hide();
            Form2 f = new Form2();
            f.save(value);
            f.Show();
        }

        private void Akcija_Click(object sender, EventArgs e)
        {
            value = value + "Action";
            this.Hide();
            Form2 f = new Form2();
            f.save(value);
            f.Show();
        }

        private void Avantura_Click(object sender, EventArgs e)
        {
            value = value + "Adventure";
            this.Hide();
            Form2 f = new Form2();
            f.save(value);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = value + "Strategic";
            this.Hide();
            Form2 f = new Form2();
            f.save(value);
            f.Show();
        }

        private void Fighter_Click(object sender, EventArgs e)
        {
            value = value + "Fighter none";
            this.Hide();
            Form3 f = new Form3();
            f.save(value);
            f.Show();
        }

        private void Horor_Click(object sender, EventArgs e)
        {
            value = value + "Horror none";
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
