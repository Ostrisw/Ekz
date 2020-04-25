using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Magazine
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            //
            txtBoxIzdatel.Visible = false;
            txtBoxName.Visible = false;
            txtBoxNumber.Visible = false;
            txtBoxPrice.Visible = false;

            btn_send.Visible = false;
            dataGridView1.Visible = false;

            lblName.Visible = false;
            lblIzdatel.Visible = false;
            lblPrice.Visible = false;
            lblNumber.Visible = false;


                
        }
        private void FillData()
        {
            dataGridView1.DataSource = WorkWithFile.ReadTable();
        }

       

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text != "" && txtBoxIzdatel.Text != "" && txtBoxPrice.Text != "" && txtBoxNumber.Text != "")
            {
                Magazine cll = new Magazine();
                cll.Name = txtBoxName.Text;
                cll.Izdatel = txtBoxIzdatel.Text;
                cll.Price = txtBoxPrice.Text;
                cll.Number = txtBoxNumber.Text;
                cll.Save();
                FillData();
            }
            else { MessageBox.Show("Все поля обязательны к заполнению!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtBoxFilePath.Text = ofd.FileName;
                    WorkWithFile.FilePath = ofd.FileName;

                    txtBoxIzdatel.Visible = true;
                    txtBoxName.Visible = true;
                    txtBoxNumber.Visible = true;
                    txtBoxPrice.Visible = true;

                    btn_send.Visible = true;
                    dataGridView1.Visible = true;

                    lblName.Visible = true;
                    lblIzdatel.Visible = true;
                    lblPrice.Visible = true;
                    lblNumber.Visible = true;

                    FillData();
                }
                catch
                {
                    MessageBox.Show("Формат не соответсвует требуемому.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //
    }
}
