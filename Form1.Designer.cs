
namespace WindowsFormsApp0927
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
            this.btnSelectIpmitool = new System.Windows.Forms.Button();
            this.btnPowerCycle = new System.Windows.Forms.Button();
            this.txtIpmitoolPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.btnPowerOff1 = new System.Windows.Forms.Button();
            this.numTimes = new System.Windows.Forms.NumericUpDown();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1_SelectedIndexChanged = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectIpmitool
            // 
            this.btnSelectIpmitool.Location = new System.Drawing.Point(29, 86);
            this.btnSelectIpmitool.Name = "btnSelectIpmitool";
            this.btnSelectIpmitool.Size = new System.Drawing.Size(117, 47);
            this.btnSelectIpmitool.TabIndex = 0;
            this.btnSelectIpmitool.Text = "指定ipmitool路徑";
            this.btnSelectIpmitool.UseVisualStyleBackColor = true;
            this.btnSelectIpmitool.Click += new System.EventHandler(this.btnSelectIpmitool_Click);
            // 
            // btnPowerCycle
            // 
            this.btnPowerCycle.Location = new System.Drawing.Point(29, 210);
            this.btnPowerCycle.Name = "btnPowerCycle";
            this.btnPowerCycle.Size = new System.Drawing.Size(117, 56);
            this.btnPowerCycle.TabIndex = 1;
            this.btnPowerCycle.Text = "Power Cycle";
            this.btnPowerCycle.UseVisualStyleBackColor = true;
            this.btnPowerCycle.Click += new System.EventHandler(this.btnPowerCycle_Click);
            // 
            // txtIpmitoolPath
            // 
            this.txtIpmitoolPath.Location = new System.Drawing.Point(166, 86);
            this.txtIpmitoolPath.Name = "txtIpmitoolPath";
            this.txtIpmitoolPath.Size = new System.Drawing.Size(415, 22);
            this.txtIpmitoolPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label1.Location = new System.Drawing.Point(161, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 50;
            this.label1.Text = "txtIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label2.Location = new System.Drawing.Point(161, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "txtUsername";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label3.Location = new System.Drawing.Point(166, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 52;
            this.label3.Text = "txtPassword";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(229, 147);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(316, 22);
            this.txtIP.TabIndex = 53;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(308, 205);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(237, 22);
            this.txtUsername.TabIndex = 54;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(308, 267);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 22);
            this.txtPassword.TabIndex = 55;
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Location = new System.Drawing.Point(29, 347);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(117, 75);
            this.btnPowerOff.TabIndex = 56;
            this.btnPowerOff.Text = "Power OFF";
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // btnPowerOff1
            // 
            this.btnPowerOff1.Location = new System.Drawing.Point(29, 477);
            this.btnPowerOff1.Name = "btnPowerOff1";
            this.btnPowerOff1.Size = new System.Drawing.Size(117, 82);
            this.btnPowerOff1.TabIndex = 57;
            this.btnPowerOff1.Text = "Power_Cycle_delay";
            this.btnPowerOff1.UseVisualStyleBackColor = true;
            this.btnPowerOff1.Click += new System.EventHandler(this.btnPowerOff1_Click);
            // 
            // numTimes
            // 
            this.numTimes.Location = new System.Drawing.Point(244, 490);
            this.numTimes.Name = "numTimes";
            this.numTimes.Size = new System.Drawing.Size(120, 22);
            this.numTimes.TabIndex = 58;
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(244, 537);
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(120, 22);
            this.numDelay.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.label4.Location = new System.Drawing.Point(161, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 60;
            this.label4.Text = "次數";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.label5.Location = new System.Drawing.Point(166, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "延遲幾秒";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.numTimes);
            this.Controls.Add(this.btnPowerOff1);
            this.Controls.Add(this.btnPowerOff);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIpmitoolPath);
            this.Controls.Add(this.btnPowerCycle);
            this.Controls.Add(this.btnSelectIpmitool);
            this.Name = "Form1";
            this.Text = "IPMI";
            ((System.ComponentModel.ISupportInitialize)(this.numTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectIpmitool;
        private System.Windows.Forms.Button btnPowerCycle;
        private System.Windows.Forms.TextBox txtIpmitoolPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Button btnPowerOff1;
        private System.Windows.Forms.NumericUpDown numTimes;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabControl1_SelectedIndexChanged;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

