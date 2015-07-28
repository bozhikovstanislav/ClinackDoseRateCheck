using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;
namespace ClassLibrary1
{
    public partial class UserControlCalib : UserControl
    {
        public UserControlCalib()
        {
            InitializeComponent();
        }
       
        private void UserControlCalib_Load(object sender, EventArgs e)
        {
            Entities context = new Entities();
            label_Date.Text = DateTime.Now.ToString();
            dataGridView1.DataSource = context.Calibs;
        }
        Guid u = ClassUserform.getInstance().GuID;
        string firstname = ClassUserform.getInstance().Username;
        string lastname = ClassUserform.getInstance().Lastname;
        string pass = ClassUserform.getInstance().Pass;
       
        private void button_Add_6MV_Click(object sender, EventArgs e)
        {
            string Value6 = textBox_6MV.Text;
            string Value10 = textBox_10MV.Text;
            string Value18 = textBox_18MV.Text;
            string Value15 = textBox_15MV.Text;
            DateTime d = DateTime.Parse(label_Date.Text);


            using (var context = new Entities())
            {
                var olduser = new User()
                {
                    First_Name = firstname,
                    Last_Name = lastname,
                    Password = pass,
                    UserID = u

                };

                context.Users.Attach(olduser);
                var user1 = new Calib()
                {
                    Data = d,
                    Base_Value_6MV=Value6,
                    Calib_ID = Guid.NewGuid(),
                    User=olduser
                };
                var user2 = new Calib()
                {
                    Data = d,
                    Base_Value_10MV = Value10,
                    Calib_ID = Guid.NewGuid(),
                    User = olduser

                };
                var user3 = new Calib()
                {
                    Data = d,
                    Base_Value_15MV = Value15,
                    Calib_ID = Guid.NewGuid(),
                    User = olduser
                };
                var user4 = new Calib()
                {
                    Data = d,
                    Base_Value_18MV = Value18,
                    Calib_ID = Guid.NewGuid(),
                    User = olduser
                };
                context.AddToCalibs(user4);
                context.AddToCalibs(user3);
                context.AddToCalibs(user2);
                context.AddToCalibs(user1);
                context.SaveChanges();
                dataGridView1.DataSource = context.Calibs;
            }
        }

        private void button_Add_10MV_Click(object sender, EventArgs e)
        {
            string Value10 = textBox_10MV.Text;
            DateTime d =DateTime.Parse( label_Date.Text);

            using (var context = new Entities())
            {
                var olduser = new User()
                {
                    First_Name = firstname,
                    Last_Name = lastname,
                    Password = pass,
                    UserID = u

                };

                context.Users.Attach(olduser);
                var user1 = new Calib()
                {
                    Data = d,
                    Base_Value_10MV = Value10,
                    Calib_ID = Guid.NewGuid(),
                    User = olduser

                };
                context.AddToCalibs(user1);
                context.SaveChanges();
                dataGridView1.DataSource = context.Calibs;
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Value = textBox_15MV.Text;
            DateTime d = DateTime.Parse( label_Date.Text);



            using (var context = new Entities())
            {
                var olduser = new User()
                {
                    First_Name = firstname,
                    Last_Name = lastname,
                    Password = pass,
                    UserID = u

                };

                context.Users.Attach(olduser);
                var user1 = new Calib()
                {
                    Data = d,
                    Base_Value_15MV = Value,
                    Calib_ID = Guid.NewGuid(),
                    User = olduser
                };
                context.AddToCalibs(user1);
                context.SaveChanges();
                dataGridView1.DataSource = context.Calibs;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Value = textBox_18MV.Text;
            DateTime d =DateTime.Parse( label_Date.Text);

         

            using (var context = new Entities())
            {
                var olduser = new User()
                     {
                First_Name = firstname,
                Last_Name = lastname,
                Password = pass,
                UserID = u

                    };

            context.Users.Attach(olduser);
                var user1 = new Calib()
                {
                    Data = d,
                    Base_Value_18MV = Value,
                    Calib_ID = Guid.NewGuid(),
                    User = olduser
                };
                context.AddToCalibs(user1);
                context.SaveChanges();
                dataGridView1.DataSource = context.Calibs;
            }
        }
    }
}
