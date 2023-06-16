using bilet_satis.DbCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilet_satis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int updateUserId = -1;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vs_projeDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.vs_projeDataSet.users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new EzgiEntities())
            {
                if (updateUserId == -1)
                {
                    users user = new users();
                    user.NAME = textBox1.Text;
                    user.PHONE = textBox2.Text;

                    db.users.Add(user);

                    db.SaveChanges();

                    MessageBox.Show("Kayıt Başarılı");

                    ListeGuncelleme();
                }
                else
                {
                    users user = db.users.FirstOrDefault(x => x.ID == updateUserId);
                    user.NAME = textBox1.Text;
                    user.PHONE = textBox2.Text;

                    db.SaveChanges();

                    MessageBox.Show("Güncelleme Başarılı");

                    ListeGuncelleme();

                    updateUserId = -1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListeGuncelleme();
        }

        
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var user = listBox1.SelectedItem as users;

            updateUserId = user.ID;
            textBox1.Text = user.NAME;
            textBox2.Text = user.PHONE;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var user = listBox1.SelectedItem as users;

            using (var db = new EzgiEntities())
            {
                var users = db.users.FirstOrDefault(x => x.ID == user.ID);

                db.users.Remove(users);

                db.SaveChanges();
            }

            ListeGuncelleme();
        }

        public void ListeGuncelleme()
        {
            using (var db = new EzgiEntities())
            {
                var users = db.users.ToList();

                listBox1.DataSource = null;
                listBox1.DataSource = users;
                //foreach (var item in users)
                //{
                //    listBox1.Items.Add(item.NAME + "\t" + item.PHONE);
                //}
            }
        }
    }
}
