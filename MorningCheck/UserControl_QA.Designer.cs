namespace ClassLibrary1
{
    partial class UserControl_QA
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_QA = new System.Windows.Forms.TabControl();
            this.tabPage_Montly = new System.Windows.Forms.TabPage();
            this.tabPage_Yearly = new System.Windows.Forms.TabPage();
            this.tabControl_QA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_QA
            // 
            this.tabControl_QA.Controls.Add(this.tabPage_Montly);
            this.tabControl_QA.Controls.Add(this.tabPage_Yearly);
            this.tabControl_QA.Location = new System.Drawing.Point(34, 28);
            this.tabControl_QA.Name = "tabControl_QA";
            this.tabControl_QA.SelectedIndex = 0;
            this.tabControl_QA.Size = new System.Drawing.Size(1269, 726);
            this.tabControl_QA.TabIndex = 0;
            // 
            // tabPage_Montly
            // 
            this.tabPage_Montly.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tabPage_Montly.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Montly.Name = "tabPage_Montly";
            this.tabPage_Montly.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Montly.Size = new System.Drawing.Size(1261, 700);
            this.tabPage_Montly.TabIndex = 0;
            this.tabPage_Montly.Text = "Месечни";
            // 
            // tabPage_Yearly
            // 
            this.tabPage_Yearly.BackColor = System.Drawing.Color.BurlyWood;
            this.tabPage_Yearly.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Yearly.Name = "tabPage_Yearly";
            this.tabPage_Yearly.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Yearly.Size = new System.Drawing.Size(1261, 700);
            this.tabPage_Yearly.TabIndex = 1;
            this.tabPage_Yearly.Text = "Годишни";
            // 
            // UserControl_QA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tabControl_QA);
            this.Name = "UserControl_QA";
            this.Size = new System.Drawing.Size(1352, 798);
            this.tabControl_QA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_QA;
        private System.Windows.Forms.TabPage tabPage_Montly;
        private System.Windows.Forms.TabPage tabPage_Yearly;
    }
}
