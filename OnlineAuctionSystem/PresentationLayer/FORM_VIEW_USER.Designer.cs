namespace OnlineAuctionSystem.PresentationLayer
{
    partial class FORM_VIEW_USER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_VIEW_USER));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.txtSearchAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close1 = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.tabSeller = new System.Windows.Forms.TabPage();
            this.txtSearchSeller = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.close2 = new System.Windows.Forms.Button();
            this.btnDeleteSeller = new System.Windows.Forms.Button();
            this.dgvSeller = new System.Windows.Forms.DataGridView();
            this.tabBidder = new System.Windows.Forms.TabPage();
            this.txtSearchBidder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.close3 = new System.Windows.Forms.Button();
            this.btnDeleteBidder = new System.Windows.Forms.Button();
            this.dgvBidder = new System.Windows.Forms.DataGridView();
            this.tab.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.tabSeller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
            this.tabBidder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidder)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabAdmin);
            this.tab.Controls.Add(this.tabSeller);
            this.tab.Controls.Add(this.tabBidder);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(725, 356);
            this.tab.TabIndex = 0;
            // 
            // tabAdmin
            // 
            this.tabAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabAdmin.BackgroundImage")));
            this.tabAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAdmin.Controls.Add(this.txtSearchAdmin);
            this.tabAdmin.Controls.Add(this.label1);
            this.tabAdmin.Controls.Add(this.close1);
            this.tabAdmin.Controls.Add(this.btnDeleteAdmin);
            this.tabAdmin.Controls.Add(this.dgvAdmin);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(717, 330);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.Text = "     Admins     ";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // txtSearchAdmin
            // 
            this.txtSearchAdmin.Location = new System.Drawing.Point(208, 14);
            this.txtSearchAdmin.Name = "txtSearchAdmin";
            this.txtSearchAdmin.Size = new System.Drawing.Size(308, 20);
            this.txtSearchAdmin.TabIndex = 4;
            this.txtSearchAdmin.TextChanged += new System.EventHandler(this.txtSearchAdmin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search :";
            // 
            // close1
            // 
            this.close1.Location = new System.Drawing.Point(378, 288);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(90, 31);
            this.close1.TabIndex = 2;
            this.close1.Text = "Close !";
            this.close1.UseVisualStyleBackColor = true;
            this.close1.Click += new System.EventHandler(this.close1_Click);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Enabled = false;
            this.btnDeleteAdmin.Location = new System.Drawing.Point(223, 288);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(149, 31);
            this.btnDeleteAdmin.TabIndex = 1;
            this.btnDeleteAdmin.Text = "Delete Selected Admin";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(6, 40);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(705, 240);
            this.dgvAdmin.TabIndex = 0;
            // 
            // tabSeller
            // 
            this.tabSeller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSeller.BackgroundImage")));
            this.tabSeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSeller.Controls.Add(this.txtSearchSeller);
            this.tabSeller.Controls.Add(this.label2);
            this.tabSeller.Controls.Add(this.close2);
            this.tabSeller.Controls.Add(this.btnDeleteSeller);
            this.tabSeller.Controls.Add(this.dgvSeller);
            this.tabSeller.Location = new System.Drawing.Point(4, 22);
            this.tabSeller.Name = "tabSeller";
            this.tabSeller.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeller.Size = new System.Drawing.Size(717, 330);
            this.tabSeller.TabIndex = 1;
            this.tabSeller.Text = "     Sellers     ";
            this.tabSeller.UseVisualStyleBackColor = true;
            // 
            // txtSearchSeller
            // 
            this.txtSearchSeller.Location = new System.Drawing.Point(208, 14);
            this.txtSearchSeller.Name = "txtSearchSeller";
            this.txtSearchSeller.Size = new System.Drawing.Size(308, 20);
            this.txtSearchSeller.TabIndex = 9;
            this.txtSearchSeller.TextChanged += new System.EventHandler(this.txtSearchSeller_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search :";
            // 
            // close2
            // 
            this.close2.Location = new System.Drawing.Point(378, 288);
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(90, 31);
            this.close2.TabIndex = 7;
            this.close2.Text = "Close !";
            this.close2.UseVisualStyleBackColor = true;
            this.close2.Click += new System.EventHandler(this.close2_Click);
            // 
            // btnDeleteSeller
            // 
            this.btnDeleteSeller.Enabled = false;
            this.btnDeleteSeller.Location = new System.Drawing.Point(223, 288);
            this.btnDeleteSeller.Name = "btnDeleteSeller";
            this.btnDeleteSeller.Size = new System.Drawing.Size(149, 31);
            this.btnDeleteSeller.TabIndex = 6;
            this.btnDeleteSeller.Text = "Delete Selected Seller";
            this.btnDeleteSeller.UseVisualStyleBackColor = true;
            this.btnDeleteSeller.Click += new System.EventHandler(this.btnDeleteSeller_Click);
            // 
            // dgvSeller
            // 
            this.dgvSeller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeller.Location = new System.Drawing.Point(6, 40);
            this.dgvSeller.Name = "dgvSeller";
            this.dgvSeller.ReadOnly = true;
            this.dgvSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeller.Size = new System.Drawing.Size(705, 240);
            this.dgvSeller.TabIndex = 5;
            // 
            // tabBidder
            // 
            this.tabBidder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabBidder.BackgroundImage")));
            this.tabBidder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabBidder.Controls.Add(this.txtSearchBidder);
            this.tabBidder.Controls.Add(this.label3);
            this.tabBidder.Controls.Add(this.close3);
            this.tabBidder.Controls.Add(this.btnDeleteBidder);
            this.tabBidder.Controls.Add(this.dgvBidder);
            this.tabBidder.Location = new System.Drawing.Point(4, 22);
            this.tabBidder.Name = "tabBidder";
            this.tabBidder.Padding = new System.Windows.Forms.Padding(3);
            this.tabBidder.Size = new System.Drawing.Size(717, 330);
            this.tabBidder.TabIndex = 2;
            this.tabBidder.Text = "      Bidders     ";
            this.tabBidder.UseVisualStyleBackColor = true;
            // 
            // txtSearchBidder
            // 
            this.txtSearchBidder.Location = new System.Drawing.Point(208, 14);
            this.txtSearchBidder.Name = "txtSearchBidder";
            this.txtSearchBidder.Size = new System.Drawing.Size(308, 20);
            this.txtSearchBidder.TabIndex = 9;
            this.txtSearchBidder.TextChanged += new System.EventHandler(this.txtSearchBidder_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search :";
            // 
            // close3
            // 
            this.close3.Location = new System.Drawing.Point(378, 288);
            this.close3.Name = "close3";
            this.close3.Size = new System.Drawing.Size(90, 31);
            this.close3.TabIndex = 7;
            this.close3.Text = "Close !";
            this.close3.UseVisualStyleBackColor = true;
            this.close3.Click += new System.EventHandler(this.close3_Click);
            // 
            // btnDeleteBidder
            // 
            this.btnDeleteBidder.Enabled = false;
            this.btnDeleteBidder.Location = new System.Drawing.Point(223, 288);
            this.btnDeleteBidder.Name = "btnDeleteBidder";
            this.btnDeleteBidder.Size = new System.Drawing.Size(149, 31);
            this.btnDeleteBidder.TabIndex = 6;
            this.btnDeleteBidder.Text = "Delete Selected Bidder";
            this.btnDeleteBidder.UseVisualStyleBackColor = true;
            this.btnDeleteBidder.Click += new System.EventHandler(this.btnDeleteBidder_Click);
            // 
            // dgvBidder
            // 
            this.dgvBidder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBidder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBidder.Location = new System.Drawing.Point(6, 40);
            this.dgvBidder.Name = "dgvBidder";
            this.dgvBidder.ReadOnly = true;
            this.dgvBidder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBidder.Size = new System.Drawing.Size(705, 240);
            this.dgvBidder.TabIndex = 5;
            // 
            // FORM_VIEW_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 380);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FORM_VIEW_USER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.tab.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.tabSeller.ResumeLayout(false);
            this.tabSeller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).EndInit();
            this.tabBidder.ResumeLayout(false);
            this.tabBidder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.TabPage tabSeller;
        private System.Windows.Forms.TabPage tabBidder;
        private System.Windows.Forms.TextBox txtSearchAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close1;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.TextBox txtSearchSeller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close2;
        private System.Windows.Forms.Button btnDeleteSeller;
        private System.Windows.Forms.DataGridView dgvSeller;
        private System.Windows.Forms.TextBox txtSearchBidder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button close3;
        private System.Windows.Forms.Button btnDeleteBidder;
        private System.Windows.Forms.DataGridView dgvBidder;
    }
}