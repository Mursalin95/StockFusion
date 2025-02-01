using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls.RoundedButton;

namespace StockFusion
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle the text changed event here
        }
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
        private void roundedButton3_Click(object sender, EventArgs e)
        {
            Forget forget = new Forget();
            forget.Show();
            this.Hide();

        }
        private void Show_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
