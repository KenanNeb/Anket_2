using Newtonsoft.Json;
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
using System.Text.RegularExpressions;

namespace Anket_2
{
    public partial class Form_Aanket : Form
    {
        public Form_Aanket()
        {
            InitializeComponent();
        }

        List<Student> students = new();
        private void btn_add_change_MouseClick(object sender, MouseEventArgs e)
        {           
                Student student = new Student
                {
                    Name = txtBox_name.Text.ToString(),
                    Surname = txtBox_surname.Text.ToString(),
                    Email = txtBox_email.Text.ToString(),
                    PhoneNumber = maskedTextBox_number.Text.ToString(),
                    DateOfBirth = dtp_dateOfBirth.Text.ToString()
                };
            if (txtBox_name.Text == string.Empty)
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (txtBox_surname.Text == string.Empty)
            {
                MessageBox.Show("Surname cannot be empty");
            }
            else if (txtBox_email.Text == string.Empty)
            {
                MessageBox.Show("Email cannot be empty");
            }
            else
            {
                if (btn_add_change.Text == "Add")
                {
                    if (!listBox.Items.Contains(txtBox_name.Text))
                    {
                        students.Add(student);
                        listBox.Items.Add(student.Name);
                        txtBox_name.Text = string.Empty;
                        txtBox_surname.Text = string.Empty;
                        txtBox_email.Text = string.Empty;
                        maskedTextBox_number.Text = string.Empty;
                        dtp_dateOfBirth.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("This item alredy exist in Lisbox!");
                    }

                }
                else if (btn_add_change.Text == "Change")
                {
                    listBox.Items.Remove(listBox.SelectedItem);
                    //listBox.Items.RemoveAt(listBox.SelectedIndex);                    
                    students.Add(student);
                    listBox.Items.Add(student.Name);
                    txtBox_name.Text = string.Empty;
                    txtBox_surname.Text = string.Empty;
                    txtBox_email.Text = string.Empty;
                    maskedTextBox_number.Text = string.Empty;
                    dtp_dateOfBirth.Text = string.Empty;
                }
            }
            btn_add_change.Text = "Add";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
            foreach (var item in students)
            {
                if (listBox.SelectedItem == item.Name)
                {
                    txtBox_name.Text = item.Name;
                    txtBox_surname.Text = item.Surname;
                    txtBox_email.Text = item.Email;
                    maskedTextBox_number.Text = item.PhoneNumber;
                    dtp_dateOfBirth.Text = item.DateOfBirth;
                }
            }
            btn_add_change.Text = "Change";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var jsonString = JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText($"{txtBox_FileName.Text.ToString()}.json", jsonString);
            MessageBox.Show("File saved");
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            Student[] student = null;

            var stringData = File.ReadAllText($"{txtBox_FileName.Text}.json");
            student = JsonConvert.DeserializeObject<Student[]>(stringData);

            foreach (var item in student)
            {
                listBox.Items.Add(item.Name);
                students.Add(item);
            }
        }
       
    }
}
