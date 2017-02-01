using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Sales_and_Inventory_System__Gadgets_Shop_
{
    public partial class frmTrail : Form
    {
        public frmTrail()
        {
            InitializeComponent();
        }

        private void frmTrail_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString (Properties.Settings.Default.Trail);
            if (Properties.Settings.Default.TrailE == "yes")
            {
                frmSplash s1 = new frmSplash();
                s1.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (Properties.Settings.Default.Trail < 1)
            {
                Properties.Settings.Default.Trail = 0;
                Properties.Settings.Default.Save();
                label2.Text = "0";
                MessageBox.Show("Trail expired, Please Register!", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
            else
            {
                frmSplash sp = new frmSplash();
                Properties.Settings.Default.Trail = Properties.Settings.Default.Trail - 1;
                Properties.Settings.Default.Save();
                this.Hide();
                sp.ShowDialog();
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String key = Microsoft.VisualBasic.Interaction.InputBox("Please Enter Serial Key", "Activate Product", "");
            if (key == "123-321-123-123487-564")
            {
                Properties.Settings.Default.TrailE = "yes";
                Properties.Settings.Default.Save();
                frmSplash s1 = new frmSplash();
                s1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Serial Key?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}

