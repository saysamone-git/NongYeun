﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NongYuen
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btregister_Click(object sender, EventArgs e) 
        {

            //DbAccess.DbConnect.connect();
         /*   register regis = new register();
            regis.Show();
            this.Hide();*/
           
        }
        private void btmdata_Click(object sender, EventArgs e)
        {
           

        }
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }
    }
}
