using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ASM
{
    public partial class JournalFrm : Form
    {
        public JournalFrm()
        {
            InitializeComponent();
        }

        private void Journal_Load(object sender, EventArgs e)
        {
                  
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Buffer.ConnStr);
            conn.Open();
            string showtables = "select* from classes;";
            MySqlCommand comm = new MySqlCommand(showtables, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(showtables, conn);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            GroupBox.ValueMember = "id";
            GroupBox.DisplayMember = "name";
            GroupBox.DataSource = dtable;
            dataGridView1.DataSource = dtable;
        }
    }
}
