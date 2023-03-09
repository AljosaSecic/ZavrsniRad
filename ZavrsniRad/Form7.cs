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
    public partial class Form7 : Form
    {
        string value;
        public Form7()
        {
            InitializeComponent();
        }
        public void save(string value)
        {
            this.value = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = value + " Yes";
            this.Hide();
            Form8 f = new Form8();
            f.save(value);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = value + " No";
            this.Hide();
            Form8 f = new Form8();
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
