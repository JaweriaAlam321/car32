using CarDesktop.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDesktop
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void movepanel(Control btn)
        {
            panelHeader.Width = btn.Width;
            panelHeader.Left = btn.Left;
        }

        private void AppClose_Click(object sender, EventArgs e)
        {
            frmHome m = new frmHome();
            m.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            movepanel(btnHome);
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            movepanel(btnCategory);
            panelDropDown.Visible = true;

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

        private void btnProduct_Click(object sender, EventArgs e)
        {
            movepanel(btnProduct);
            this.Hide();
            frmProduct p = new frmProduct();
            p.Show();
        }

        private void btnProduct_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnProduct);
        }
    }
}
