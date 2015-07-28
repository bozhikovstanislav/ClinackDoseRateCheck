using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;

namespace MorningCheck.Forms
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void button_Admin_OK_Click(object sender, EventArgs e)
        {
            
            using (var contecxt = new Entities())
            {
                var usr = contecxt.Users;

                foreach (var u in usr)
                {
                    if (textBox_adminName.Text == u.First_Name && textBox_adminPassword.Text == u.Password)
                    {
                       ClassLibrary1.CloseForm.getInstance().Form= "true"  ;
                        ClassLibrary1.Users.getInstance().Number = textBox_adminName.Text;
                        ClassLibrary1.ClassUserform.getInstance().GuID = u.UserID;
                        ClassLibrary1.ClassUserform.getInstance().Pass = u.Password;
                        ClassLibrary1.ClassUserform.getInstance().Username = u.First_Name;
                        ClassLibrary1.ClassUserform.getInstance().Lastname = u.Last_Name;
                        MessageBox.Show(String.Format("Добре дошъл {0}", textBox_adminName.Text));
                        this.Dispose();
                        break;
                    }
                    else
                    {

                        ClassLibrary1.CloseForm.getInstance().Form = "false";
                        
                      
                    }
                }
                if (ClassLibrary1.CloseForm.getInstance().Form == "false")
                {
                    MessageBox.Show(String.Format("Съжаляваме но имате допуснати грешки при - Не съществуващ потребител {0}", textBox_adminName.Text));
                }
            }

        }

       

        private void FormPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            //using (var contecxt = new Entities7())
            //{
            //    var usr = contecxt.User;

            //    foreach (var u in usr)
            //    {
            //        if (textBox_adminName.Text == u.First_Name && textBox_adminPassword.Text == u.Password)
            //        {
            //            ClassLibrary1.CloseForm.getInstance().Form = "true";
            //            ClassLibrary1.Users.getInstance().Number = textBox_adminName.Text;
            //            MessageBox.Show(String.Format("Добре дошъл {0}", textBox_adminName.Text));
            //            this.Dispose();
                       
            //        }
            //        else
            //        {

            //            ClassLibrary1.CloseForm.getInstance().Form = "false";
            //            break;

            //        }
            //    }
                //if (ClassLibrary1.CloseForm.getInstance().Form == "false")
                //{
                //    MessageBox.Show(String.Format("Съжаляваме но имате допуснати грешки при - Не съществуващ потребител {0}", textBox_adminName.Text));
                //}
            //}
        }

       
    }
}
