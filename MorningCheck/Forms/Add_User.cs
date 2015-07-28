using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;
using System.Data.Objects;
namespace MorningCheck.Forms
{
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }
      
        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox1_Ime.Text;
            string lastname = textBox2_Familia.Text;
            string pass = textBox_Password.Text;
            User newUser = new User();
            newUser.First_Name = name;
            newUser.Last_Name = lastname;
            newUser.Password = pass;
         
         
            using (var context = new Entities())
            {  
               

                var user1 = new User()
                {
                    First_Name = name,
                    Last_Name = lastname,
                    Password = pass,
                    UserID=Guid.NewGuid()
                    
                };
                context.AddToUsers(user1);
                context.SaveChanges();
                dataGridView1.DataSource = context.Users;
            }
        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            Entities context = new Entities();
            dataGridView1.DataSource = context.Users;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
           
            string del = string.Format("{0}", dataGridView1[row, 0].Value);

            using (var context = new Entities())
            {
                var wuery = (from data in context.Users
                             where data.First_Name==del
                             select data).First();
                context.Attach(wuery);
                context.DeleteObject(wuery);
                context.SaveChanges();
                dataGridView1.DataSource = context.Users;
            }

           
        }


    }

}