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
    public partial class StudentMenuCtr : UserControl
    {
        public StudentMenuCtr()
        {
            InitializeComponent();
            StudentOptCtr studentOpt = new StudentOptCtr();
            userControl(studentOpt, panelContainer);
        }

        public void userControl(UserControl ctr, Panel parent)
        {
            parent.Controls.Clear();
            ctr.Dock = DockStyle.Fill;
            parent.Controls.Add(ctr);
            parent.Refresh();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StudentOptCtr studentOpt = new StudentOptCtr();
            userControl(studentOpt, panelContainer);
        }
    }
}
