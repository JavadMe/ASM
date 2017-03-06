using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class UpdateFrm : Form
    {
        MainFrm frm = new MainFrm();

        public string setGroupBoxText
        {
            set
            {
                this.groupBox1.Text = value;

            }
        }

        

        public UpdateFrm()
        {
            InitializeComponent();
        }

        public void setDetails(string kodu, string adi, string soyadi,
                               string ataAdi, DateTime dogIl, string cinsi, string milliyyet, string rayon,
                               string dogulduguOlke, string sexsiIs, string sekil, DateTime mBitIl)
        {
            txtKodu.Text = kodu;
            txtAdi.Text = adi;
            txtSoyadi.Text = soyadi;
            txtAtaAdi.Text = ataAdi;
            GenderBox.Text = cinsi;
            comboBox1.Text = rayon;
            txtDogulduguOlke.Text = dogulduguOlke;
            txtMilliyyet.Text = milliyyet;
            txtSexsiIs.Text = sexsiIs;
            pictureBox1.ImageLocation = sekil;
            mekbitilpicker.Value = mBitIl;
            DogumIliPicker.Value = dogIl;
           
        }
        public void setDetails(string kodu, string adi, string soyadi,
                               string ataAdi, DateTime dogIl, string cinsi, string milliyyet, string rayon,
                               string dogulduguOlke, string sexsiIs, string sekil)
        {
            txtKodu.Text = kodu;
            txtAdi.Text = adi;
            txtSoyadi.Text = soyadi;
            txtAtaAdi.Text = ataAdi;
            GenderBox.Text = cinsi;
            comboBox1.Text = rayon;
            txtDogulduguOlke.Text = dogulduguOlke;
            txtMilliyyet.Text = milliyyet;
            txtSexsiIs.Text = sexsiIs;
            pictureBox1.ImageLocation = sekil;
            DogumIliPicker.Value = dogIl;
        }

        

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Buffer.mode == "student")
                {
                    frm.AddRecordStudents(Int32.Parse(txtKodu.Text), txtAdi.Text, txtSoyadi.Text, txtAtaAdi.Text,
                                          GenderBox.Text, txtMilliyyet.Text, comboBox1.Text, txtDogulduguOlke.Text, txtSexsiIs.Text,
                                          openFileDialog1.FileName, mekbitilpicker.Value.Date, DogumIliPicker.Value.Date);
                    openFileDialog1.FileName = null;
                }
                else if (Buffer.mode == "staff")
                {
                    frm.AddRecordStaff(Int32.Parse(txtKodu.Text), txtAdi.Text, txtSoyadi.Text, txtAtaAdi.Text,
                                       GenderBox.Text, txtDogulduguOlke.Text, txtMilliyyet.Text, txtSexsiIs.Text,
                                       comboBox1.Text, openFileDialog1.FileName, DogumIliPicker.Value.Date);
                    openFileDialog1.FileName = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void UpdateFrm_Load(object sender, EventArgs e)
        {
            if (Buffer.mode == "staff")
            {
                mekbitilpicker.Enabled = false;
            }
            this.ActiveControl = txtKodu;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }


    }
}