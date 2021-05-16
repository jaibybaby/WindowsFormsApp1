using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (txtAge.Text == "")
            {
                MessageBox.Show("Please Enter Age");
            }
            else if (!Regex.Match(txtAge.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("Enter a Valid Number");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "")
            {
                MessageBox.Show("Please Enter Name");
            }
            else if (Regex.Match(txtPatientName.Text, "^[a-zA-Z ]*$").Success)
            {
                MessageBox.Show("Enter a Valid Name");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Email");
            }
            else if (!Regex.Match(txtEmail.Text, "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9+_.-]+$").Success)
            {
                MessageBox.Show("Enter a Valid Email");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text == "" && txtEmail.Text == "" && txtAge.Text == "" && txtMedicineDosage.Text == "")
            {
                MessageBox.Show("Enter All The Fields");
            }
            else if (txtEmail.Text == "" && txtAge.Text == "" && txtMedicineDosage.Text == "")
            {
                MessageBox.Show("Please Enter Age , Email & Medicine");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Email");
            }
            else if (txtAge.Text == "" && txtMedicineDosage.Text == "")
            {
                MessageBox.Show("Please Enter Age & Medicine");
            }
            else if (txtMedicineDosage.Text == "")
            {
                MessageBox.Show("Please Enter Medicine Dosage");
            }
            else if (txtAge.Text == "")
            {
                MessageBox.Show("Please Enter Age");
            }
            //else if (rdbtnChainsmokerNo.Checked == true || rdbtnChainsmokerYes.Checked == true)
            //{
            //    MessageBox.Show("Are you a chainsmoker? please select");
            //}
            else if (Convert.ToInt32(txtAge.Text) >= 4 && Convert.ToInt32(txtAge.Text) <= 18 && rdbtnChainsmokerYes.Checked == true)
            {
                if (Convert.ToInt32(txtMedicineDosage.Text) <= 2.5 && Convert.ToInt32(txtMedicineDosage.Text) >= 2)
                {
                    MessageBox.Show("Approved");
                }
                else
                {
                    MessageBox.Show("wrong medicine dosage! 2-2.5 doses needed");
                }
            }
            else if (rdbtnChainsmokerYes.Checked == true && Convert.ToInt32(txtAge.Text) >= 19 && Convert.ToInt32(txtAge.Text) <= 55)
            {
                if (Convert.ToDecimal(txtMedicineDosage.Text) >= 1 && Convert.ToDecimal(txtMedicineDosage.Text) <= 2)
                {
                    MessageBox.Show("Approved");
                }
                else
                {
                    MessageBox.Show("wrong medicine dosage!  1-2 doses needed");
                }
            }
            else if (rdbtnChainsmokerYes.Checked == false && Convert.ToInt32(txtAge.Text) >= 4 && Convert.ToInt32(txtAge.Text) <= 18)
            {
                if (Convert.ToDecimal(txtMedicineDosage.Text) >= 1 && Convert.ToDouble(txtMedicineDosage.Text) <= 2.2)
                {
                    MessageBox.Show("Correct Medicine You Opted");
                }
                else
                {
                    MessageBox.Show("wrong medicine dosage!  1-2.2 doses needed");
                }
            }
            else if (rdbtnChainsmokerYes.Checked == false && Convert.ToInt32(txtAge.Text) >= 19 && Convert.ToInt32(txtAge.Text) <= 30)
            {
                if (Convert.ToDouble(txtMedicineDosage.Text) >= 2.3 && Convert.ToDouble(txtMedicineDosage.Text) <= 4.4)
                {
                    MessageBox.Show("Correct Medicine You Opted");
                }
                else
                {
                    MessageBox.Show("wrong medicine dosage!  2.3-4.4 doses needed");
                }
            }
            else if (rdbtnChainsmokerYes.Checked == false && Convert.ToInt32(txtAge.Text) >= 31 && Convert.ToInt32(txtAge.Text) <= 55)
            {
                if (Convert.ToDouble(txtMedicineDosage.Text) >= 4.4 && Convert.ToDecimal(txtMedicineDosage.Text) <= 6)
                {
                    MessageBox.Show("Correct Medicine You Opted");
                }
                else
                {
                    MessageBox.Show("wrong medicine dosage!  4.4-6 doses needed");
                }
            }
            else if (rdbtnChainsmokerYes.Checked == false && Convert.ToInt32(txtAge.Text) >= 55)
            {
                if (Convert.ToDouble(txtMedicineDosage.Text) >= 3.3 && Convert.ToDouble(txtMedicineDosage.Text) <= 4.5)
                {
                    MessageBox.Show("Correct Medicine You Opted");
                }
                else
                {
                    MessageBox.Show("wrong medicine dosage!  3.3-4.5 doses needed");
                }
            }
            else
            {
                MessageBox.Show("Successfully Added");
            }


        }

        private void txtMedicineDosage_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

