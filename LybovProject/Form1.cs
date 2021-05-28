using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LybovProject
{
    public partial class Form1 : Form
    {

        private SqlConnection sqlConnecton = null;

        private SqlDataAdapter adapter = null;

        private DataTable table = null;

        public Form1()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            table.Clear();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnecton = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS3;Initial Catalog=Ermakova447;Integrated Security=True");

            sqlConnecton.Open();
            adapter = new SqlDataAdapter("SELECT * FROM materials", sqlConnecton);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;


        }
    }
}
