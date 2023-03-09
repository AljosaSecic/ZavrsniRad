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
    public partial class Form4 : Form
    {
        string value;
        public Form4()
        
        {
            InitializeComponent();
        }
        public void save(string value)
        {
            this.value = value;
        }

        private void PC_Click(object sender, EventArgs e)
        {
            value = value + " PC";
            this.Hide();
            Form5 f = new Form5(); 
            f.save(value);
            f.Show();
        }

        private void PS_Click(object sender, EventArgs e)
        {
            value = value + " PS";
            this.Hide();
            Form5 f = new Form5();
            f.save(value);
            f.Show();

        }
        
        private void XBOX_Click(object sender, EventArgs e)
        {
            value = value + " Xbox";
            this.Hide();
            Form5 f = new Form5();
            f.save(value);
            f.Show();

        }

        private void Smartphone_Click(object sender, EventArgs e)
        {
            value = value + " Smartphone none";
            this.Hide();
            Form6 f = new Form6();
            f.save(value);
            f.Show();
        }

        private void Nintendo_Click(object sender, EventArgs e)
        {
            value = value + " Nintendo none";
            this.Hide();
            Form6 f = new Form6();
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
