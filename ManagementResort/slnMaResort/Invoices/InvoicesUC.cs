using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace slnMaResort.Invoices
{
    public partial class InvoicesUC : UserControl
    {
        public InvoicesUC()
        {
            InitializeComponent();
        }
        public void createBill(Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            double cash = double.Parse(txtTotal.Text, NumberStyles.Currency);
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 16);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;
            graphic.DrawString("       Resort RS5S", new Font("Courier New", 24), new SolidBrush(Color.Black), startX + 100, startY);
            string top = "Item Name".PadRight(35) + "Quantity".PadRight(10) + "Price";
            offset = offset + (int)fontHeight;
            graphic.DrawString("Invoice number: " + txtInvoiceNo.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Employee ID   : " + txtEmployeeID.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Member        : " + txtNameMember.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Checked out   : " + dtpPayment.Text, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 20;
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            decimal total = Convert.ToDecimal(txtTotal.Text);
            decimal paid = Convert.ToDecimal(txtPaid.Text);
            decimal change = Convert.ToDecimal(txtChange.Text);

            for (int i = 0; i < dgvCheckInvoice.Rows.Count; i++)
            {
                string name = dgvCheckInvoice.Rows[i].Cells[2].Value.ToString();
                string quantity = dgvCheckInvoice.Rows[i].Cells[3].Value.ToString();
                decimal price = Convert.ToDecimal(dgvCheckInvoice.Rows[i].Cells[4].Value);

                string productLine = name.PadRight(35) + quantity.PadRight(10) + String.Format("{0:c}", price);
                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontHeight + 5;
            }

            graphic.DrawString("------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            graphic.DrawString("Total  ".PadRight(45) + String.Format("{0:c}", total),
                new Font("Courier New", 16, FontStyle.Regular),
                new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Payment".PadRight(45) + String.Format("{0:c}", paid),
                new Font("Courier New", 16, FontStyle.Regular),
                new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Change ".PadRight(45) + String.Format("{0:c}", change),
                new Font("Courier New", 16, FontStyle.Regular),
                new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 40;
            graphic.DrawString("          Thank you. See you again soon", font, new SolidBrush(Color.Black), startX + 100, startY + offset);

            offset = offset + 20;
            graphic.DrawString("             Have a wonderful day!", font, new SolidBrush(Color.Black), startX + 100, startY + offset);
        }
        private void btPrintInvoice_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument receipt = new System.Drawing.Printing.PrintDocument();
            printDialog1.Document = receipt;
            receipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(createBill);
            DialogResult result1 = printDialog1.ShowDialog();
            if (result1 == DialogResult.OK)
                receipt.Print();
            this.Dispose();
        }
    }
}
