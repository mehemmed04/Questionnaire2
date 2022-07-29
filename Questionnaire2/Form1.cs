using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire2
{
    public partial class Form1 : Form
    {
        List<Customer> customerList = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
            CustomersLstBx.DataSource = customerList;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = nameTxtb.Text;
            customer.Surname = surnameTxtb.Text;
            customer.Email = emailTxtb.Text;
            customer.Phone = phonenumberTxtb.Text;
            customer.Birthday = birthdayMtxtb.Text;
            customerList.Add(customer);
            CustomersLstBx.DataSource = null;
            CustomersLstBx.DataSource = customerList;
            CustomersLstBx.SelectedIndex = 0;
            CustomersLstBx.DisplayMember = nameof(Customer.Name);
            foreach (var item in QuestionnaireGrpBx.Controls)
            {
                if (item is TextBox txtb)
                {
                    txtb.Text = string.Empty;
                }
                else if (item is MaskedTextBox Mtxtb)
                {
                    Mtxtb.Text = string.Empty;
                }
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string filename = filenameTxtb.Text;
            FileHelper.WriteToJson(customerList, filename);
            resultLbl.ForeColor = Color.Green;
            resultLbl.Text = "Saved succesfully";
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string filename = filenameTxtb.Text;
            if (File.Exists(filename + ".json"))
            {
                customerList = FileHelper.ReadFromJson(filename);
                CustomersLstBx.DataSource = customerList;
                resultLbl.ForeColor = Color.Green;
                resultLbl.Text = "Loaded succesfully";
            }
            else
            {
                resultLbl.ForeColor = Color.Red;
                resultLbl.Text = "Can not loaded";
            }
        }
    }
}
