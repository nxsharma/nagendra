using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private string fileName;

        public Form1()
        {
            InitializeComponent();

            fileName = "./personList.csv";
        }

        private void radStaff_CheckedChanged(object sender, EventArgs e)
        {
            grpStaff.Enabled = radStaff.Checked;
        }

        private void radFaculty_CheckedChanged(object sender, EventArgs e)
        {
            grpFaculty.Enabled = radFaculty.Checked;
        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            grpStudent.Enabled = radStudent.Checked;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TextBox[] personal = { txtID, txtFirstName, txtLastName, txtAge };
            TextBox[] faculty = { txtDivision, txtHours };
            TextBox[] staff = { txtPosition, txtSalary };
            TextBox[] student = { txtMajor, txtGPA };
            TextBox[][] textBoxes = { personal, faculty, staff, student };

            foreach(TextBox[] boxes in textBoxes)
            {
                foreach(TextBox b in boxes)
                {
                    b.Text = String.Empty;
                }
            }

            txtDisplay.Text = String.Empty;

            radFaculty.Checked = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = String.Empty;

            string id = txtID.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age;
            Person p;

            RadioButton[] rads = { radFaculty, radStaff, radStudent };
            string role = "";

            foreach(RadioButton rad in rads)
            {
                if(rad.Checked)
                {
                    role = rad.Text;
                }
            }

            try
            {
                if (txtAge.Text == String.Empty)
                    throw new EmptyStringException("Age");
                if (!Int32.TryParse(txtAge.Text, out age))
                    throw new NonNumericValueException("Age");

                switch (role)
                {
                    case "Faculty":
                        string division = txtDivision.Text;
                        if (txtHours.Text == String.Empty)
                            throw new EmptyStringException("Hours");

                        double hours;
                        if (!Double.TryParse(txtHours.Text, out hours))
                            throw new NonNumericValueException("Hours");

                        p = new Faculty(id, firstName, lastName, age, division, hours);
                        break;
                    case "Staff":
                        string position = txtPosition.Text;
                        if (txtSalary.Text == String.Empty)
                            throw new EmptyStringException("Salary");

                        double salary;
                        if (!Double.TryParse(txtSalary.Text, out salary))
                            throw new NonNumericValueException("Salary");

                        p = new Staff(id, firstName, lastName, age, position, salary);
                        break;
                    case "Student":
                        string major = txtMajor.Text;
                        if (txtGPA.Text == String.Empty)
                            throw new EmptyStringException("GPA");

                        double gpa;
                        if (!Double.TryParse(txtGPA.Text, out gpa))
                            throw new NonNumericValueException("GPA");

                        p = new Student(id, firstName, lastName, age, major, gpa);
                        break;
                    default:
                        p = new InvalidPerson("", "", "", 0);
                        break;
                }

                txtDisplay.Text += $"The following person will be written to the file:\n" +
                    $"{p.DisplayPerson()}";

                FileStream fs;

                if (File.Exists(fileName))
                    fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                else
                    fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(p.ToString());

                sw.Close();
                fs.Close();
            }
            catch (OverflowException ex)
            {
                txtDisplay.Text = $"Overflow Exception thrown.\n" +
                    $"{ex.Message}\n";
            }
            catch (ValueBelowZeroException ex)
            {
                txtDisplay.Text = $"Value Below Zero Exception.\n" +
                    $"{ex.Message}\n";
            }
            catch (EmptyStringException ex)
            {
                txtDisplay.Text = $"Empty String Exception thrown.\n" +
                    $"{ex.Message}\n";
            }
            catch (NonNumericValueException ex)
            {
                txtDisplay.Text = $"Non-numeric Value Exception thrown.\n" +
                    $"{ex.Message}\n";
            }
            catch (Exception ex)
            {
                txtDisplay.Text += ex.ToString() + "\n";
                txtDisplay.Text += "Unknown exception had to be caught.\n";
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(fileName);
            form2.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
