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
    public partial class ArrayUi : Form
    {
        public ArrayUi()
        {
            InitializeComponent();
        }
        int i = 0;
       
        string[] weekDaysName = new string[7];
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                weekDaysName[i] = addTextBox.Text;

                i++;
                firstArrayTextBox.Text = " ";
                for (int a = 0; a < i; a++)
                {
                    firstArrayTextBox.Text = firstArrayTextBox.Text + weekDaysName[a] + "\n";
                }
            }
            catch(Exception array)
            {
                MessageBox.Show(array.Message);
            }
        }
        string[] weekDaysNameClone = new string[7];
        private void button5_Click(object sender, EventArgs e)
        {

            try
            {

            
            for (int m = 0; m < 7; m++)

            { weekDaysNameClone[m] = weekDaysName[m]; }
            
            cloneTextBox.Text = " ";
            for(int a=0;a<i;a++)
            {
                cloneTextBox.Text = cloneTextBox.Text + weekDaysNameClone[a] + "\n";
            }
                }
            catch (Exception array)
            {
                MessageBox.Show(array.Message);
            }

        }

        
        private void oddbutton_Click(object sender, EventArgs e)
        {
            string[] oddArray = new string[7];
            try
            {
                int y;
                for ( y = 0; y < 7; y = y + 2)
                {
                    oddArray[y] = weekDaysNameClone[y];
                }
                oddTextBox.Text = " ";
                for (int a = 0; a <= y - 2; a=a+2)
                {
                   oddTextBox.Text=oddTextBox.Text+oddArray[a]+"\n";
                }
            }
            catch(Exception array)
            {
                MessageBox.Show(array.Message);
            }
        }

        private void evenbutton_click(object sender, EventArgs e)
        {
            string[] evenArray = new string[7];
            try
            {
                int y;
                for (y = 1; y < 7; y = y + 2)
                {
                    evenArray[y] = weekDaysNameClone[y];
                }
                evenTextBox.Text = " ";
                for (int a = 1; a <= y-2; a=a+2)
                {
                    evenTextBox.Text=evenTextBox.Text+evenArray[a]+"\n";
                }
            }
            catch (Exception array)
            {
                MessageBox.Show(array.Message);
            }
        }
    }
}
