using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NongYuen.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StudentMenuCtr studentMenuForm = new StudentMenuCtr();
            userControl(studentMenuForm, MainContainer);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            StudentMenuCtr studentMenuForm = new StudentMenuCtr();
            userControl(studentMenuForm, MainContainer);
        }

        public void userControl(UserControl ctr, Panel parent)
        {
            parent.Controls.Clear();
            ctr.Dock = DockStyle.Fill;
            parent.Controls.Add(ctr);
            parent.Refresh();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
