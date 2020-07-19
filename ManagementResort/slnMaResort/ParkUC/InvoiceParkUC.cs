using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnMaResort.ParkUC
{
    public partial class InvoiceParkUC : UserControl
    {
        public InvoiceParkUC()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

        private void InvoiceParkUC_Load(object sender, EventArgs e)
        {
            dgvListTicket.DataSource = "";
           TicketBLL.Instance.loadAllTicketDGV(dgvListTicket);
        }
        
        TicketDTO ticketDTO = new TicketDTO();
        private void dgvListTicket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
            TicketBLL.Instance.AddTicketInvoice(dgvListTicket, dgvTicketBooking, TicketBookingBinding);
            int subtotal = TicketBLL.Instance.Subtotal(dgvTicketBooking);
            txtSubtotal.Text = subtotal.ToString();
        }

        private void dgvTicketBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketBLL.Instance.DeleteTicketDGV(dgvTicketBooking);
            int subtotal = TicketBLL.Instance.Subtotal(dgvTicketBooking);
            txtSubtotal.Text = subtotal.ToString();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "0")
            {
                txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubtotal.Text.Trim()) - (Convert.ToDecimal(txtDiscount.Text.Trim()))).ToString();
            }
            else txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubtotal.Text.Trim())).ToString();
        }   

        private void txtOthers_TextChanged(object sender, EventArgs e)
        {   
                if (txtDiscount.Text != "0")
                    txtTotal.Text = ((Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubtotal.Text.Trim()) - (Convert.ToDecimal(txtDiscount.Text.Trim()))).ToString());
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            txtChange.Text = "";
            btPayment.Enabled = false;
            if (TicketBLL.Instance.IsNumeric(txtPaid.Text) == true && double.Parse(txtPaid.Text) >= double.Parse(txtTotal.Text))
            {
                double changed;
                changed = Convert.ToDouble(txtPaid.Text.Trim()) - Convert.ToDouble(txtTotal.Text.Trim());
                txtChange.Text = changed.ToString();
                btPayment.Enabled = true;
            }
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text != "0")
            {
                    txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubtotal.Text.Trim()) + Convert.ToDecimal(txtDiscount.Text.Trim())).ToString();
            }
            else txtTotal.Text = (Convert.ToDecimal(txtOthers.Text.Trim()) + Convert.ToDecimal(txtSubtotal.Text.Trim())).ToString();
        }
>>>>>>> Stashed changes
    }
}
