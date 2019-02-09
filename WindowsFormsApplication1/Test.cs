using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        List<string> email = new List<string>();
        private void save_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(emailTextBox.Text) )
            {
                emailLabel.Text = "Can't be Empty";
                
            }
            else if(!emailTextBox.Text.Contains("@"))
            {
                emailLabel.Text= "Should be In Correct Format";
            }

            else{
                emailLabel.Text = "";
                email.Add(emailTextBox.Text);
                MessageBox.Show("Saved Data ");
            }
        }
    }
}
