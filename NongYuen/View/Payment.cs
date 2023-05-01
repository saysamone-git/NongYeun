using System;
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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void group_register1_Enter(object sender, EventArgs e)
        {

        }

        private void btregister1_Click(object sender, EventArgs e)
        {
;
            this.Hide();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            group_payment.Enabled = false;
            btSAVE.Enabled = false;
            btclear.Enabled = false;

        }

        private void btinsert1_Click(object sender, EventArgs e)
        {
            group_payment.Enabled = true;
            btSAVE.Enabled = true;
            btclear.Enabled = true;

        }

        private void btclear_Click(object sender, EventArgs e)
        {
            combo_sttype.Text = "";
            comboclassroom1.Text = "";
            comboclass1.Text = "";
            combyear1.Text = "";
            date_register.Text = "";
            txt_stid.Clear();
            txt_stname.Clear();
            txt_tatolcost.Clear();
            txt_paidmoney.Clear();
            txt_pay.Clear();
            txt_payment.Clear();
            txt_change.Clear();
            txt_registerid.Clear();


        }

        private void exit_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();

        }
    }
}
