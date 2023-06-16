using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilet_satis
{
    public partial class EventForm : Form
    {
        SqlConnection SqlConn = new SqlConnection("Server=DESKTOP-1TVNHPO;Database=TM_DB;Trusted_Connection=True");
        SqlCommand Command;
        DataSet dataSet = new DataSet();
        SqlDataAdapter DataAdapter;

        public EventForm()
        {
            InitializeComponent();
            EventList();
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

        private void formtemizle()
        {
            IdTB.Text = "";
            NameTB.Text = "";
            pictureBox1.Image = null;
        }



        private void PictureSelectBT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Resim Seç";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    imagePathTB.Text = selectedImagePath;
                    Image selectedImage = Image.FromFile(selectedImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = selectedImage;
                }
            }
        }

        private void dataGridViewEventList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                IdTB.Text = dataGridViewEventList.SelectedRows[0].Cells["id"].Value.ToString();
                NameTB.Text = dataGridViewEventList.SelectedRows[0].Cells["E_NAME"].Value.ToString();
                DescriptionTB.Text=dataGridViewEventList.SelectedRows[0].Cells["E_DESCRIPTION"].Value.ToString();
                StartDate.Text= dataGridViewEventList.SelectedRows[0].Cells["E_START_DATE"].Value.ToString();
                EndDate.Text = dataGridViewEventList.SelectedRows[0].Cells["E_END_DATE"].Value.ToString();
                KontenjanTB.Text = dataGridViewEventList.SelectedRows[0].Cells["E_TICKET_LIMIT"].Value.ToString();
                PriceTB.Text = dataGridViewEventList.SelectedRows[0].Cells["E_TICKET_PRICE"].Value.ToString();

                Image selectedImage = Image.FromFile(dataGridViewEventList.SelectedRows[0].Cells["E_PICTURE"].Value.ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = selectedImage;

            }
            catch (Exception)
            {
            }
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            if (dataSet.Tables["Event"] != null)
            {
                dataSet.Tables.Remove("Event");
            }
            DataAdapter = new SqlDataAdapter("select * from Event where id=@id", SqlConn);
            DataAdapter.SelectCommand.Parameters.Clear();
            DataAdapter.SelectCommand.Parameters.AddWithValue("@id", IdTB.Text);
            DataAdapter.Fill(dataSet, "Event");
            if (dataSet.Tables["Event"].Rows.Count > 0)
            {
                Command = new SqlCommand("UPDATE EVENT SET E_NAME=@E_NAME, E_DESCRIPTION=@E_DESCRIPTION, E_START_DATE=@E_START_DATE, E_END_DATE=@E_END_DATE, E_TICKET_LIMIT=@E_TICKET_LIMIT, E_TICKET_PRICE=@E_TICKET_PRICE, E_PICTURE=@E_PICTURE WHERE ID=@ID", SqlConn);
            }
            else
            {
                Command = new SqlCommand("INSERT INTO EVENT (E_NAME,E_DESCRIPTION, E_START_DATE, E_END_DATE, E_TICKET_LIMIT, E_TICKET_PRICE, E_PICTURE) VALUES(@E_NAME,@E_DESCRIPTION, @E_START_DATE, @E_END_DATE, @E_TICKET_LIMIT, @E_TICKET_PRICE, @E_PICTURE)", SqlConn);
            }

            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("@ID", IdTB.Text);
            Command.Parameters.AddWithValue("@E_NAME", NameTB.Text);
            Command.Parameters.AddWithValue("@E_DESCRIPTION", DescriptionTB.Text);
            Command.Parameters.AddWithValue("@E_START_DATE", StartDate.Value);
            Command.Parameters.AddWithValue("@E_END_DATE", EndDate.Value);
            Command.Parameters.AddWithValue("@E_TICKET_LIMIT", Convert.ToInt16(KontenjanTB.Text));
            Command.Parameters.AddWithValue("@E_TICKET_PRICE", Convert.ToDouble(PriceTB.Text));
            Command.Parameters.AddWithValue("@E_PICTURE", imagePathTB.Text);

            SqlConn.Open();
            Command.ExecuteNonQuery();
            SqlConn.Close();
            formtemizle();
            EventList();
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silme işlemini onaylıyormusunuz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Command = new SqlCommand("delete from Event where id=@id", SqlConn);
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@id", dataGridViewEventList.SelectedRows[0].Cells["ID"].Value);
                SqlConn.Open();
                Command.ExecuteNonQuery();
                SqlConn.Close();
                formtemizle();
                EventList();
            }
        }

        private void NewEventBT_Click(object sender, EventArgs e)
        {
            formtemizle();
        }
    }
}

