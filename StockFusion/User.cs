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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

    

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp("Admin");
            signUp.Show();
            this.Hide();

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp("Customer");
            signUp.Show();
            this.Hide();
        }
        private void roundedButton3_Click(object sender, EventArgs e)
        {
            User1 user1 = new User1();
            user1.Show();
            this.Hide();
        }
    }
}
