
namespace SS_OFFICIAL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabmain = new System.Windows.Forms.TabControl();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.lblProjectWait = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.prjName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prjRAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prjTaskMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.tabDeviceReg = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtpcname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.storageCapacity = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.networkCapacity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCPU = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoadDevice = new System.Windows.Forms.Button();
            this.ramCapacity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logingrp = new System.Windows.Forms.GroupBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tabmain.SuspendLayout();
            this.tabProject.SuspendLayout();
            this.tabDeviceReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramCapacity)).BeginInit();
            this.logingrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 17);
            this.lblStatus.Text = "Welcome";
            // 
            // tabmain
            // 
            this.tabmain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabmain.Controls.Add(this.tabProject);
            this.tabmain.Controls.Add(this.tabDeviceReg);
            this.tabmain.Location = new System.Drawing.Point(12, 12);
            this.tabmain.Name = "tabmain";
            this.tabmain.SelectedIndex = 0;
            this.tabmain.Size = new System.Drawing.Size(885, 456);
            this.tabmain.TabIndex = 1;
            this.tabmain.Visible = false;
            // 
            // tabProject
            // 
            this.tabProject.AutoScroll = true;
            this.tabProject.Controls.Add(this.lblProjectWait);
            this.tabProject.Controls.Add(this.listView1);
            this.tabProject.Controls.Add(this.label11);
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(877, 430);
            this.tabProject.TabIndex = 1;
            this.tabProject.Text = "Projects";
            this.tabProject.UseVisualStyleBackColor = true;
            this.tabProject.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblProjectWait
            // 
            this.lblProjectWait.AutoSize = true;
            this.lblProjectWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectWait.Location = new System.Drawing.Point(362, 178);
            this.lblProjectWait.Name = "lblProjectWait";
            this.lblProjectWait.Size = new System.Drawing.Size(193, 31);
            this.lblProjectWait.TabIndex = 2;
            this.lblProjectWait.Text = "Please wait.....";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prjName,
            this.prjRAM,
            this.prjTaskMethod});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 363);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            // 
            // prjName
            // 
            this.prjName.Text = "Name";
            // 
            // prjRAM
            // 
            this.prjRAM.Text = "Total RAM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(399, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Here you can see projects thats you can contribute";
            // 
            // tabDeviceReg
            // 
            this.tabDeviceReg.AutoScroll = true;
            this.tabDeviceReg.Controls.Add(this.label10);
            this.tabDeviceReg.Controls.Add(this.btnRegister);
            this.tabDeviceReg.Controls.Add(this.txtpcname);
            this.tabDeviceReg.Controls.Add(this.label9);
            this.tabDeviceReg.Controls.Add(this.storageCapacity);
            this.tabDeviceReg.Controls.Add(this.label8);
            this.tabDeviceReg.Controls.Add(this.networkCapacity);
            this.tabDeviceReg.Controls.Add(this.label7);
            this.tabDeviceReg.Controls.Add(this.cmbCPU);
            this.tabDeviceReg.Controls.Add(this.label6);
            this.tabDeviceReg.Controls.Add(this.btnLoadDevice);
            this.tabDeviceReg.Controls.Add(this.ramCapacity);
            this.tabDeviceReg.Controls.Add(this.label5);
            this.tabDeviceReg.Controls.Add(this.lblOS);
            this.tabDeviceReg.Controls.Add(this.label4);
            this.tabDeviceReg.Location = new System.Drawing.Point(4, 22);
            this.tabDeviceReg.Name = "tabDeviceReg";
            this.tabDeviceReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceReg.Size = new System.Drawing.Size(877, 430);
            this.tabDeviceReg.TabIndex = 0;
            this.tabDeviceReg.Text = "Device Register";
            this.tabDeviceReg.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(659, 182);
            this.label10.TabIndex = 16;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Location = new System.Drawing.Point(499, 178);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(145, 31);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register This Device";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtpcname
            // 
            this.txtpcname.Location = new System.Drawing.Point(156, 134);
            this.txtpcname.Name = "txtpcname";
            this.txtpcname.Size = new System.Drawing.Size(136, 20);
            this.txtpcname.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Device Name";
            // 
            // storageCapacity
            // 
            this.storageCapacity.AutoSize = true;
            this.storageCapacity.Location = new System.Drawing.Point(625, 81);
            this.storageCapacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.storageCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.storageCapacity.Name = "storageCapacity";
            this.storageCapacity.Size = new System.Drawing.Size(136, 20);
            this.storageCapacity.TabIndex = 10;
            this.storageCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Storage(GB)";
            // 
            // networkCapacity
            // 
            this.networkCapacity.AutoSize = true;
            this.networkCapacity.Location = new System.Drawing.Point(625, 25);
            this.networkCapacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.networkCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.networkCapacity.Name = "networkCapacity";
            this.networkCapacity.Size = new System.Drawing.Size(136, 20);
            this.networkCapacity.TabIndex = 8;
            this.networkCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(495, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Network";
            // 
            // cmbCPU
            // 
            this.cmbCPU.FormattingEnabled = true;
            this.cmbCPU.Location = new System.Drawing.Point(156, 83);
            this.cmbCPU.Name = "cmbCPU";
            this.cmbCPU.Size = new System.Drawing.Size(136, 21);
            this.cmbCPU.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPU";
            // 
            // btnLoadDevice
            // 
            this.btnLoadDevice.AutoSize = true;
            this.btnLoadDevice.Location = new System.Drawing.Point(156, 178);
            this.btnLoadDevice.Name = "btnLoadDevice";
            this.btnLoadDevice.Size = new System.Drawing.Size(104, 31);
            this.btnLoadDevice.TabIndex = 4;
            this.btnLoadDevice.Text = "Load Data";
            this.btnLoadDevice.UseVisualStyleBackColor = true;
            this.btnLoadDevice.Click += new System.EventHandler(this.btnLoadDevice_Click);
            // 
            // ramCapacity
            // 
            this.ramCapacity.AutoSize = true;
            this.ramCapacity.Location = new System.Drawing.Point(156, 28);
            this.ramCapacity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ramCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ramCapacity.Name = "ramCapacity";
            this.ramCapacity.Size = new System.Drawing.Size(136, 20);
            this.ramCapacity.TabIndex = 3;
            this.ramCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "RAM (GB)";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(621, 135);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(73, 20);
            this.lblOS.TabIndex = 1;
            this.lblOS.Text = "Windows";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "OS";
            // 
            // logingrp
            // 
            this.logingrp.Controls.Add(this.btnlogin);
            this.logingrp.Controls.Add(this.txtpassword);
            this.logingrp.Controls.Add(this.label3);
            this.logingrp.Controls.Add(this.label2);
            this.logingrp.Controls.Add(this.txtemail);
            this.logingrp.Controls.Add(this.label1);
            this.logingrp.Location = new System.Drawing.Point(195, 2);
            this.logingrp.Name = "logingrp";
            this.logingrp.Size = new System.Drawing.Size(519, 459);
            this.logingrp.TabIndex = 2;
            this.logingrp.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(210, 315);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(115, 41);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(9, 243);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(504, 22);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(6, 168);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(507, 22);
            this.txtemail.TabIndex = 1;
            this.txtemail.Text = "hasala.dananjaya7@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to Silicon Society";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabmain);
            this.Controls.Add(this.logingrp);
            this.Name = "Form1";
            this.Text = "SS-Official";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabmain.ResumeLayout(false);
            this.tabProject.ResumeLayout(false);
            this.tabProject.PerformLayout();
            this.tabDeviceReg.ResumeLayout(false);
            this.tabDeviceReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramCapacity)).EndInit();
            this.logingrp.ResumeLayout(false);
            this.logingrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabControl tabmain;
        private System.Windows.Forms.TabPage tabDeviceReg;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.GroupBox logingrp;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCPU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadDevice;
        private System.Windows.Forms.NumericUpDown ramCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtpcname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown storageCapacity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown networkCapacity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader prjName;
        private System.Windows.Forms.ColumnHeader prjRAM;
        private System.Windows.Forms.ColumnHeader prjTaskMethod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblProjectWait;
    }
}

