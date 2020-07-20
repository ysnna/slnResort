using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using slnMaResort.DAL;
using slnMaResort.DTO;
using System.IO;
using System.Drawing;

namespace slnMaResort.BLL
{
    public class TicketBLL
    {
        private static TicketBLL instance;
        private TicketBLL() { }
        public static TicketBLL Instance
        {
            get
            {
                if (instance == null) instance = new TicketBLL();
                return TicketBLL.instance;
            }
            private set => TicketBLL.instance = value;
        }
        public void loadAllTicketDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            DataTable dt1 = new DataTable();
            dt1 = TicketDAL.Instance.loadAllTicket();
            if (dt1.Rows.Count > 0)
            {
                dt1 = dt1.DefaultView.ToTable(true, "IDTicketbooking", "Name", "Price", "Available");
            }
            dgv.DataSource = dt1;
        }
       
        public DataTable loadAllTicket()
        {

            DataTable dt1 = new DataTable();
            dt1 = TicketDAL.Instance.loadAllTicket();
            if (dt1.Rows.Count > 0)
            {
                return dt1;
            }
            return null;

        }
        TicketDTO ticketDTO = new TicketDTO();
        public void AddTicketInvoice(DataGridView dgvLeft, DataGridView dgvRight, BindingSource binding)
        {
            int index = dgvLeft.CurrentCell.RowIndex;
            while (dgvRight.Rows.Count != 0)
            {
                int i = 0;
                while (i < dgvRight.Rows.Count)
                {
                    if (int.Parse(dgvLeft.CurrentRow.Cells[0].Value.ToString()) !=
                   int.Parse(dgvRight.Rows[i].Cells[0].Value.ToString()))
                    {
                        i++;
                    }
                    else
                    {
                        dgvRight.Rows[i].Cells[3].Value =
                            int.Parse(dgvRight.Rows[i].Cells[3].Value.ToString()) + 1;
                        dgvRight.Rows[i].Cells[2].Value =
                            float.Parse(dgvLeft.CurrentRow.Cells[2].Value.ToString()) *
                            int.Parse(dgvRight.Rows[i].Cells[3].Value.ToString());
                        return;
                    }
                }
                ticketDTO = new TicketDTO();

                ticketDTO.idTicketbooking = int.Parse(dgvLeft.Rows[index].Cells[0].Value.ToString());
                ticketDTO.name = dgvLeft.Rows[index].Cells[1].Value.ToString();
                ticketDTO.price = float.Parse(dgvLeft.Rows[index].Cells[2].Value.ToString());
                ticketDTO.Amount = 1;
                binding.Add(ticketDTO);
            }

            ticketDTO = new TicketDTO();

            ticketDTO.idTicketbooking = int.Parse(dgvLeft.Rows[index].Cells[0].Value.ToString());
            ticketDTO.name = dgvLeft.Rows[index].Cells[1].Value.ToString();
            ticketDTO.price = float.Parse(dgvLeft.Rows[index].Cells[2].Value.ToString());
            ticketDTO.Amount = 1;
            binding.Add(ticketDTO);
        }

        public void DeleteTicketDGV(DataGridView dgv)
        {
            dgv.Rows.Remove(dgv.CurrentRow);
        }
        public bool IsNumeric(string val) => double.TryParse(val, out double result);
        // Tinh tong tien vao txt Subtotal
        public int Subtotal(DataGridView dgv)
        {
            int i = 0;
            int subtotal = 0;
            while (i < dgv.Rows.Count)
            {
                subtotal += int.Parse(dgv.Rows[i].Cells[2].Value.ToString());

                i++;
            }
            return subtotal;
        }
        public void loadpicket(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 40;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            DataTable dt = TicketDAL.Instance.loadAllTicket();
            dgv.DataSource = dt;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgv.Columns[3];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;

   
        }

        public void insertTicket(int IDticket, string Name, float price, MemoryStream Picture, int Available)
        {
            TicketDAL.Instance.insertTicket(IDticket, Name, price, Picture, Available);
        }
        public void updateTicket(int IDticket, string Name, float price, MemoryStream Picture, int Available)
        {
            TicketDAL.Instance.updateTicket(IDticket, Name, price, Picture, Available);
        }
        public void deleteTicket(int ID)
        {
            TicketDAL.Instance.deleteTicket(ID);
        }
        public DataTable loadticketbyId(int id)
        {
            DataTable dt = TicketDAL.Instance.loadTicketByID(id);
            return dt;
        }
        public void LoadPicTicket(FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            List<TicketssDTO> ticketssDTOs = new List<TicketssDTO>();
            DataTable dt = new DataTable();
            dt = TicketDAL.Instance.loadAllTicket();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    TicketssDTO ticketssDTO = new TicketssDTO(item);
                    ticketssDTOs.Add(ticketssDTO);
                }
                foreach (TicketssDTO item in ticketssDTOs)
                {
                
                    Button bt = new Button()
                    {
                        Width = TicketssDTO.width,
                        Height = TicketssDTO.height
                    };
                    bt.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point);

                    bt.ForeColor = Color.Navy;
                    bt.BackColor = flp.BackColor;
                    bt.FlatAppearance.BorderColor = Color.Navy;
                    bt.FlatAppearance.BorderSize = 5;
                    bt.FlatStyle = FlatStyle.Flat;

                    bt.Text = item.ID.ToString();
                    bt.BackgroundImage = item.Pic;
                    bt.BackgroundImageLayout = ImageLayout.Zoom;

                    flp.Controls.Add(bt);
                    flp.Refresh();
                }
            }


        }
    }
}