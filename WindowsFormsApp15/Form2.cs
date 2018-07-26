﻿using System;
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
    public partial class Form2 : Form
    {
        public static User user = new User();
        public Form2()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            user.Username = Username.Text;
            user.Password = Password.Text;
            user.Phone = Phone.Text;
            user.Birtdate = Birtdate.Value;
            Close();
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public DateTime Birtdate { get; set; } = DateTime.Now;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Username.Text=user.Username;
            Password.Text=user.Password;
            Phone.Text=user.Phone;
            Birtdate.Text = user.Birtdate.ToString();
        }
    }
}
