using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;

namespace bilet_satis
{
    public partial class UserForm : Form
    {
        SqlConnection SqlConn = new SqlConnection("Server=DESKTOP-1TVNHPO;Database=TM_DB;Trusted_Connection=True");
        SqlCommand Command;
        DataSet dataSet = new DataSet();
        SqlDataAdapter DataAdapter;

        public UserForm()
        {
            InitializeComponent();
        }

        private void formtemizle()
        {
            MemberCodeTB.Text = "";
            MemberTB.Text = "";
            MemberPasswordTB.Text = "";
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {

            if (dataSet.Tables["User"] != null)
            {
                dataSet.Tables.Remove("User");
            }
            DataAdapter = new SqlDataAdapter("SELECT * FROM [USER] WHERE USERNAME=@USERNAME", SqlConn);
            DataAdapter.SelectCommand.Parameters.Clear();
            DataAdapter.SelectCommand.Parameters.AddWithValue("@USERNAME", MemberCodeTB.Text);
            DataAdapter.Fill(dataSet, "User");
            if (dataSet.Tables["User"].Rows.Count > 0)
            {
                Command = new SqlCommand("UPDATE [USER] SET FULLNAME=@FULLNAME, PASSWORD=@PASSWORD WHERE USERNAME=@USERNAME", SqlConn);
            }
            else
            {
                Command = new SqlCommand("INSERT INTO [USER] (USERNAME, FULLNAME, PASSWORD) VALUES (@USERNAME, @FULLNAME, @PASSWORD)", SqlConn);
            }
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("@USERNAME", MemberCodeTB.Text);
            Command.Parameters.AddWithValue("@FULLNAME", MemberTB.Text);
            Command.Parameters.AddWithValue("@PASSWORD", MemberPasswordTB.Text);

            SqlConn.Open();
            Command.ExecuteNonQuery();
            SqlConn.Close();

            MessageBox.Show("Kayıt işlemi tamamlandı.");

        }

        private void MemberCodeTB_Leave(object sender, EventArgs e)
        {
            if (dataSet.Tables["User"] != null)
            {
                dataSet.Tables.Remove("User");
            }
            DataAdapter = new SqlDataAdapter("SELECT * FROM [USER] WHERE USERNAME=@USERNAME", SqlConn);
            DataAdapter.SelectCommand.Parameters.Clear();
            DataAdapter.SelectCommand.Parameters.AddWithValue("@USERNAME", MemberCodeTB.Text);
            DataAdapter.Fill(dataSet, "User");
            if (dataSet.Tables["User"].Rows.Count > 0)
            {
                MemberTB.Text = dataSet.Tables["User"].Rows[0]["FULLNAME"].ToString();
                MemberPasswordTB.Text= dataSet.Tables["User"].Rows[0]["PASSWORD"].ToString();
            }
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silme işlemini onaylıyormusunuz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Command = new SqlCommand("delete from [User] where username=@username", SqlConn);
                Command.Parameters.Clear();
                SqlConn.Open();
                Command.ExecuteNonQuery();
                SqlConn.Close();
                formtemizle();
                
            }
        }
    }
}
