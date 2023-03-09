using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ZavrsniRad
{
    public partial class Form8 : Form
    {
        string[] answers;
        public Form8()
        {
            InitializeComponent();
        }

        public void save(string value)
        {
            answers = value.Split(' ');
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            this.linkoviTableAdapter.Fill(this.igriceDataSet.Linkovi);
            this.igriceTableAdapter.Fill(this.igriceDataSet.Igrice);
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
           
            string filter = "";

            filter += dataGridView1.Columns[2].HeaderText.ToString() + " LIKE '%" + answers[0] + "%' AND ";

            if (answers[1] != "none")
            {
                filter += dataGridView1.Columns[3].HeaderText.ToString() + " LIKE '%" + answers[1] + "%' AND ";
            }
            filter += dataGridView1.Columns[4].HeaderText.ToString() + " LIKE '%" + answers[2] + "%' AND ";
            filter += dataGridView1.Columns[5].HeaderText.ToString() + " LIKE '%" + answers[3] + "%' AND ";

            if (answers[4] != "none")
            {

                if (answers[4] == "pre2010")
                {
                    filter += dataGridView1.Columns[6].HeaderText.ToString() + " <= '31-Dec-09'   AND ";
                }
                else if (answers[4] == "posle2010")
                {
                    filter += dataGridView1.Columns[6].HeaderText.ToString() + " >= '1-Jan-10' AND ";
                }

            }
            if (answers[5] != "none")
            {
                filter += dataGridView1.Columns[7].HeaderText.ToString() + " LIKE '" + answers[5] + "' AND ";
            }
            filter += dataGridView1.Columns[8].HeaderText.ToString() + " LIKE '" + answers[6] + "'  ";

            Console.WriteLine(filter);
            bs.Filter = filter;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {                   
                    DataGridViewRow row2 = dataGridView2.Rows[i];
                    if(row2.Cells[0].Value!=null){

                    string id1 = row2.Cells[0].Value.ToString();
                    if (id == id1)
                    {
                            Process.Start(row2.Cells[1].Value.ToString());                 
                    }
                }
            }     
        }
    }
}
