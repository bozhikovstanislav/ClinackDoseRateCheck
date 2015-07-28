using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class UserControl_15MV : UserControl
    {
        public UserControl_15MV()
        {
            InitializeComponent();
        }

        private void textBox_VALUE2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string calib = "";
                using (var context = new Entities())
                {
                    var last6Mv = (from d in context.Calibs
                                   orderby d.Base_Value_15MV descending
                                   select d).ToList();

                    //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                    calib = String.Format(last6Mv[0].Base_Value_15MV);

                }
                decimal calib6MV = decimal.Parse(calib);
                decimal corr = decimal.Parse(label_Corection_TP_MV.Text);
                decimal val2 = decimal.Parse(textBox_VALUE2.Text);
                decimal val2cor = val2 * corr;
                decimal dlta6MV_V1 = (val2cor - calib6MV) / calib6MV * 100;
                label_Value2_Corr.Text = Math.Round(val2cor, 2).ToString();
                labelValue2_Delta.Text = string.Format("{0}", Math.Round(dlta6MV_V1, 2));

            }
            catch (Exception)
            {
                MessageBox.Show("Въведете стойност различна от 0");
            }
         
        }

        private void UserControl_15MV_Load(object sender, EventArgs e)
        {
            groupBox_6MV_Data.Enabled = false;
            textBoxP.Enabled = false;
            label_Date.Text = DateTime.Now.ToString();
        }

        private void textBox_Temperature_6MV_TextChanged(object sender, EventArgs e)
        {
            textBoxP.Enabled = true;
            try
            {
                decimal To = 20.0M;
                decimal Po = 101.3M;
                decimal T = decimal.Parse(textBox_Temperature_6MV.Text);
                decimal P = decimal.Parse(textBoxP.Text);
                decimal corrr = (decimal)((273.2M + T) * Po) / ((273.2M + To) * P);
                decimal corr = Math.Round(corrr, 3);

                label_Corection_TP_MV.Text = corr.ToString();
            }
            catch
            {
                MessageBox.Show("Моля въведете данни");
            }
        }

        private void textBoxP_TextChanged(object sender, EventArgs e)
        {
            groupBox_6MV_Data.Enabled = true;
            try
            {
                decimal To = 20.0M;
                decimal Po = 101.3M;
                decimal T = decimal.Parse(textBox_Temperature_6MV.Text);
                decimal P = decimal.Parse(textBoxP.Text);
                decimal corrr = (decimal)((273.2M + T) * Po) / ((273.2M + To) * P);
                decimal corr = Math.Round(corrr, 3);

                label_Corection_TP_MV.Text = corr.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Моля въведете данни");
            }
        }

        private void textBox_Value1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string calib = "";
                using (var context = new Entities())
                {
                    var last6Mv = (from d in context.Calibs
                                   orderby d.Base_Value_15MV descending
                                   select d).ToList();

                    //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                    calib = String.Format(last6Mv[0].Base_Value_15MV);

                }
                decimal calib6MV = decimal.Parse(calib);
                decimal corr = decimal.Parse(label_Corection_TP_MV.Text);
                decimal val1 = decimal.Parse(textBox_Value1.Text);
                decimal val1cor = val1 * corr;
                decimal dlta6MV_V1 = (val1cor - calib6MV) / calib6MV * 100;
                label_Value1_Corr.Text = Math.Round(val1cor, 2).ToString();
                labelValue1_Delta.Text = string.Format("{0}", Math.Round(dlta6MV_V1, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Въведете стойност различна от 0 ");
            }
        }

        private void textBox_Value3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string calib = "";
                using (var context = new Entities())
                {
                    var last6Mv = (from d in context.Calibs
                                   orderby d.Base_Value_6MV descending
                                   select d).ToList();

                    //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                    calib = String.Format(last6Mv[0].Base_Value_6MV);

                }
                decimal calib6MV = decimal.Parse(calib);
                decimal corr = decimal.Parse(label_Corection_TP_MV.Text);
                decimal val3 = decimal.Parse(textBox_Value3.Text);
                decimal val3cor = val3 * corr;
                decimal dlta6MV_V1 = (val3cor - calib6MV) / calib6MV * 100;
                label_Value3_Corr.Text = Math.Round(val3cor, 2).ToString();
                labelValue3_delta.Text = string.Format("{0}", Math.Round(dlta6MV_V1, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Въведете стойност различна от 0");
            }
        }

        private void textBox_Value4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string calib = "";
                using (var context = new Entities())
                {
                    var last6Mv = (from d in context.Calibs
                                   orderby d.Base_Value_15MV descending
                                   select d).ToList();


                    //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                    calib = String.Format(last6Mv[0].Base_Value_15MV);

                }
                decimal calib6MV = decimal.Parse(calib);
                decimal corr = decimal.Parse(label_Corection_TP_MV.Text);
                decimal val4 = decimal.Parse(textBox_Value4.Text);
                decimal val4cor = val4 * corr;
                decimal dlta6MV_V1 = (val4cor - calib6MV) / calib6MV * 100;
                label_Value4_Corr.Text = Math.Round(val4cor, 2).ToString();
                labelValue4_Delta.Text = string.Format("{0}", Math.Round(dlta6MV_V1, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Въведете стойност различна от 0");
            }
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal To = 20.0M;
                decimal Po = 101.3M;
                decimal T = decimal.Parse(textBox_Temperature_6MV.Text);
                decimal P = decimal.Parse(textBoxP.Text);
                decimal corrr = (decimal)((273.2M + T) * Po) / ((273.2M + To) * P);
                decimal corr = Math.Round(corrr, 3);

                label_Corection_TP_MV.Text = corr.ToString();
                string calib = "";
                using (var context = new Entities())
                {
                    var last6Mv = (from d in context.Calibs
                                   orderby d.Base_Value_15MV descending
                                   select d).ToList();


                    //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                    calib = String.Format(last6Mv[0].Base_Value_15MV);

                }
                decimal calib6MV = decimal.Parse(calib);
                //decimal corr = decimal.Parse(label_Corection_TP_MV.Text);
                decimal val4 = decimal.Parse(textBox_Value4.Text);
                decimal val4cor = val4 * corr;
                decimal dlta6MV_V1 = (val4cor - calib6MV) / calib6MV * 100;
                label_Value4_Corr.Text = Math.Round(val4cor, 2).ToString();
                labelValue4_Delta.Text = string.Format("{0}", Math.Round(dlta6MV_V1, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Въведете стойност различна от 0");
            }
            try
            {
                decimal To = 20.0M;
                decimal Po = 101.3M;
                decimal T = decimal.Parse(textBox_Temperature_6MV.Text);
                decimal P = decimal.Parse(textBoxP.Text);
                decimal corrr = (decimal)((273.2M + T) * Po) / ((273.2M + To) * P);
                decimal corr = Math.Round(corrr, 3);

                label_Corection_TP_MV.Text = corr.ToString();
                string calib = "";
                using (var context = new Entities())
                {
                    var last6Mv = (from d in context.Calibs
                                   orderby d.Base_Value_15MV descending
                                   select d).ToList();

                    //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                    calib = String.Format(last6Mv[0].Base_Value_15MV);

                }
                decimal calib6MV = decimal.Parse(calib);
                //decimal corr = decimal.Parse(label_Corection_TP_MV.Text);
                decimal val3 = decimal.Parse(textBox_Value3.Text);
                decimal val3cor = val3 * corr;
                decimal dlta6MV_V1 = (val3cor - calib6MV) / calib6MV * 100;
                label_Value3_Corr.Text = Math.Round(val3cor, 2).ToString();
                labelValue3_delta.Text = string.Format("{0}", Math.Round(dlta6MV_V1, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Въведете стойност различна от 0");
            }
            try
            {
                decimal To = 20.0M;
                decimal Po = 101.3M;
                decimal T = decimal.Parse(textBox_Temperature_6MV.Text);
                decimal P = decimal.Parse(textBoxP.Text);
                decimal corrr = (decimal)((273.2M + T) * Po) / ((273.2M + To) * P);
                decimal corr = Math.Round(corrr, 3);

                label_Corection_TP_MV.Text = corr.ToString();
                string calib = "";
                using (var context = new Entities())
                {
                    var last6Mv = (from d in context.Calibs
                                   orderby d.Base_Value_15MV descending
                                   select d).ToList();

                    //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                    calib = String.Format(last6Mv[0].Base_Value_15MV);

                }
                decimal calib6MV = decimal.Parse(calib);
                //decimal corr = decimal.Parse(label_Corection_TP_MV.Text);
                decimal val2 = decimal.Parse(textBox_VALUE2.Text);
                decimal val2cor = val2 * corr;
                decimal dlta6MV_V1 = (val2cor - calib6MV) / calib6MV * 100;
                label_Value2_Corr.Text = Math.Round(val2cor, 2).ToString();
                labelValue2_Delta.Text = string.Format("{0}", Math.Round(dlta6MV_V1, 2));

            }
            catch (Exception)
            {
                MessageBox.Show("Въведете стойност различна от 0");
            }
            try
            {
                decimal To = 20.0M;
                decimal Po = 101.3M;
                decimal T = decimal.Parse(textBox_Temperature_6MV.Text);
                decimal P = decimal.Parse(textBoxP.Text);
                decimal corrr = (decimal)((273.2M + T) * Po) / ((273.2M + To) * P);
                decimal corr = Math.Round(corrr, 3);

                label_Corection_TP_MV.Text = corr.ToString();

                string calib = "";
                using (var context = new Entities())
                {
                    var last6Mv = (from d in context.Calibs
                                   orderby d.Base_Value_15MV descending
                                   select d).ToList();

                    //Calib6MV.getInstance().Number = wuery.Base_Value_6MV;

                    calib = String.Format(last6Mv[0].Base_Value_15MV);

                }
                decimal calib6MV = decimal.Parse(calib);
                //decimal corr = decimal.Parse(label_Corection_TP_MV.Text);
                decimal val1 = decimal.Parse(textBox_Value1.Text);
                decimal val1cor = val1 * corr;
                decimal dlta6MV_V1 = (val1cor - calib6MV) / calib6MV * 100;
                label_Value1_Corr.Text = Math.Round(val1cor, 2).ToString();
                labelValue1_Delta.Text = string.Format("{0}", Math.Round(dlta6MV_V1, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Въведете стойност различна от 0 ");
            }

            try
            {


                decimal v4 = decimal.Parse(label_Value4_Corr.Text);
                decimal v3 = decimal.Parse(label_Value3_Corr.Text);
                decimal v2 = decimal.Parse(label_Value2_Corr.Text);
                decimal v1 = decimal.Parse(label_Value1_Corr.Text);
                label_Average_Corr.Text = String.Format("{0}", Math.Round((v1 + v2 + v3 + v4) / 4, 2));
                decimal v4_4 = decimal.Parse((labelValue4_Delta.Text));
                decimal v3_3 = decimal.Parse((labelValue3_delta.Text));
                decimal v2_2 = decimal.Parse(labelValue2_Delta.Text);
                decimal v1_1 = decimal.Parse(labelValue1_Delta.Text);
                label_ValueDelta_Average.Text = string.Format("{0}", Math.Round((v1_1 + v2_2 + v3_3 + v4_4) / 4, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Грешно въведени данни");
            }
        }

        private void button_ADD_6MV_Click(object sender, EventArgs e)
        {
            try
            {
                Guid u = ClassUserform.getInstance().GuID;
                string firstname = ClassUserform.getInstance().Username;
                string lastname = ClassUserform.getInstance().Lastname;
                string pass = ClassUserform.getInstance().Pass;
                try
                {
                    using (var context = new Entities())
                    {
                        double corr = double.Parse(label_Corection_TP_MV.Text);

                        double val1 = double.Parse(textBox_Value1.Text);
                        double val1cor = val1 * corr;
                        double val2 = double.Parse(textBox_VALUE2.Text);
                        double val2cor = val2 * corr;
                        label_Value2_Corr.Text = val2cor.ToString();
                        double val3 = double.Parse(textBox_Value3.Text);
                        double val3cor = val3 * corr;
                        label_Value3_Corr.Text = val3cor.ToString();
                        double val4 = double.Parse(textBox_Value4.Text);
                        double val4cor = val4 * corr;
                        label_Value4_Corr.Text = val4cor.ToString();
                        double delta = double.Parse(label_ValueDelta_Average.Text);

                        var olduser = new User()
                        {
                            First_Name = firstname,
                            Last_Name = lastname,
                            Password = pass,
                            UserID = u

                        };

                        context.Users.Attach(olduser);
                        var user1 = new DATA_15MV()
                        {

                            Value1 = val1cor.ToString(),
                            Value2 = val2cor.ToString(),
                            Value3 = val3cor.ToString(),
                            Value4 = val4cor.ToString(),
                            Data = DateTime.Parse(label_Date.Text),
                            Delta_15MV = delta,
                            Data_15MV_ID = Guid.NewGuid(),
                            User = olduser

                        };



                        double T_c = double.Parse(textBox_Temperature_6MV.Text);
                        double P_kPa = double.Parse(textBoxP.Text);
                        double K_corr = double.Parse(label_Corection_TP_MV.Text);
                        DateTime data = DateTime.Parse(label_Date.Text);
                        var tp = new T_P_CorrSet()
                        {
                            T_P_ID = Guid.NewGuid(),
                            Data = data,
                            T_C = T_c,
                            K_Korr = K_corr,
                            P_kPa = P_kPa,
                            User = olduser
                        };
                        context.AddToT_P_CorrSet(tp);
                        context.AddToDATA_15MV(user1);

                        context.SaveChanges();
                        // dataGridView1.DataSource = context.User;
                        MessageBox.Show("succsess");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Възможни грешки при въвеждане- Проверете дали сте въвели калибровачни референтни данни");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Първо исзчислете средна стойност за отклонение и средна стойност от измерване с бутона CALL");
            }
        }

        private void button_Refresh_Chart_6MV_Click(object sender, EventArgs e)
        {
            try
            {
                Entities by = new Entities();
                chart_DatA.DataSource = by.Data_10MV;
                chart_T_P.DataSource = by.T_P_CorrSet;
                chart_P_KPA.DataSource = by.T_P_CorrSet;
                chart_DatA.Series["Delta"].XValueMember = "Data";
                chart_DatA.Series["Delta"].YValueMembers = "Delta_15MV";
                chart_T_P.Series["T/P"].XValueMember = "Data";
                chart_T_P.Series["T/P"].YValueMembers = "K_korr";
                chart_P_KPA.Series["P(kPa)"].XValueMember = "Data";
                chart_P_KPA.Series["P(kPa)"].YValueMembers = "P_kPa";
                chart_P_KPA.DataBind();
                chart_T_P.DataBind();
                chart_DatA.DataBind();
            }
            catch (Exception)
            {
                MessageBox.Show("Грешка");
            }
        }

     
    }
}
