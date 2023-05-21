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
    public partial class StudentOptCtr : UserControl
    {
        public StudentOptCtr()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();    
        }
    }
}
