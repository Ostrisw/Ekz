using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btn_podtverdit_massiv_Click(object sender, EventArgs e)
        {
            int razmer = Convert.ToInt32(numUpDownMass.Value);


            //
            InitializeComponent();
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
            //
            lblRazm.Visible = false;
            numUpDownMass.Visible = false;
            btn_podtverdit_massiv.Visible = false;
        }
    }
}
