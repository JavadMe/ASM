using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ASM
{
    public partial class AuthFrm : Form
    {
        public AuthFrm()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Buffer.ConnStr = "server=192.168.5.202;user id=" + textBox1.Text + ";password=" + textBox2.Text + ";database=asm;port=3306";
                MySqlConnection conn = new MySqlConnection(Buffer.ConnStr);
                conn.Open();
                this.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
