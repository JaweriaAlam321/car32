using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDesktop.Screens
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        private void movepanel(Control btn)
        {
            panelHeader.Width = btn.Width;
            panelHeader.Left = btn.Left;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            movepanel(btnHome);
            this.Hide();
            frmHome b = new frmHome();
            b.Show();

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            movepanel(btnCategory);
            panelDropDown.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            movepanel(btnProduct);
            this.Hide();
            frmProduct b = new frmProduct();
            b.Show();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            movepanel(btnAbout);
            this.Hide();
            frmAbout b = new frmAbout();
            b.Show();

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            movepanel(btnContact);
            this.Hide();
            frmContact a = new frmContact();
            a.Show();
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnHome);

        }

        private void btnCategory_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnCategory);
            panelDropDown.Visible = true;

        }

        private void btnProduct_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnProduct);

        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnAbout);

        }

        private void btnContact_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnContact);

        }

        private void panelDropDown_MouseEnter(object sender, EventArgs e)
        {
            panelDropDown.Visible = true;

        }

        private void panelDropDown_MouseLeave(object sender, EventArgs e)
        {
            panelDropDown.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AppClose_Click(object sender, EventArgs e)
        {
            frmHome m = new frmHome();
            m.Show();
            this.Hide();
        }
              

        private void Product1btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormData frm = new FormData();
            frm.p_No = lblNo1.Text;
            frm.P_Name = lblPName1.Text;
            frm.P_Image = pictureBox2.Image;

            frm.p_Price = Convert.ToInt32(lblPrice1.Text);
            frm.Show();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormData frm = new FormData();
            frm.p_No = lblNo2.Text;
            frm.P_Name = lblPName2.Text;
            frm.P_Image = pictureBox6.Image;

            frm.p_Price = Convert.ToInt32(lblPrice2.Text);
            frm.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormData frm = new FormData();
            frm.p_No = lblNo3.Text;
            frm.P_Name = lblPName3.Text;
            frm.P_Image = pictureBox7.Image;


            frm.p_Price = Convert.ToInt32(lblPrice3.Text);
            frm.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormData frm = new FormData();
            frm.p_No = lblNo4.Text;
            frm.P_Name = lblPName4.Text;
            frm.P_Image = pictureBox8.Image;

            frm.p_Price = Convert.ToInt32(lblPrice4.Text);
            frm.Show();
        }
    }
}
