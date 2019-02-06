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
    public partial class CustomerInformationListUi : Form
    {
        public CustomerInformationListUi()
        {
            InitializeComponent();
        }
        List<string> customerName = new List<string>();
        List<string> contactNo = new List<string>();
        List<string> address = new List<string>();
        List<int> quantitys = new List<int>();
        List<double> prices = new List<double>();
        List<string> order = new List<string>();
        int k = 0;
        private void save_click(object sender, EventArgs e)
        {
            if (customerName.Contains(customerNameTextBox.Text) || contactTextBox.Text.Length != 11)
            {
                if (customerName.Contains(customerNameTextBox.Text))
                    MessageBox.Show("Customer Already Exists");
                else
                    MessageBox.Show("Contact No Must Be 11 digit");

            }
            else
            {
                customerName.Add(customerNameTextBox.Text);
                contactNo.Add(contactTextBox.Text);
                address.Add(addressTextBox.Text);
                quantitys.Add(Convert.ToInt32(quantityTextBox.Text));
                order.Add(orderComboBox.Text);

                try
                {
                  for (int a = k; a == k;a-- )
                  {
                        if (orderComboBox.Text == "Math")
                        { prices.Add(Convert.ToInt32(quantityTextBox.Text) * 120); }
                        else if (orderComboBox.Text == "English")
                        { prices.Add(Convert.ToInt32(quantityTextBox.Text) * 100); }
                        else if (orderComboBox.Text == "Bangla")
                        { prices.Add(Convert.ToInt32(quantityTextBox.Text) * 90); }
                        else if (orderComboBox.Text == "Art")
                        { prices.Add(Convert.ToInt32(quantityTextBox.Text) * 80); }
                        else
                            prices.Add(Convert.ToInt32(""));

                        resultRichTextBox.Text = resultRichTextBox.Text + "\t\t\t\t--------Customer Information------" +
                                "\n\n\tName:" + customerName[a] +
                                "\n\n\tContact:  " + contactNo[a] +
                                "\n\n\tAddress  :" + address[a] +
                                "\n\n\tOrder  :" + order[a] +
                                "\n\n\tQuantity:  " + quantitys[a] +
                                "\n\n\tPrice:" + prices[a] + "\n";
                    }
                    k++; 
                }

                catch(Exception arr)
                {
                    MessageBox.Show(arr.Message);
                }
                
            }
        }
    }
}
