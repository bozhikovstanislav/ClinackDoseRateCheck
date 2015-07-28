namespace MorningCheck.Forms
{
    partial class FormPassword
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPassword));
            this.button_Admin_OK = new System.Windows.Forms.Button();
            this.textBox_adminPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_adminName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Admin_OK
            // 
            this.button_Admin_OK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Admin_OK.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Admin_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Admin_OK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Admin_OK.Location = new System.Drawing.Point(332, 24);
            this.button_Admin_OK.Name = "button_Admin_OK";
            this.button_Admin_OK.Size = new System.Drawing.Size(123, 63);
            this.button_Admin_OK.TabIndex = 14;
            this.button_Admin_OK.Text = "OK";
            this.button_Admin_OK.UseVisualStyleBackColor = false;
            this.button_Admin_OK.Click += new System.EventHandler(this.button_Admin_OK_Click);
            // 
            // textBox_adminPassword
            // 
            this.textBox_adminPassword.BackColor = System.Drawing.Color.Orange;
            this.textBox_adminPassword.Location = new System.Drawing.Point(133, 71);
            this.textBox_adminPassword.Name = "textBox_adminPassword";
            this.textBox_adminPassword.PasswordChar = '*';
            this.textBox_adminPassword.Size = new System.Drawing.Size(161, 20);
            this.textBox_adminPassword.TabIndex = 13;
            this.textBox_adminPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(54, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // textBox_adminName
            // 
            this.textBox_adminName.Location = new System.Drawing.Point(133, 24);
            this.textBox_adminName.Name = "textBox_adminName";
            this.textBox_adminName.Size = new System.Drawing.Size(161, 20);
            this.textBox_adminName.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 113);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Admin_OK);
            this.Controls.Add(this.textBox_adminPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_adminName);
            this.Name = "FormPassword";
            this.Text = "FormPassword";
         
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Admin_OK;
        private System.Windows.Forms.TextBox textBox_adminPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_adminName;
 
    }
}