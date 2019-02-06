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
    public partial class CustomerInformainArrayUi : Form
    {
        public CustomerInformainArrayUi()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        string[] customerName = new string[10];
        string[] contactNo = new string[10];
        string[] address = new string[10];
        string[] quantity = new string[10];
        string[] order = new string[10];
        string[] price = new string[10];

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            
            customerName[i] = customerNameTextBox.Text;
            contactNo[i] = contactTextBox.Text;
            address[i] = addressTextBox.Text;
            quantity[i] = quantityTextBox.Text;
            order[i] = orderComboBox.Text;
            
            try
            {
                for (int a =i; a==i; a-- )
                {
                    int priceTemp;
                    if (orderComboBox.Text == "Math")
                    { priceTemp = Convert.ToInt32(quantityTextBox.Text) * 120; }
                    else if (orderComboBox.Text == "English")
                    { priceTemp = Convert.ToInt32(quantityTextBox.Text) * 100; }
                    else if (orderComboBox.Text == "Bangla")
                    { priceTemp = Convert.ToInt32(quantityTextBox.Text) * 90; }
                    else if (orderComboBox.Text == "Art")
                    { priceTemp = Convert.ToInt32(quantityTextBox.Text) * 80; }
                    else
                        priceTemp = 0;

                    price[a] = Convert.ToString(priceTemp);

                    resultRichTextBox.Text = resultRichTextBox.Text + "\t\t\t\t--------Customer Information------" +
                        "\n\n\tName:" + customerName[a] +
                        "\n\n\tContact:  " + contactNo[a] +
                        "\n\n\tAddress  :" + address[a] +
                        "\n\n\tOrder  :" + order[a] +
                        "\n\n\tQuantity:  " + quantity[a] +
                        "\n\n\tPrice:" + price[a] + "\n";
                    
                }
                i++;
            }
            catch (Exception array)
            {
                MessageBox.Show(array.Message);
            }
              
             
             
            
            
        
        }

        private void save_button_click(object sender, EventArgs e)
        {

        }

                
                
        }
    }

