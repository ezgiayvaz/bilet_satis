using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilet_satis
{
    public partial class LoginForm : Form
    {
        SqlConnection SqlConn = new SqlConnection("Server=DESKTOP-1TVNHPO;Database=TM_DB;Trusted_Connection=True");
        DataSet dataSet = new DataSet();
        SqlDataAdapter DataAdapter;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void userlist()
        {
            if (dataSet.Tables["User"] != null)
            {
                dataSet.Tables.Remove("User");
            }
            string queryString = "SELECT * FROM [User] WHERE USERNAME = @username AND PASSWORD = @password";
            DataAdapter = new SqlDataAdapter(queryString, SqlConn);
            DataAdapter.SelectCommand.Parameters.AddWithValue("@username", UsernameTB.Text);
            DataAdapter.SelectCommand.Parameters.AddWithValue("@password", UserpasswordTB.Text);
            DataAdapter.Fill(dataSet, "User");
        }


        private void LoginBT_Click(object sender, EventArgs e)
        {
            userlist();
            if (dataSet.Tables["User"].Rows.Count > 0)
            {
                SaleForm saleForm = new SaleForm();
                saleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileri Hatalı!");
            }
        }

        private void UserBT_Click_1(object sender, EventArgs e)
        {
            userlist();
            if (dataSet.Tables["User"].Rows.Count > 0)
            {
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileri Hatalı!");
            }
        }
    }
}


