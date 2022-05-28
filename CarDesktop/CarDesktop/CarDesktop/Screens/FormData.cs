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
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
        }
        public string p_No { get; set; }
        public int p_Price { get; set; }
        public string P_Name { get; set; }
        public Image P_Image { get; set; }

        DataTable dt = new DataTable();
        private void FormData_Load(object sender, EventArgs e)
        {
            //CartNo.Text = p_No;
            //CartName.Text = P_Name;
            //CartPrice.Text = p_Price.ToString();

            CartName.Text = P_Name;
            CartNo.Text = p_No;
            CartPrice.Text = p_Price.ToString();
            pictureCart.Image = P_Image;

            dt.Columns.Add("No", Type.GetType("System.String"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Price", Type.GetType("System.Int32"));
            dt.Columns.Add("Qty", Type.GetType("System.Int32"));
            dt.Columns.Add("Total", Type.GetType("System.Int32"));
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void Multiply()
        {
            int a, b;

            bool isAValid = int.TryParse(txt_qty.Text, out a);
            bool isBValid = int.TryParse(CartPrice.Text, out b);

            if (isAValid && isBValid)
            {
                CartTotal.Text = (a * b).ToString();
                labelTotal.Text = (a * b).ToString();
                labelSub.Text = (a * b).ToString();
            }
            else
                CartTotal.Text = "Invalid input";
        }
        public void SumFun()
        {
            decimal Total = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dataGridView1.Rows[i].Cells["Total"].Value);
            }

            labelTotal.Text = Total.ToString();
        }

        //private void clear()
        //{
        //    CartNo.Text = "";
        //    txt_price.Text = "";
        //    textBox2.Text = " ";
        //    txt_price.Text = "";
        //    txt_qty.Text = " ";
        //    txt_total.Text = " ";

        //}
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void AppClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduct f = new frmProduct();
            f.Show();
            
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(CartName.Text, CartNo.Text, CartPrice.Text, txt_qty.Text, CartTotal.Text);
            dataGridView1.DataSource = dt;
            this.Hide();
            Invoic();


        }
        private void Invoic()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("No", Type.GetType("System.String"));
            dt2.Columns.Add("Name", Type.GetType("System.String"));
            dt2.Columns.Add("Price", Type.GetType("System.Int32"));
            dt2.Columns.Add("Qty", Type.GetType("System.Int32"));
            dt2.Columns.Add("Total", Type.GetType("System.Int32"));

            foreach (DataGridViewRow row in dataGridView1.Rows)
                dt2.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(dt2);
            frmInvoice.getForm2.Show();
            frmInvoice.getForm2.crystalReportViewer1.ReportSource = report;
        }
        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }
    }
}
