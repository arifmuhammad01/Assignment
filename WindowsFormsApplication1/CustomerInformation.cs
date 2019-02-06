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
    public partial class CustomerInformation : Form
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int price;
            if (orderComboBox.Text == "Math")
            { price = Convert.ToInt32(quantityTextBox.Text) * 120; }
            else if (orderComboBox.Text == "English")
            { price = Convert.ToInt32(quantityTextBox.Text) * 100; }
            else if (orderComboBox.Text == "Bangla")
            { price = Convert.ToInt32(quantityTextBox.Text) * 90; }
            else if (orderComboBox.Text == "Art")
            { price = Convert.ToInt32(quantityTextBox.Text) * 80; }
            else
                price = 0;

            resultRichTextBox.Text = resultRichTextBox.Text + "\t\t\t\t--------Customer Information------" +
                       "\n\n\tName:" + customerNameTextBox.Text +
                       "\n\n\tContact:  " + contactTextBox.Text +
                       "\n\n\tAddress  :" + addressTextBox.Text +
                       "\n\n\tOrder  :" + orderComboBox.Text +
                       "\n\n\tQuantity:  " + quantityTextBox.Text +
                       "\n\n\tPrice:" + price + "\n";
        }
    }
}
