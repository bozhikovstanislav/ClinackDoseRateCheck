using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;
using MorningCheck.Forms;
using System.Globalization;
using System.Threading;
namespace MorningCheck
{
    public partial class Main : Form
    {
        public Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");
            InitializeComponent();
           
        }

        private void Main_Load(object sender, EventArgs e)
        { 
            FormPassword pas = new FormPassword();

            pas.ShowDialog();
            try
            {
                if (ClassLibrary1.CloseForm.getInstance().Form == "false" || ClassLibrary1.CloseForm.getInstance().Form == "")
                {
                    this.Dispose();

                }

                else if (ClassLibrary1.CloseForm.getInstance().Form == "true"  )
                {
                    toolStripStatusLabel_Name_User.Text = ClassLibrary1.Users.getInstance().Number;



                    using (var context = new Entities())
                    {
                        var last6Mv = (from d in context.Calibs
                                     orderby d.Base_Value_10MV descending
                                     select d).ToList();

                        //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                        
                     
                        toolStripStatusLabel_10MV.Text = String.Format("Kалиб 10MV = {0}", last6Mv[0].Base_Value_10MV);
                    }

                    using (var context = new Entities())
                    {
                        var last6Mv = (from d in context.Calibs
                                         orderby d.Base_Value_18MV descending
                                       select d).ToList();

                        //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;



                        toolStripStatusLabel_18MV.Text = String.Format("Kалиб 18MV = {0}", last6Mv[2].Base_Value_18MV);
                    }
                    using (var context = new Entities())
                    {
                        var last6Mv = (from d in context.Calibs
                                       orderby d.Base_Value_6MV descending
                                       select d).ToList();

                        //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                        toolStripStatusLabel_6MV_Value.Text = String.Format("Kалиб 6MV = {0}", last6Mv[0].Base_Value_6MV);
                    }
                    using (var context = new Entities())
                    {
                        var last6Mv = (from d in context.Calibs
                                       orderby d.Base_Value_15MV descending
                                       select d).ToList();

                        //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;


                        toolStripStatusLabel_15MV.Text = String.Format("Kалиб 15MV = {0}", last6Mv[3].Base_Value_15MV);
                    }
                }
                else
                {
                }
            }
            catch (Exception)
            {
 
            } 
           

        }
        private void toolStripButton_6MV_Click_1(object sender, EventArgs e)
        {
           
                Control _18MV = new Control();
                _18MV = ClassUserform.getInstance().Form_18MV;
                Control _QA = new Control();
                _QA = ClassUserform.getInstance().Form_QA;
                Control stat = new Control();
                stat = ClassUserform.getInstance().Statistic;
                Control _print = new Control();
                _print = ClassUserform.getInstance().Reports;
                Control _15MV = new Control();
                _15MV = ClassUserform.getInstance().Form15MV;
                Control booltest = new Control();
                booltest = ClassLibrary1.ClassUserform.getInstance().From10MV;
                UserCont_6MV _6MVControl = new UserCont_6MV();
                Control _Calib = new Control();
                _Calib = ClassUserform.getInstance().Form_Calib;
                Control search = new Control();
                search = ClassUserform.getInstance().FormSearch;

                ClassLibrary1.ClassUserform.getInstance().Form6MV = _6MVControl;
                if (splitContainer1.Panel2.Controls.Contains(booltest))
                {
                    splitContainer1.Panel2.Controls.Remove(booltest);

                }
                if (splitContainer1.Panel2.Controls.Contains(_Calib))
                {
                    splitContainer1.Panel2.Controls.Remove(_Calib);
                }
                if (splitContainer1.Panel2.Controls.Contains(_print))
                {
                    splitContainer1.Panel2.Controls.Remove(_print);
                }
                if (splitContainer1.Panel2.Controls.Contains(stat))
                {
                    splitContainer1.Panel2.Controls.Remove(stat);
                }
                if (splitContainer1.Panel2.Controls.Contains(search))
                {
                    splitContainer1.Panel2.Controls.Remove(search);
                }
                if (splitContainer1.Panel2.Controls.Contains(_15MV))
                {
                    splitContainer1.Panel2.Controls.Remove(_15MV);
                }
                if (splitContainer1.Panel2.Controls.Contains(_QA))
                {
                    splitContainer1.Panel2.Controls.Remove(_QA);
                }
                if (splitContainer1.Panel2.Controls.Contains(_18MV))
                {
                    splitContainer1.Panel2.Controls.Remove(_18MV);
                }
                splitContainer1.Panel2.Controls.Add(_6MVControl);
                toolStripButton_6MV.Enabled = false;
                toolStripButton_18MV.Enabled = true;
                toolStripButton_15MV.Enabled = true;
                toolStripButton_10MV.Enabled = true;
                toolStripButton_Calib.Enabled = true;
                toolStripButton_Printing.Enabled = true;
                toolStripButton_QA.Enabled = true;
                toolStripButton_Search.Enabled = true;
                toolStripButton_Statistic.Enabled = true;
            
        }

        private void toolStripButton_10MV_Click(object sender, EventArgs e)
        {
            Control _18MV = new Control();
            _18MV = ClassUserform.getInstance().Form_18MV;
            Control _15MV = new Control();
            _15MV = ClassUserform.getInstance().Form15MV;
            Control stat = new Control();
            stat = ClassUserform.getInstance().Statistic;
            Control _print = new Control();
            _print = ClassUserform.getInstance().Reports;
            Control search = new Control();
            search = ClassUserform.getInstance().FormSearch;
            Control _6MV = new Control();
            _6MV = ClassLibrary1.ClassUserform.getInstance().Form6MV;
           UserControl_10MV _10MVControl = new UserControl_10MV();
           Control _Calib = new Control();
           _Calib = ClassUserform.getInstance().Form_Calib;
           Control _QA = new Control();
           _QA = ClassUserform.getInstance().Form_QA;
            ClassUserform.getInstance().From10MV = _10MVControl;
            if(splitContainer1.Panel2.Controls.Contains(_6MV))
            { 
                splitContainer1.Panel2.Controls.Remove(_6MV);
                   
            }
            if(splitContainer1.Panel2.Controls.Contains(_Calib))
            {
                splitContainer1.Panel2.Controls.Remove(_Calib);
            }
            if (splitContainer1.Panel2.Controls.Contains(_print))
            {
                splitContainer1.Panel2.Controls.Remove(_print);
            }

            if (splitContainer1.Panel2.Controls.Contains(stat))
            {
                splitContainer1.Panel2.Controls.Remove(stat);
            }
            if (splitContainer1.Panel2.Controls.Contains(search))
            {
                splitContainer1.Panel2.Controls.Remove(search);
            }
            if (splitContainer1.Panel2.Controls.Contains(_15MV))
            {
                splitContainer1.Panel2.Controls.Remove(_15MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(_QA))
            {
                splitContainer1.Panel2.Controls.Remove(_QA);
            }
            if (splitContainer1.Panel2.Controls.Contains(_18MV))
            {
                splitContainer1.Panel2.Controls.Remove(_18MV);
            }
            splitContainer1.Panel2.Controls.Add(_10MVControl);
            toolStripButton_6MV.Enabled = true;
            toolStripButton_18MV.Enabled = true;
            toolStripButton_15MV.Enabled = true;
            toolStripButton_10MV.Enabled = false;
            toolStripButton_Calib.Enabled = true;
            toolStripButton_Printing.Enabled = true;
            toolStripButton_QA.Enabled = true;
            toolStripButton_Search.Enabled = true;
            toolStripButton_Statistic.Enabled = true;

        }

        private void toolStripButton_Calib_Click(object sender, EventArgs e)
        {
            Control _18MV = new Control();
            _18MV = ClassUserform.getInstance().Form_18MV;
            Control stat = new Control();
            stat = ClassUserform.getInstance().Statistic;
            Control _print = new Control();
            _print = ClassUserform.getInstance().Reports;
            Control _6MV = new Control();
            _6MV = ClassLibrary1.ClassUserform.getInstance().Form6MV;
            Control booltest = new Control();
            booltest = ClassLibrary1.ClassUserform.getInstance().From10MV;
            Control _15MV = new Control();
            _15MV = ClassUserform.getInstance().Form15MV;
            Control _QA = new Control();
            _QA = ClassUserform.getInstance().Form_QA;
            UserControlCalib _Calib = new UserControlCalib();
            Control search = new Control();
            search = ClassUserform.getInstance().FormSearch;

            ClassUserform.getInstance().Form_Calib = _Calib;
            if (splitContainer1.Panel2.Controls.Contains(_6MV))
            {
                splitContainer1.Panel2.Controls.Remove(_6MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(booltest))
            {
                splitContainer1.Panel2.Controls.Remove(booltest);
            }
            if (splitContainer1.Panel2.Controls.Contains(_print))
            {
                splitContainer1.Panel2.Controls.Remove(_print);
            }
            if (splitContainer1.Panel2.Controls.Contains(stat))
            {
                splitContainer1.Panel2.Controls.Remove(stat);
            }
            if (splitContainer1.Panel2.Controls.Contains(search))
            {
                splitContainer1.Panel2.Controls.Remove(search);
            }
            if (splitContainer1.Panel2.Controls.Contains(_15MV))
            {
                splitContainer1.Panel2.Controls.Remove(_15MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(_QA))
            {
                splitContainer1.Panel2.Controls.Remove(_QA);
            }
            if (splitContainer1.Panel2.Controls.Contains(_18MV))
            {
                splitContainer1.Panel2.Controls.Remove(_18MV);
            }

            splitContainer1.Panel2.Controls.Add(_Calib);
            toolStripButton_6MV.Enabled = true;
            toolStripButton_18MV.Enabled = true;
            toolStripButton_15MV.Enabled = true;
            toolStripButton_10MV.Enabled = true;
            toolStripButton_Calib.Enabled = false;
            toolStripButton_Printing.Enabled = true;
            toolStripButton_QA.Enabled = true;
            toolStripButton_Search.Enabled = true;
            toolStripButton_Statistic.Enabled = true;
        }

        private void toolStripButton_Printing_Click(object sender, EventArgs e)
        {
            Control _18MV = new Control();
            _18MV = ClassUserform.getInstance().Form_18MV;
            UserControl_Printing _print = new UserControl_Printing();
            ClassUserform.getInstance().Reports = _print;
            Control stat = new Control();
            stat = ClassUserform.getInstance().Statistic;
            Control _6MV = new Control();
            Control _calib=new Control();
            Control _QA = new Control();
            _QA = ClassUserform.getInstance().Form_QA;
            _6MV = ClassLibrary1.ClassUserform.getInstance().Form6MV;
            Control booltest = new Control();
            booltest = ClassLibrary1.ClassUserform.getInstance().From10MV;
            Control _15MV = new Control();
            _15MV = ClassUserform.getInstance().Form15MV;
            UserControlCalib _Calib = new UserControlCalib();
            _calib=ClassUserform.getInstance().Form_Calib;
            Control search = new Control();
            search = ClassUserform.getInstance().FormSearch;
            ClassUserform.getInstance().Form_Calib = _Calib;
            if (splitContainer1.Panel2.Controls.Contains(_6MV))
            {
                splitContainer1.Panel2.Controls.Remove(_6MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(booltest))
            {
                splitContainer1.Panel2.Controls.Remove(booltest);
            }
            if(splitContainer1.Panel2.Controls.Contains(_calib))
            {
                splitContainer1.Panel2.Controls.Remove(_calib);
            }
            if (splitContainer1.Panel2.Controls.Contains(stat))
            {
                splitContainer1.Panel2.Controls.Remove(stat);
            }
            if (splitContainer1.Panel2.Controls.Contains(search))
            {
                splitContainer1.Panel2.Controls.Remove(search);
            }
            if (splitContainer1.Panel2.Controls.Contains(_15MV))
            {
                splitContainer1.Panel2.Controls.Remove(_15MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(_QA))
            {
                splitContainer1.Panel2.Controls.Remove(_QA);
            }
            if (splitContainer1.Panel2.Controls.Contains(_18MV))
            {
                splitContainer1.Panel2.Controls.Remove(_18MV);
            }
            splitContainer1.Panel2.Controls.Add(_print);
            toolStripButton_6MV.Enabled =true;
            toolStripButton_18MV.Enabled = true;
            toolStripButton_15MV.Enabled = true;
            toolStripButton_10MV.Enabled = true;
            toolStripButton_Calib.Enabled = true;
            toolStripButton_Printing.Enabled = false;
            toolStripButton_QA.Enabled = true;
            toolStripButton_Search.Enabled = true;
            toolStripButton_Statistic.Enabled = true;
        }

        private void toolStripButton_Statistic_Click(object sender, EventArgs e)
        {
            Control _18MV = new Control();
            _18MV = ClassUserform.getInstance().Form_18MV;

            UserControl_Statistics _stat = new UserControl_Statistics();
            ClassUserform.getInstance().Statistic = _stat;
            Control _print = new Control();
            Control _QA = new Control();
            _QA = ClassUserform.getInstance().Form_QA;
            _print = ClassUserform.getInstance().Reports;
            Control _6MV = new Control();
            Control _calib = new Control();
            _6MV = ClassLibrary1.ClassUserform.getInstance().Form6MV;
            Control booltest = new Control();
            booltest = ClassLibrary1.ClassUserform.getInstance().From10MV;
            Control _15_MV = new Control();
            _15_MV = ClassUserform.getInstance().Form15MV;
            UserControlCalib _Calib = new UserControlCalib();
            _calib = ClassUserform.getInstance().Form_Calib;
            Control search = new Control();
            search = ClassUserform.getInstance().FormSearch;
            ClassUserform.getInstance().Form_Calib = _Calib;
            if (splitContainer1.Panel2.Controls.Contains(_6MV))
            {
                splitContainer1.Panel2.Controls.Remove(_6MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(booltest))
            {
                splitContainer1.Panel2.Controls.Remove(booltest);
            }
            if (splitContainer1.Panel2.Controls.Contains(_calib))
            {
                splitContainer1.Panel2.Controls.Remove(_calib);
            }
            if (splitContainer1.Panel2.Controls.Contains(_print))
            {
                splitContainer1.Panel2.Controls.Remove(_print);
            }
            if (splitContainer1.Panel2.Controls.Contains(search))
            {
                splitContainer1.Panel2.Controls.Remove(search);
            }
            if (splitContainer1.Panel2.Controls.Contains(_15_MV))
            {
                splitContainer1.Panel2.Controls.Remove(_15_MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(_QA))
            {
                splitContainer1.Panel2.Controls.Remove(_QA);
            }
            if (splitContainer1.Panel2.Controls.Contains(_18MV))
            {
                splitContainer1.Panel2.Controls.Remove(_18MV);
            }
            splitContainer1.Panel2.Controls.Add(_stat);
            toolStripButton_6MV.Enabled = true;
            toolStripButton_18MV.Enabled = true;
            toolStripButton_15MV.Enabled = true;
            toolStripButton_10MV.Enabled = true;
            toolStripButton_Calib.Enabled = true;
            toolStripButton_Printing.Enabled = true;
            toolStripButton_QA.Enabled = true;
            toolStripButton_Search.Enabled = true;
            toolStripButton_Statistic.Enabled = false;
        }

        private void toolStripButton_Search_Click(object sender, EventArgs e)
        {
            Control _18MV = new Control();
            _18MV = ClassUserform.getInstance().Form_18MV;
            UserControl_Search search = new UserControl_Search();
            ClassUserform.getInstance().FormSearch = search;
            Control _print = new Control();
            _print = ClassUserform.getInstance().Reports;
            Control _6MV = new Control();
            Control _QA = new Control();
            _QA = ClassUserform.getInstance().Form_QA;
            Control _calib = new Control();
            _6MV = ClassLibrary1.ClassUserform.getInstance().Form6MV;
            Control booltest = new Control();
            booltest = ClassLibrary1.ClassUserform.getInstance().From10MV;
            Control _15MV = new Control();
            _15MV = ClassUserform.getInstance().Form15MV;
            UserControlCalib _Calib = new UserControlCalib();
            _calib = ClassUserform.getInstance().Form_Calib;
            Control stat = new Control();
            stat = ClassUserform.getInstance().Statistic;
            ClassUserform.getInstance().Form_Calib = _Calib;
            if (splitContainer1.Panel2.Controls.Contains(_6MV))
            {
                splitContainer1.Panel2.Controls.Remove(_6MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(booltest))
            {
                splitContainer1.Panel2.Controls.Remove(booltest);
            }
            if (splitContainer1.Panel2.Controls.Contains(_calib))
            {
                splitContainer1.Panel2.Controls.Remove(_calib);
            }
            if (splitContainer1.Panel2.Controls.Contains(_print))
            {
                splitContainer1.Panel2.Controls.Remove(_print);
            }
            if (splitContainer1.Panel2.Controls.Contains(stat))
            {
                splitContainer1.Panel2.Controls.Remove(stat);
            }
            if (splitContainer1.Panel2.Controls.Contains(_15MV))
            {
                splitContainer1.Panel2.Controls.Remove(_15MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(_QA))
            {
                splitContainer1.Panel2.Controls.Remove(_QA);
            }
            if (splitContainer1.Panel2.Controls.Contains(_18MV))
            {
                splitContainer1.Panel2.Controls.Remove(_18MV);
            }
            splitContainer1.Panel2.Controls.Add(search);
            toolStripButton_6MV.Enabled = true;
            toolStripButton_18MV.Enabled = true;
            toolStripButton_15MV.Enabled = true;
            toolStripButton_10MV.Enabled = true;
            toolStripButton_Calib.Enabled = true;
            toolStripButton_Printing.Enabled = true;
            toolStripButton_QA.Enabled = true;
            toolStripButton_Search.Enabled = false;
            toolStripButton_Statistic.Enabled = true;
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            Control _18MV = new Control();
            _18MV = ClassUserform.getInstance().Form_18MV;
            UserControl_15MV _15MV = new UserControl_15MV();
            ClassUserform.getInstance().Form15MV = _15MV;
            Control _print = new Control();
            _print = ClassUserform.getInstance().Reports;
            Control _6MV = new Control();
            Control _calib = new Control();
            _6MV = ClassLibrary1.ClassUserform.getInstance().Form6MV;
            Control booltest = new Control();
            booltest = ClassLibrary1.ClassUserform.getInstance().From10MV;
            Control search = new Control();
            search = ClassUserform.getInstance().FormSearch;
            Control _QA = new Control();
            _QA = ClassUserform.getInstance().Form_QA;
            UserControlCalib _Calib = new UserControlCalib();
            _calib = ClassUserform.getInstance().Form_Calib;
            Control stat = new Control();
            stat = ClassUserform.getInstance().Statistic;
            ClassUserform.getInstance().Form_Calib = _Calib;
            if (splitContainer1.Panel2.Controls.Contains(_6MV))
            {
                splitContainer1.Panel2.Controls.Remove(_6MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(booltest))
            {
                splitContainer1.Panel2.Controls.Remove(booltest);
            }
            if (splitContainer1.Panel2.Controls.Contains(_calib))
            {
                splitContainer1.Panel2.Controls.Remove(_calib);
            }
            if (splitContainer1.Panel2.Controls.Contains(_print))
            {
                splitContainer1.Panel2.Controls.Remove(_print);
            }
            if (splitContainer1.Panel2.Controls.Contains(stat))
            {
                splitContainer1.Panel2.Controls.Remove(stat);
            }
            if (splitContainer1.Panel2.Controls.Contains(search))
            {
                splitContainer1.Panel2.Controls.Remove(search);
            }
            if (splitContainer1.Panel2.Controls.Contains(_QA))
            {
                splitContainer1.Panel2.Controls.Remove(_QA);
            }
            if (splitContainer1.Panel2.Controls.Contains(_18MV))
            {
                splitContainer1.Panel2.Controls.Remove(_18MV);
            }
            splitContainer1.Panel2.Controls.Add(_15MV);
            toolStripButton_6MV.Enabled = true;
            toolStripButton_18MV.Enabled = true;
            toolStripButton_15MV.Enabled = false;
            toolStripButton_10MV.Enabled = true;
            toolStripButton_Calib.Enabled = true;
            toolStripButton_Printing.Enabled = true;
            toolStripButton_QA.Enabled = true;
            toolStripButton_Search.Enabled = true;
            toolStripButton_Statistic.Enabled = true;
        }

        private void toolStripButton_QA_Click(object sender, EventArgs e)
        {
            Control _18MV = new Control();
            _18MV = ClassUserform.getInstance().Form_18MV;

            UserControl_QA _QA = new UserControl_QA();
            ClassUserform.getInstance().Form_QA = _QA;
           Control _print = new Control();
            _print = ClassUserform.getInstance().Reports;
            Control _6MV = new Control();
            Control _calib = new Control();
            _6MV = ClassLibrary1.ClassUserform.getInstance().Form6MV;
            Control booltest = new Control();
            booltest = ClassLibrary1.ClassUserform.getInstance().From10MV;
            Control search = new Control();
            search = ClassUserform.getInstance().FormSearch;
            Control _15MV = new Control();
            _15MV = ClassUserform.getInstance().Form15MV;
            UserControlCalib _Calib = new UserControlCalib();
            _calib = ClassUserform.getInstance().Form_Calib;
            Control stat = new Control();
            stat = ClassUserform.getInstance().Statistic;
            ClassUserform.getInstance().Form_Calib = _Calib;
            if (splitContainer1.Panel2.Controls.Contains(_6MV))
            {
                splitContainer1.Panel2.Controls.Remove(_6MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(booltest))
            {
                splitContainer1.Panel2.Controls.Remove(booltest);
            }
            if (splitContainer1.Panel2.Controls.Contains(_calib))
            {
                splitContainer1.Panel2.Controls.Remove(_calib);
            }
            if (splitContainer1.Panel2.Controls.Contains(_print))
            {
                splitContainer1.Panel2.Controls.Remove(_print);
            }
            if (splitContainer1.Panel2.Controls.Contains(stat))
            {
                splitContainer1.Panel2.Controls.Remove(stat);
            }
            if (splitContainer1.Panel2.Controls.Contains(search))
            {
                splitContainer1.Panel2.Controls.Remove(search);
            }
            if (splitContainer1.Panel2.Controls.Contains(_15MV))
            {
                splitContainer1.Panel2.Controls.Remove(_15MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(_18MV))
            {
                splitContainer1.Panel2.Controls.Remove(_18MV);
            }
            splitContainer1.Panel2.Controls.Add(_QA);
            toolStripButton_6MV.Enabled = true;
            toolStripButton_18MV.Enabled = true;
            toolStripButton_15MV.Enabled = true;
            toolStripButton_10MV.Enabled = true;
            toolStripButton_Calib.Enabled = true;
            toolStripButton_Printing.Enabled = true;
            toolStripButton_QA.Enabled = false;
            toolStripButton_Search.Enabled = true;
            toolStripButton_Statistic.Enabled = true;
        }

        private void toolStripButton_18MV_Click(object sender, EventArgs e)
        {
            UserControl_18MV _18MV = new UserControl_18MV();
            ClassUserform.getInstance().Form_18MV = _18MV;
            Control _QA = new Control();
            _QA = ClassUserform.getInstance().Form_QA;
            Control _print = new Control();
            _print = ClassUserform.getInstance().Reports;
            Control _6MV = new Control();
            Control _calib = new Control();
            _6MV = ClassLibrary1.ClassUserform.getInstance().Form6MV;
            Control booltest = new Control();
            booltest = ClassLibrary1.ClassUserform.getInstance().From10MV;
            Control search = new Control();
            search = ClassUserform.getInstance().FormSearch;
            Control _15MV = new Control();
            _15MV = ClassUserform.getInstance().Form15MV;
            UserControlCalib _Calib = new UserControlCalib();
            _calib = ClassUserform.getInstance().Form_Calib;
            Control stat = new Control();
            stat = ClassUserform.getInstance().Statistic;
            ClassUserform.getInstance().Form_Calib = _Calib;
            if (splitContainer1.Panel2.Controls.Contains(_6MV))
            {
                splitContainer1.Panel2.Controls.Remove(_6MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(booltest))
            {
                splitContainer1.Panel2.Controls.Remove(booltest);
            }
            if (splitContainer1.Panel2.Controls.Contains(_calib))
            {
                splitContainer1.Panel2.Controls.Remove(_calib);
            }
            if (splitContainer1.Panel2.Controls.Contains(_print))
            {
                splitContainer1.Panel2.Controls.Remove(_print);
            }
            if (splitContainer1.Panel2.Controls.Contains(stat))
            {
                splitContainer1.Panel2.Controls.Remove(stat);
            }
            if (splitContainer1.Panel2.Controls.Contains(search))
            {
                splitContainer1.Panel2.Controls.Remove(search);
            }
            if (splitContainer1.Panel2.Controls.Contains(_15MV))
            {
                splitContainer1.Panel2.Controls.Remove(_15MV);
            }
            if (splitContainer1.Panel2.Controls.Contains(_QA))
            {
                splitContainer1.Panel2.Controls.Remove(_QA);
            }
            splitContainer1.Panel2.Controls.Add(_18MV);
            toolStripButton_6MV.Enabled = true;
            toolStripButton_18MV.Enabled = false;
            toolStripButton_15MV.Enabled = true;
            toolStripButton_10MV.Enabled = true;
            toolStripButton_Calib.Enabled = true;
            toolStripButton_Printing.Enabled = true;
            toolStripButton_QA.Enabled = true;
            toolStripButton_Search.Enabled = true;
            toolStripButton_Statistic.Enabled = true;
        }

        private void toolStripButton_Add_User_Click(object sender, EventArgs e)
        {
            Add_User user = new Add_User();
            user.ShowDialog();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Leave(object sender, EventArgs e)
        {
            ClassLibrary1.CloseForm.getInstance().Form = "false";
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

      
    }
}
