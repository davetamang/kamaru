namespace Car_Wash_Management
{
    partial class Manage_service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_service));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblSid = new System.Windows.Forms.Label();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(245)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 26);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Manage Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Service Name :";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(186, 83);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(483, 30);
            this.txtServiceName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Price :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(186, 140);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(483, 30);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(64, 213);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(34, 21);
            this.lblSid.TabIndex = 44;
            this.lblSid.Text = "Sid";
            this.lblSid.Visible = false;
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.Red;
            this.btnCANCEL.FlatAppearance.BorderSize = 0;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Location = new System.Drawing.Point(531, 195);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(100, 39);
            this.btnCANCEL.TabIndex = 4;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUPDATE.FlatAppearance.BorderSize = 0;
            this.btnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUPDATE.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.ForeColor = System.Drawing.Color.White;
            this.btnUPDATE.Location = new System.Drawing.Point(350, 195);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(100, 39);
            this.btnUPDATE.TabIndex = 3;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = false;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Location = new System.Drawing.Point(165, 195);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(100, 39);
            this.btnSAVE.TabIndex = 2;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(639, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manage_service
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(708, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSid);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_service";
            this.Text = "Manage_service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtServiceName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.Button btnCANCEL;
        public System.Windows.Forms.Button btnUPDATE;
        public System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button button1;
    }
}