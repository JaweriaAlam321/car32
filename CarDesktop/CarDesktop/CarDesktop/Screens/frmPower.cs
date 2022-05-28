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
    public partial class frmPower : Form
    {
        public frmPower()
        {
            InitializeComponent();
        }

        private void movepanel(Control btn)
        {
            panelHeader.Width = btn.Width;
            panelHeader.Left = btn.Left;
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            movepanel(btnHome);
            this.Hide();
            frmPower home = new frmPower();
            home.Show();
        }

        private void btnHome_MouseHover_1(object sender, EventArgs e)
        {
            movepanel(btnHome);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            movepanel(btnHome);
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnCategory_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnCategory);
            panelDropDown.Visible = true;
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

        private void btnAbout_Click(object sender, EventArgs e)
        {
            movepanel(btnAbout);
            this.Hide();
            frmAbout b = new frmAbout();
            b.Show();
        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnAbout);

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            movepanel(btnContact);
            frmContact a = new frmContact();
            a.Show();
        }

        private void btnContact_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnContact);
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

        private void panelDropDown_MouseEnter(object sender, EventArgs e)
        {
            panelDropDown.Visible = true;
        }

        private void panelDropDown_MouseLeave(object sender, EventArgs e)
        {
            panelDropDown.Visible = false
                ;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
