/*
 * ╔╦╦
 * ╠╬╬╬╣
 * ╠╬╬╬╣
 * ╠╬╬╬╣
 * ╚╩╩╩╝ Copyright Javad Memmed
 */



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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        public void AddRecordStudents(int kodu,
                                      string adi,
                                      string soyadi,
                                      string ata_adi,
                                      string cinsi,
                                      string milliyyeti,
                                      string rayon,
                                      string doguldugu_olke,
                                      string sexsi_is,
                                      string sekil,
                                      DateTime mekteb_bit,
                                      DateTime dogum_ili)
        {
            this.studentsTableAdapter.InsertQuery(kodu, adi, soyadi, ata_adi, cinsi, milliyyeti,
                                                  rayon, doguldugu_olke, sexsi_is, sekil, mekteb_bit, dogum_ili);
            this.studentsTableAdapter.Fill(this.ASMDataSet.students);
            dataGridView1.DataSource = studentsBindingSource;
        }

        public void AddRecordStaff(int kodu, string adi, string soyadi,
                                   string ata_adi, string cinsi, string doguldugu_olke, string milliyyeti,
                                   string sexsi_is, string rayon, string sekil, DateTime dogum_ili)
        {
            this.staffTableAdapter.InsertQuery(kodu, adi, soyadi, ata_adi, cinsi, doguldugu_olke, milliyyeti,
                                               sexsi_is, rayon, sekil, dogum_ili);
            this.staffTableAdapter.Fill(this.ASMDataSet.staff);
            dataGridView1.DataSource = staffBindingSource;
        }

        private string GetGridCell(int column)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[GetRowIndex()];
                return Convert.ToString(selectedRow.Cells[column].Value);
            }
            else
            {
                return "-1";
            }
        }

        public int GetRowIndex()
        {

            return dataGridView1.SelectedCells[0].RowIndex;

        }


        private void MainFrm_Load(object sender, EventArgs e)
        {
            AuthFrm frm = new AuthFrm();
            this.AddOwnedForm(frm);
            this.Show();
            frm.ControlBox = false;
            frm.ShowDialog();

        }

        private void cixisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Details_btn_Click(object sender, EventArgs e)
        {
            UpdateFrm frm = new UpdateFrm();
            frm.Show();
            frm.Text = "Təfərrüatlara baxış";
            try
            {
                if (Buffer.mode == "staff")
                {

                    frm.setTabText1 = "Heyet teferruatlar";
                    frm.setTabText2 = "Heyet teferruatlari";




                    frm.setDetails(GetGridCell(0), (string)this.ASMDataSet.staff.Rows[GetRowIndex()][1],
                                                   (string)this.ASMDataSet.staff.Rows[GetRowIndex()][2],
                                                   (string)this.ASMDataSet.staff.Rows[GetRowIndex()][3],
                                                   (DateTime)this.ASMDataSet.staff.Rows[GetRowIndex()][4],
                                                   (string)this.ASMDataSet.staff.Rows[GetRowIndex()][5],
                                                   (string)this.ASMDataSet.staff.Rows[GetRowIndex()][6],
                                                   (string)this.ASMDataSet.staff.Rows[GetRowIndex()][7],
                                                   (string)this.ASMDataSet.staff.Rows[GetRowIndex()][8],
                                                   "err",//(string)this.ASMDataSet.staff.Rows[GetRowIndex()][9],
                                                   (string)this.ASMDataSet.staff.Rows[GetRowIndex()][10]);
                                                   
                }
                else
                {
                    frm.setDetails(GetGridCell(0), (string)this.ASMDataSet.students.Rows[GetRowIndex()][1],
                                                    (string)this.ASMDataSet.students.Rows[GetRowIndex()][2],
                                                    (string)this.ASMDataSet.students.Rows[GetRowIndex()][3],
                                                    (DateTime)this.ASMDataSet.students.Rows[GetRowIndex()][4],
                                                    (string)this.ASMDataSet.students.Rows[GetRowIndex()][5],
                                                    (string)this.ASMDataSet.students.Rows[GetRowIndex()][6],
                                                    (string)this.ASMDataSet.students.Rows[GetRowIndex()][7],
                                                    (string)this.ASMDataSet.students.Rows[GetRowIndex()][8],
                                                    (string)this.ASMDataSet.students.Rows[GetRowIndex()][9],
                                                    (string)this.ASMDataSet.students.Rows[GetRowIndex()][10],
                                                    (DateTime)this.ASMDataSet.students.Rows[GetRowIndex()][11]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + GetRowIndex());
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            UpdateFrm frm = new UpdateFrm();
            frm.Text = "Əlavə et";
            frm.Show();
            if (Buffer.mode == "staff")
            {
                frm.setTabText1 = "Heyet teferruatlar";
                frm.setTabText2 = "Heyet teferruatlari";
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(GetGridCell(1) + " " + GetGridCell(2) +
                                  "\nadlı istifadəçini silmək istədiyinizdən əminsiniz?", "Diqqət!!!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (Buffer.mode == "student")
                {
                    try
                    {
                        this.studentsTableAdapter.DeleteQuery(Int32.Parse(GetGridCell(0)));
                        this.studentsTableAdapter.Fill(this.ASMDataSet.students);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Secilmemisdir!");
                    }
                }
                else if (Buffer.mode == "staff")
                {
                    try
                    {
                        this.staffTableAdapter.DeleteQuery(Int32.Parse(GetGridCell(0)));
                        this.staffTableAdapter.Fill(this.ASMDataSet.staff);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Secilmemisdir!");
                    }
                }


            }

        }

        private void StaffLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Buffer.mode = "staff";
            this.staffTableAdapter.Fill(this.ASMDataSet.staff);
            dataGridView1.DataSource = staffBindingSource;
            this.Details_btn.Enabled = true;
        }

        private void StudentsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            studentsTableAdapter.Fill(this.ASMDataSet.students);
            dataGridView1.DataSource = studentsBindingSource;
            this.Details_btn.Enabled = true;
            this.Add_btn.Enabled = true;
            this.Delete_btn.Enabled = true;
            this.Find_btn.Enabled = true;
            Buffer.mode = "student";
        }

        private void JournalLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JournalFrm jfrm = new JournalFrm();
            jfrm.Show();
        }

        private void Find_btn_Click(object sender, EventArgs e)
        {
            FindFrm frm = new FindFrm();
            frm.ShowDialog();
        }
    }
}