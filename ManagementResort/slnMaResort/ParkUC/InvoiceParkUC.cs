using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnMaResort.BLL;
using slnMaResort.DTO;

namespace slnMaResort.ParkUC
{
    public partial class InvoiceParkUC : UserControl
    {
        public InvoiceParkUC()
        {
            InitializeComponent();
            TicketBLL.Instance.LoadPicTicket(flTickerPicture);
        }

        private void InvoiceParkUC_Load(object sender, EventArgs e)
        {
            dgvListTicket.DataSource = "";
            TicketBLL.Instance.loadAllTicketDGV(dgvListTicket);
        }
        int index = 0;
        TicketDTO ticketDTO = new TicketDTO();

        private void dgvListTicket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //TicketBLL.Instance.AddTicketInvoice(dgvListTicket, dgvTicketBooking, TicketBookingBinding);
            //int subtotal = TicketBLL.Instance.Subtotal(dgvTicketBooking);
            //txtSubtotal.Text = subtotal.ToString();
            int index = dgvListTicket.CurrentCell.RowIndex;
            while (dgvTicketBooking.Rows.Count != 0)
            {
                for (int i = 0; i < dgvTicketBooking.Rows.Count; i++)
                {
                    ticketDTO = new TicketDTO();

                    ticketDTO.idTicketbooking = int.Parse(dgvListTicket.Rows[index].Cells[0].Value.ToString());
                    ticketDTO.name = dgvListTicket.Rows[index].Cells[1].Value.ToString();
                    ticketDTO.price = float.Parse(dgvListTicket.Rows[index].Cells[2].Value.ToString());
                    if (ticketDTO.idTicketbooking != int.Parse(dgvTicketBooking.Rows[i].Cells[0].Value.ToString()))
                    {
                        ticketDTO.Amount = 1;
                        //TicketBookingBinding.Add(ticketDTO);
                        return;
                    }
                    else
                    {
                        dgvTicketBooking.Rows[i].Cells[3].Value = int.Parse(dgvTicketBooking.Rows[i].Cells[3].Value.ToString()) + 1;
                        return;
                    }
                }
            }
            ticketDTO = new TicketDTO();
            ticketDTO.idTicketbooking = int.Parse(dgvListTicket.Rows[index].Cells[0].Value.ToString());
            ticketDTO.name = dgvListTicket.Rows[index].Cells[1].Value.ToString();
            ticketDTO.price = float.Parse(dgvListTicket.Rows[index].Cells[2].Value.ToString());
            ticketDTO.Amount = 1;
            //TicketBookingBinding.Add(ticketDTO);
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
    }
}
