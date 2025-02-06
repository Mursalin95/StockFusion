using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockFusion
{
    public partial class User1 : Form
    {
        public User1()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp("Manager");
            signUp.Show();
            this.Hide();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp("FinancialManager");
            signUp.Show();
            this.Hide();
        }
    }
}

