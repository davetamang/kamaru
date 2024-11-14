namespace Car_Wash_Management
{
    partial class Setting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.txtComaddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCostofGoodSold = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCog = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCog = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddCog = new System.Windows.Forms.Button();
            this.txtSearchCG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostofGoodSold)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(245)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 26);
            this.panel1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCANCEL);
            this.tabPage3.Controls.Add(this.btnSAVE);
            this.tabPage3.Controls.Add(this.txtComaddress);
            this.tabPage3.Controls.Add(this.txtCompanyName);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(941, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Company Name";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.Red;
            this.btnCANCEL.FlatAppearance.BorderSize = 0;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Location = new System.Drawing.Point(749, 258);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(100, 39);
            this.btnCANCEL.TabIndex = 43;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Location = new System.Drawing.Point(551, 258);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(100, 39);
            this.btnSAVE.TabIndex = 41;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // txtComaddress
            // 
            this.txtComaddress.Location = new System.Drawing.Point(254, 146);
            this.txtComaddress.Name = "txtComaddress";
            this.txtComaddress.Size = new System.Drawing.Size(595, 30);
            this.txtComaddress.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(254, 72);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(595, 30);
            this.txtCompanyName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Company Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Company Name :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCostofGoodSold);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cost of Good Sold";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCostofGoodSold
            // 
            this.dgvCostofGoodSold.AllowUserToAddRows = false;
            this.dgvCostofGoodSold.AllowUserToDeleteRows = false;
            this.dgvCostofGoodSold.AllowUserToResizeColumns = false;
            this.dgvCostofGoodSold.AllowUserToResizeRows = false;
            this.dgvCostofGoodSold.BackgroundColor = System.Drawing.Color.White;
            this.dgvCostofGoodSold.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCostofGoodSold.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCostofGoodSold.ColumnHeadersHeight = 29;
            this.dgvCostofGoodSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCostofGoodSold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5,
            this.EditCog,
            this.DeleteCog});
            this.dgvCostofGoodSold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCostofGoodSold.EnableHeadersVisualStyles = false;
            this.dgvCostofGoodSold.Location = new System.Drawing.Point(3, 3);
            this.dgvCostofGoodSold.Name = "dgvCostofGoodSold";
            this.dgvCostofGoodSold.RowHeadersVisible = false;
            this.dgvCostofGoodSold.RowHeadersWidth = 51;
            this.dgvCostofGoodSold.RowTemplate.Height = 24;
            this.dgvCostofGoodSold.Size = new System.Drawing.Size(953, 296);
            this.dgvCostofGoodSold.TabIndex = 4;
            this.dgvCostofGoodSold.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCostofGoodSold_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 62;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 55;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 81;
            // 
            // EditCog
            // 
            this.EditCog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditCog.HeaderText = "";
            this.EditCog.Image = ((System.Drawing.Image)(resources.GetObject("EditCog.Image")));
            this.EditCog.MinimumWidth = 6;
            this.EditCog.Name = "EditCog";
            this.EditCog.Width = 6;
            // 
            // DeleteCog
            // 
            this.DeleteCog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteCog.HeaderText = "";
            this.DeleteCog.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCog.Image")));
            this.DeleteCog.MinimumWidth = 6;
            this.DeleteCog.Name = "DeleteCog";
            this.DeleteCog.Width = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.btnAddCog);
            this.panel3.Controls.Add(this.txtSearchCG);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 112);
            this.panel3.TabIndex = 3;
            // 
            // btnAddCog
            // 
            this.btnAddCog.FlatAppearance.BorderSize = 0;
            this.btnAddCog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCog.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCog.Image")));
            this.btnAddCog.Location = new System.Drawing.Point(843, 45);
            this.btnAddCog.Name = "btnAddCog";
            this.btnAddCog.Size = new System.Drawing.Size(50, 50);
            this.btnAddCog.TabIndex = 5;
            this.btnAddCog.UseVisualStyleBackColor = true;
            this.btnAddCog.Click += new System.EventHandler(this.btnAddCog_Click);
            // 
            // txtSearchCG
            // 
            this.txtSearchCG.Location = new System.Drawing.Point(112, 55);
            this.txtSearchCG.Name = "txtSearchCG";
            this.txtSearchCG.Size = new System.Drawing.Size(222, 30);
            this.txtSearchCG.TabIndex = 4;
            this.txtSearchCG.TextChanged += new System.EventHandler(this.txtSearchCG_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 448);
            this.tabControl1.TabIndex = 3;
            // 
            // Setting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(967, 474);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostofGoodSold)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCANCEL;
        public System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.TextBox txtComaddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvCostofGoodSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn EditCog;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddCog;
        private System.Windows.Forms.TextBox txtSearchCG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}