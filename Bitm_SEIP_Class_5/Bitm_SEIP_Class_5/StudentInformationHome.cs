using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitm_SEIP_Class_5
{
    public partial class StudentInformationHome : Form
    {
        List<int>ids=new List<int>();
        List<string>names=new List<string>();
        List<string>mobiles=new List<string>();
        List<int>ages=new List<int>();
        List<string>addresses=new List<string>();
        List<double>gpas=new List<double>();
        public StudentInformationHome()
        {
            InitializeComponent();
        }

        private void AddInfo(int id,string name,string mobile,double gpa)
        {
            ids.Add(id);
            names.Add(name);
            mobiles.Add(mobile);
            ages.Add(Convert.ToInt32(ageTextBox.Text));
            addresses.Add(addressTextBox.Text);
            gpas.Add(gpa);
            string see = "";
            for (int i = 0; i < ids.Count(); i++)
            {
                see += "\nID: " + ids[i] +"\n";
                see += "Name: " + names[i] + "\n";
                see += "Mobile: " + mobiles[i] + "\n";
                see += "Age: " + ages[i] + "\n";
                see += "Address" + addresses[i] + "\n";
                see += "GPA: " + gpas[i] + "\n";

            }

            MessageBox.Show("Information Saved Successfully");
            informationRichTextBox.Text += (see);


        }

        private void ShowInfo()
        {
            
            string see = "";
            for (int i = 0; i < ids.Count(); i++)
            {
                see += "\nID: " + ids[i] + "\n";
                see += "Name: " + names[i] + "\n";
                see += "Mobile: " + mobiles[i] + "\n";
                see += "Age: " + ages[i] + "\n";
                see += "Address: " + addresses[i] + "\n";
                see += "GPA: " + gpas[i] + "\n";

            }
            int totalAdded = ids.Count();

            informationRichTextBox.Text += ("\nTotal Number of Customer: "+totalAdded +"\n" +see);
        }
        private void GPAInfo()
        {
            double max = gpas.Max();
            double min = gpas.Min();
            double total = gpas.Sum();
            int cnt = gpas.Count();
            double average = total / cnt;
            averageTextBox.Text = Convert.ToString(average);
            totalTextBox.Text = Convert.ToString(total);
            try
            {
                if (gpas.Contains(max))
                {
                    maxTextBox.Text = Convert.ToString(max);
                    int i = gpas.IndexOf(max);
                    maxNameTextBox.Text =Convert.ToString(names[i]);
                }
                if (gpas.Contains(min))
                {
                    minTextBox.Text = Convert.ToString(min);
                    int j = gpas.IndexOf(min);
                    minNameTextBox.Text = Convert.ToString(names[j]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            informationRichTextBox.Text = "Information";
            try
            {
                if (ids.Contains(Convert.ToInt32(idTextBox.Text)) == true)
                {
                    MessageBox.Show("ID Already Exist");

                }
                else if ((idTextBox.Text).Length < 4)
                {
                    MessageBox.Show("ID Must Be 4 Characters");
                }
                else if ((idTextBox.Text).Length > 4)
                {
                    MessageBox.Show("ID Must Be 4 Characters");
                }
                else if ((nameTextBox.Text).Length > 30)
                {
                    MessageBox.Show("Name Must Be 30 Characters");
                }

                else if (mobiles.Contains(mobileTextBox.Text) == true)
                {
                    MessageBox.Show("Number Already Exist");
                }
                else if ((mobileTextBox.Text).Length > 11)
                {
                    MessageBox.Show("Number Must Be 11 Digit");
                }
                else if ((mobileTextBox.Text).Length < 11)
                {
                    MessageBox.Show("Number Must Be 11 Digit");
                }
                else if (Convert.ToDouble(gpaTextBox.Text) < 0)
                {
                    MessageBox.Show("GPA Must Be Greater Than 0");
                }
                else if (Convert.ToDouble(gpaTextBox.Text) > 4)
                {
                    MessageBox.Show("GPA Must Be Less Than 4");
                }
                else
                {
                    AddInfo(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, mobileTextBox.Text, Convert.ToDouble(gpaTextBox.Text));
                }

                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }
            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            gpaTextBox.Text = "";

        }

        private void SearchInfo()
        {
            if (idRadioButton.Checked)
            {

                try
                {
                    if (ids.Contains(Convert.ToInt32(idTextBox.Text)))
                    {
                        int i = ids.IndexOf(Convert.ToInt32(idTextBox.Text));
                        string see = "";
                        see += "\nID: " + ids[i] + "\n";
                        see += "Name: " + names[i] + "\n";
                        see += "Mobile: " + mobiles[i] + "\n";
                        see += "Age: " + ages[i] + "\n";
                        see += "Address" + addresses[i] + "\n";
                        see += "GPA: " + gpas[i] + "\n";

                        informationRichTextBox.Text += (see);
                    }
                    else
                    {
                        MessageBox.Show("ID Not Exists");
                    }
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
            }
            else if (nameRadioButton.Checked)
            {
                try
                {
                    if (names.Contains(nameTextBox.Text))
                    {
                        int i = names.IndexOf(nameTextBox.Text);
                        string see = "";
                        see += "\nID: " + ids[i] + "\n";
                        see += "Name: " + names[i] + "\n";
                        see += "Mobile: " + mobiles[i] + "\n";
                        see += "Age: " + ages[i] + "\n";
                        see += "Address" + addresses[i] + "\n";
                        see += "GPA: " + gpas[i] + "\n";

                        informationRichTextBox.Text += (see);
                    }
                    else
                    {
                        MessageBox.Show("Name Not Exists");
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else if (mobileRadioButton.Checked)
            {
                try
                {
                    if (mobiles.Contains(mobileTextBox.Text))
                    {
                        int i = mobiles.IndexOf(mobileTextBox.Text);
                        string see = "";
                        see += "\nID: " + ids[i] + "\n";
                        see += "Name: " + names[i] + "\n";
                        see += "Mobile: " + mobiles[i] + "\n";
                        see += "Age: " + ages[i] + "\n";
                        see += "Address" + addresses[i] + "\n";
                        see += "GPA: " + gpas[i] + "\n";

                        informationRichTextBox.Text += (see);
                    }
                    else
                    {
                        MessageBox.Show("Mobile Number Not Exists");
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }

        }
        private void showButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            gpaTextBox.Text = "";
            informationRichTextBox.Text = "Information";
            try
            {
                ShowInfo();
                GPAInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            informationRichTextBox.Text = "Information";
            try
            {
                SearchInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
