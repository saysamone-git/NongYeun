using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class management_data : Form
    {
        public management_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // ເຮົາຂຽນ
        public void userControl(UserControl ctr, Panel parent)
        {
            parent.Controls.Clear();
            ctr.Dock = DockStyle.Fill;
            parent.Controls.Add(ctr);
            parent.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var UserControl1 = new UserAdmin();
            userControl(UserControl1, panelContainer);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UserAdmin frm2 = new UserAdmin();
            userControl(frm2, panelContainer);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
