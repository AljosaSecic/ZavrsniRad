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
    public partial class Form3 : Form
    {
        string value;
        public Form3()
        {
            InitializeComponent();
        }
        public void save (string value)
        {
            this.value = value;
        }

        private void Singleplayer_Click(object sender, EventArgs e)
        {
            value = value + " Singleplayer";
            this.Hide();
            Form4 f = new Form4();
            f.save(value);
            f.Show();
        }

        private void Mulitplayer_Click(object sender, EventArgs e)
        {
            value = value + " Multiplayer";
            this.Hide();
            Form4 f = new Form4();
            f.save(value);
            f.Show();
        }

        private void Oba_Click(object sender, EventArgs e)
        {
            value = value + " Oba";
            this.Hide();
            Form4 f = new Form4();
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
