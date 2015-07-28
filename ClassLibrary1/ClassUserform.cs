using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Calib6MV
    {


        private static Calib6MV _instabs = new Calib6MV();
        private string number = "";
        static Calib6MV()
        {
        }
        public static Calib6MV getInstance()
        {
            return _instabs;
        }
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public void ChangeInstance(TextBox l)
        {
            string num = l.Text;
            Calib6MV.getInstance().Number = num;
        }
    }

    public class Users
    {


        private static Users _instabs = new Users();
        private string number = "";
        static Users()
        {
        }
        public static Users getInstance()
        {
            return _instabs;
        }
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public void ChangeInstance(TextBox l)
        {
            string num = l.Text;
            Users.getInstance().Number = num;
        }
    }

    public class CloseForm
    {
        private static CloseForm _instabs = new CloseForm();
        private string form ="";
        static CloseForm()
        {
        }
        public static CloseForm getInstance()
        {
            return _instabs;
        }
        public string Form
        {
            get
            {
                return form;
            }
            set
            {
                form = value;
            }
        }
    }
    public class ClassUserform
    {
        private static ClassUserform _instanse = new ClassUserform();
        private Control form6MV;
        private Control form15MV;
        private Control form_QA;
        private Control form_18MV;
        private Control mainForm;
        private Guid guID;
        private string username;
        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public Guid GuID
        {
            get { return guID; }
            set { guID = value; }
        }

        public Control MainForm
        {
            get { return MainForm; }
            set { MainForm = value; }
        }
        public Control Form_18MV
        {
            get { return form_18MV; }
            set { form_18MV = value; }
        }
        public Control Form_QA
        {
            get { return form_QA; }
            set { form_QA = value; }
        }
        public Control Form15MV
        {
            get { return form15MV; }
            set { form15MV = value; }
        }
        private Control formSearch;

        public Control FormSearch
        {
            get { return formSearch; }
            set { formSearch = value; }
        }
        private Control form_Calib;

        public Control Form_Calib
        {
            get { return form_Calib; }
            set { form_Calib = value; }
        }
        public Control Form6MV
        {
            get { return form6MV; }
            set { form6MV = value; }
        }
        private Control from10MV;

        public Control From10MV
        {
            get { return from10MV; }
            set { from10MV = value; }
        }
        private Control statistic;

        public Control Statistic
        {
            get { return statistic; }
            set { statistic = value; }
        }
        private Control reports;

        public Control Reports
        {
            get { return reports; }
            set { reports = value; }
        }

        public static ClassUserform getInstance()
        {
            return _instanse;
        }

     
    }
}
