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
                        TicketBookingBinding.Add(ticketDTO);
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
            TicketBookingBinding.Add(ticketDTO);
        }

    }
}
