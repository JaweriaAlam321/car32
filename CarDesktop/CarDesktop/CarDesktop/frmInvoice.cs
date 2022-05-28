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
    public partial class frmInvoice : Form
    {
        private static frmInvoice frm;
        public static frmInvoice getForm2
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmInvoice();
                }
                return frm;
            }
        }
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            
        }
    }
}
