using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using NongYuen.View;

namespace NongYuen;

public partial class LogIn : Form
{
    public LogIn()
    {
        InitializeComponent();
    }
    private void btlogin_Click(object sender, EventArgs e)
    {
        new MainForm().Show();
    }

    private void logIn()
    {
        MessageBox.Show("");
    }

    private void btclearfields_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void LogIn_Load(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }
}
