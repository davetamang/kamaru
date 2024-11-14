namespace Car_Wash_Management
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployer = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblGrossProfit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picGP = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCostofGood = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picCoG = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRevenus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picRevenus = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChild.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 773);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(245)))));
            this.panelSlide.Location = new System.Drawing.Point(3, 182);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 50);
            this.panelSlide.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnCash);
            this.panel2.Controls.Add(this.btnServices);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnEmployer);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 773);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 723);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = " Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 482);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(200, 50);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.Text = " Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 432);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 50);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = " Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCash
            // 
            this.btnCash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCash.Location = new System.Drawing.Point(0, 382);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(200, 50);
            this.btnCash.TabIndex = 7;
            this.btnCash.Text = " Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnServices
            // 
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServices.Image = ((System.Drawing.Image)(resources.GetObject("btnServices.Image")));
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.Location = new System.Drawing.Point(0, 332);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(200, 50);
            this.btnServices.TabIndex = 6;
            this.btnServices.Text = " Services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 282);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(200, 50);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = " Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmployer
            // 
            this.btnEmployer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployer.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployer.Image")));
            this.btnEmployer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployer.Location = new System.Drawing.Point(0, 232);
            this.btnEmployer.Name = "btnEmployer";
            this.btnEmployer.Size = new System.Drawing.Size(200, 50);
            this.btnEmployer.TabIndex = 4;
            this.btnEmployer.Text = " Employer";
            this.btnEmployer.UseVisualStyleBackColor = true;
            this.btnEmployer.Click += new System.EventHandler(this.btnEmployer_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 182);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 50);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(245)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 182);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = " WASH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(245)))));
            this.panelChild.Controls.Add(this.panel7);
            this.panelChild.Controls.Add(this.panel6);
            this.panelChild.Controls.Add(this.panel4);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChild.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panelChild.Location = new System.Drawing.Point(210, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1052, 226);
            this.panelChild.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.lblGrossProfit);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.picGP);
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Location = new System.Drawing.Point(752, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 120);
            this.panel7.TabIndex = 4;
            // 
            // lblGrossProfit
            // 
            this.lblGrossProfit.ForeColor = System.Drawing.Color.Green;
            this.lblGrossProfit.Location = new System.Drawing.Point(8, 37);
            this.lblGrossProfit.Name = "lblGrossProfit";
            this.lblGrossProfit.Size = new System.Drawing.Size(121, 22);
            this.lblGrossProfit.TabIndex = 4;
            this.lblGrossProfit.Text = "0.00";
            this.lblGrossProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Since last 7 days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(8, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "GROSS PROFIT";
            // 
            // picGP
            // 
            this.picGP.Image = global::Car_Wash_Management.Properties.Resources.up_25px;
            this.picGP.Location = new System.Drawing.Point(12, 75);
            this.picGP.Name = "picGP";
            this.picGP.Size = new System.Drawing.Size(35, 35);
            this.picGP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGP.TabIndex = 1;
            this.picGP.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(173, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.lblCostofGood);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.picCoG);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Location = new System.Drawing.Point(396, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 120);
            this.panel6.TabIndex = 3;
            // 
            // lblCostofGood
            // 
            this.lblCostofGood.ForeColor = System.Drawing.Color.Red;
            this.lblCostofGood.Location = new System.Drawing.Point(8, 37);
            this.lblCostofGood.Name = "lblCostofGood";
            this.lblCostofGood.Size = new System.Drawing.Size(121, 22);
            this.lblCostofGood.TabIndex = 4;
            this.lblCostofGood.Text = "0.00";
            this.lblCostofGood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Since last 7 days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 8.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "COST OF GOOD SOLD";
            // 
            // picCoG
            // 
            this.picCoG.Image = global::Car_Wash_Management.Properties.Resources.down_25px;
            this.picCoG.Location = new System.Drawing.Point(12, 75);
            this.picCoG.Name = "picCoG";
            this.picCoG.Size = new System.Drawing.Size(35, 35);
            this.picCoG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoG.TabIndex = 1;
            this.picCoG.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(173, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblRevenus);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.picRevenus);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(42, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 120);
            this.panel4.TabIndex = 2;
            // 
            // lblRevenus
            // 
            this.lblRevenus.ForeColor = System.Drawing.Color.Green;
            this.lblRevenus.Location = new System.Drawing.Point(8, 37);
            this.lblRevenus.Name = "lblRevenus";
            this.lblRevenus.Size = new System.Drawing.Size(121, 22);
            this.lblRevenus.TabIndex = 4;
            this.lblRevenus.Text = "0.00";
            this.lblRevenus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRevenus.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Since last 7 days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "REVENUS";
            // 
            // picRevenus
            // 
            this.picRevenus.Image = global::Car_Wash_Management.Properties.Resources.up_25px;
            this.picRevenus.Location = new System.Drawing.Point(12, 75);
            this.picRevenus.Name = "picRevenus";
            this.picRevenus.Size = new System.Drawing.Size(35, 35);
            this.picRevenus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRevenus.TabIndex = 1;
            this.picRevenus.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(173, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(264, 247);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(967, 474);
            this.panel5.TabIndex = 5;
            // 
            // Mainform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 773);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Mainform";
            this.Text = "Car Wash Management";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChild.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRevenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEmployer;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picRevenus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRevenus;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblGrossProfit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picGP;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCostofGood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picCoG;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
    }
}

