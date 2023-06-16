using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilet_satis
{
    public partial class SaleForm : Form
    {
        SqlConnection SqlConn = new SqlConnection("Server=DESKTOP-1TVNHPO;Database=TM_DB;Trusted_Connection=True");
        SqlCommand Command;
        DataSet dataSet = new DataSet();
        SqlDataAdapter DataAdapter;

        public SaleForm()
        {
            InitializeComponent();
            EventList();
            TicketList();
        }

        private void EventList()
        {
            if (dataSet.Tables["EventList"] != null)
            {
                dataSet.Tables.Remove("EventList");
            }
            DataAdapter = new SqlDataAdapter("select * from Event", SqlConn);
            DataAdapter.Fill(dataSet, "EventList");
            dataGridViewEventList.DataSource = dataSet.Tables["EventList"];
        }

        private void TicketList()
        {
            if (dataSet.Tables["TicketList"] != null)
            {
                dataSet.Tables.Remove("TicketList");
            }
            DataAdapter = new SqlDataAdapter("select * from TicketList ORDER BY REGISTRATION_DATE DESC", SqlConn);
            DataAdapter.Fill(dataSet, "TicketList");
            dataGridViewTicketList.DataSource = dataSet.Tables["TicketList"];
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            Command = new SqlCommand("INSERT INTO TICKET (EVENT_ID, MEMBER_ID, QUANTITY, PRICE, USER_ID) VALUES(@EVENT_ID, @MEMBER_ID, @QUANTITY, @PRICE, @USER_ID)", SqlConn);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("@EVENT_ID", EventIDTB.Text);
            Command.Parameters.AddWithValue("@MEMBER_ID", CustomerIDTB.Text);
            Command.Parameters.AddWithValue("@QUANTITY", QuantityTB.Text);
            Command.Parameters.AddWithValue("@PRICE", PriceTB.Text);
            Command.Parameters.AddWithValue("@USER_ID", "1");
            SqlConn.Open();
            Command.ExecuteNonQuery();
            SqlConn.Close();
            TicketList();
            screenclear();
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silme işlemini onaylıyormusunuz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Command = new SqlCommand("delete from ticket where id=@id", SqlConn);
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@id", dataGridViewTicketList.SelectedRows[0].Cells["id"].Value);
                SqlConn.Open();
                Command.ExecuteNonQuery();
                SqlConn.Close();
                TicketList();
                screenclear();
            }
        }

        private void dataGridViewTicketList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                EventIDTB.Text = dataGridViewTicketList.SelectedRows[0].Cells["id"].Value.ToString();
                EventTB.Text = dataGridViewTicketList.SelectedRows[0].Cells["E_DESCRIPTION"].Value.ToString();
                DateTB.Text = dataGridViewTicketList.SelectedRows[0].Cells["E_START_DATE"].Value.ToString();
                PriceTB.Text = dataGridViewEventList.SelectedRows[0].Cells["E_TICKET_PRICE"].Value.ToString();

                Image selectedImage = Image.FromFile(dataGridViewTicketList.SelectedRows[0].Cells["E_PICTURE"].Value.ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = selectedImage;

            }
            catch (Exception)
            {
            }
        }

        private void EtkinlikFormBT_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
        }

        private void dataGridViewEventList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               EventIDTB.Text = dataGridViewEventList.SelectedRows[0].Cells["id"].Value.ToString();
               EventTB.Text = dataGridViewEventList.SelectedRows[0].Cells["E_NAME"].Value.ToString();
               Image selectedImage = Image.FromFile(dataGridViewEventList.SelectedRows[0].Cells["E_PICTURE"].Value.ToString());
               pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox1.Image = selectedImage;
            }
            catch (Exception)
            {
            }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewTicketList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KullaniciFormBT_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void CustomerIDTB_Leave(object sender, EventArgs e)
        {
            if (dataSet.Tables["Member"] != null)
            {
                dataSet.Tables.Remove("Member");
            }
            DataAdapter = new SqlDataAdapter("SELECT * FROM MEMBER WHERE ID=@ID", SqlConn);
            DataAdapter.SelectCommand.Parameters.Clear();
            DataAdapter.SelectCommand.Parameters.AddWithValue("@ID", CustomerIDTB.Text);
            DataAdapter.Fill(dataSet, "Member");
            if (dataSet.Tables["Member"].Rows.Count > 0)
            {
                CustomerIDTB.Text = dataSet.Tables["Member"].Rows[0]["ID"].ToString();
                CustomerNameTB.Text = dataSet.Tables["Member"].Rows[0]["FULLNAME"].ToString();
            }
        }

        private void EventIDTB_Leave(object sender, EventArgs e)
        {
            if (dataSet.Tables["Event"] != null)
            {
                dataSet.Tables.Remove("Event");
            }
            DataAdapter = new SqlDataAdapter("SELECT * FROM EVENT WHERE ID=@ID", SqlConn);
            DataAdapter.SelectCommand.Parameters.Clear();
            DataAdapter.SelectCommand.Parameters.AddWithValue("@ID", EventIDTB.Text);
            DataAdapter.Fill(dataSet, "Event");
            if (dataSet.Tables["Event"].Rows.Count > 0)
            {
                EventTB.Text = dataSet.Tables["Event"].Rows[0]["E_NAME"].ToString();
                DateTB.Text = dataSet.Tables["Event"].Rows[0]["E_START_DATE"].ToString();
                PriceTB.Text = dataSet.Tables["Event"].Rows[0]["E_TICKET_PRICE"].ToString();
                Image selectedImage = Image.FromFile(dataSet.Tables["Event"].Rows[0]["E_PICTURE"].ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = selectedImage;
            }
        }


        private void screenclear()
        {
            EventIDTB.Text = "";
            EventTB.Text = "";
            DateTB.Text = "";
            PriceTB.Text = "";

            pictureBox1.Image = null;
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            screenclear();
        }

        private void CustomerIDTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
