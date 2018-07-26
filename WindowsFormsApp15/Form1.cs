using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Type user1 = Form2.user.GetType();
        int count = 0;

        List<ListViewItem> users = new List<ListViewItem>();
        Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            
            form2.ShowDialog();
            // users.Add(Form2.user);
            ListViewItem list = new ListViewItem((++count).ToString());
            foreach (var item in user1.GetProperties())
            {
                list.SubItems.Add(item.GetValue(Form2.user).ToString());
            }
            listView1.Items.Add(list);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Number");
            foreach (var item in user1.GetProperties())
            {
                listView1.Columns.Add(item.Name);
                comboBox1.Items.Add(item.Name);
            }

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.Clear();
            listView1.SelectedItems[0].Remove();
            count = 0;
            var items = listView1.Items;

            foreach (ListViewItem item in items)
            {
                users.Add(item);
            }
            listView1.Items.Clear();

            foreach (var item in users)
            {
                item.SubItems[0].Text = (++count).ToString();
                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)  //Update
        {
         
            Form2.user.Username = listView1.SelectedItems[0].SubItems[1].Text;
            Form2.user.Password = listView1.SelectedItems[0].SubItems[2].Text;
            Form2.user.Phone = listView1.SelectedItems[0].SubItems[3].Text;
            Form2.user.Birtdate = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[4].Text);
            form2.ShowDialog();

            listView1.SelectedItems[0].SubItems[1].Text = Form2.user.Username;
            listView1.SelectedItems[0].SubItems[2].Text = Form2.user.Password;
            listView1.SelectedItems[0].SubItems[3].Text = Form2.user.Phone;
            listView1.SelectedItems[0].SubItems[4].Text = Form2.user.Birtdate.ToString();

         
        }

        private void Search_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Username": users.Where(x=>x. break;/////////////// burda qalmisham
            }
            
        }
    }
}
