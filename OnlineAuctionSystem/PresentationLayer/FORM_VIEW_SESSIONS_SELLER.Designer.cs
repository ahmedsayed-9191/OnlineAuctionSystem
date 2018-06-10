namespace OnlineAuctionSystem.PresentationLayer
{
    partial class FORM_VIEW_SESSIONS_SELLER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_VIEW_SESSIONS_SELLER));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSubscribe = new System.Windows.Forms.TabPage();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.txtSearchSubscribe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSubscribe = new System.Windows.Forms.DataGridView();
            this.tabSessionsResult = new System.Windows.Forms.TabPage();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtMySession = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMySession = new System.Windows.Forms.DataGridView();
            this.tabMonitorBiding = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMonitorBiding = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMonitorBiding = new System.Windows.Forms.DataGridView();
            this.tabSessionResult = new System.Windows.Forms.TabPage();
            this.btnClose3 = new System.Windows.Forms.Button();
            this.txtSearchResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSessionsResult = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabSubscribe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribe)).BeginInit();
            this.tabSessionsResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMySession)).BeginInit();
            this.tabMonitorBiding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitorBiding)).BeginInit();
            this.tabSessionResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionsResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSubscribe);
            this.tabControl1.Controls.Add(this.tabSessionsResult);
            this.tabControl1.Controls.Add(this.tabMonitorBiding);
            this.tabControl1.Controls.Add(this.tabSessionResult);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 343);
            this.tabControl1.TabIndex = 1;
            // 
            // tabSubscribe
            // 
            this.tabSubscribe.Controls.Add(this.btnclose);
            this.tabSubscribe.Controls.Add(this.btnSubscribe);
            this.tabSubscribe.Controls.Add(this.txtSearchSubscribe);
            this.tabSubscribe.Controls.Add(this.label1);
            this.tabSubscribe.Controls.Add(this.dgvSubscribe);
            this.tabSubscribe.Location = new System.Drawing.Point(4, 22);
            this.tabSubscribe.Name = "tabSubscribe";
            this.tabSubscribe.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubscribe.Size = new System.Drawing.Size(715, 317);
            this.tabSubscribe.TabIndex = 0;
            this.tabSubscribe.Text = "SubscribeSessions";
            this.tabSubscribe.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(379, 270);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(166, 36);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "Close !";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(207, 270);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(166, 36);
            this.btnSubscribe.TabIndex = 8;
            this.btnSubscribe.Text = "Subscribe Selected Session";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // txtSearchSubscribe
            // 
            this.txtSearchSubscribe.Location = new System.Drawing.Point(207, 15);
            this.txtSearchSubscribe.Name = "txtSearchSubscribe";
            this.txtSearchSubscribe.Size = new System.Drawing.Size(308, 20);
            this.txtSearchSubscribe.TabIndex = 7;
            this.txtSearchSubscribe.TextChanged += new System.EventHandler(this.txtSearchSubscribe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search :";
            // 
            // dgvSubscribe
            // 
            this.dgvSubscribe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubscribe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscribe.Location = new System.Drawing.Point(5, 41);
            this.dgvSubscribe.Name = "dgvSubscribe";
            this.dgvSubscribe.ReadOnly = true;
            this.dgvSubscribe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscribe.Size = new System.Drawing.Size(705, 218);
            this.dgvSubscribe.TabIndex = 5;
            // 
            // tabSessionsResult
            // 
            this.tabSessionsResult.Controls.Add(this.btnClose2);
            this.tabSessionsResult.Controls.Add(this.btnAddItem);
            this.tabSessionsResult.Controls.Add(this.txtMySession);
            this.tabSessionsResult.Controls.Add(this.label2);
            this.tabSessionsResult.Controls.Add(this.dgvMySession);
            this.tabSessionsResult.Location = new System.Drawing.Point(4, 22);
            this.tabSessionsResult.Name = "tabSessionsResult";
            this.tabSessionsResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabSessionsResult.Size = new System.Drawing.Size(715, 317);
            this.tabSessionsResult.TabIndex = 1;
            this.tabSessionsResult.Text = "MySessions AddItem";
            this.tabSessionsResult.UseVisualStyleBackColor = true;
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(355, 265);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(166, 36);
            this.btnClose2.TabIndex = 14;
            this.btnClose2.Text = "Close !";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(183, 265);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(166, 36);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtMySession
            // 
            this.txtMySession.Location = new System.Drawing.Point(207, 15);
            this.txtMySession.Name = "txtMySession";
            this.txtMySession.Size = new System.Drawing.Size(308, 20);
            this.txtMySession.TabIndex = 12;
            this.txtMySession.TextChanged += new System.EventHandler(this.txtMySession_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search :";
            // 
            // dgvMySession
            // 
            this.dgvMySession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMySession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMySession.Location = new System.Drawing.Point(5, 41);
            this.dgvMySession.Name = "dgvMySession";
            this.dgvMySession.ReadOnly = true;
            this.dgvMySession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMySession.Size = new System.Drawing.Size(705, 218);
            this.dgvMySession.TabIndex = 10;
            // 
            // tabMonitorBiding
            // 
            this.tabMonitorBiding.Controls.Add(this.button1);
            this.tabMonitorBiding.Controls.Add(this.txtMonitorBiding);
            this.tabMonitorBiding.Controls.Add(this.label4);
            this.tabMonitorBiding.Controls.Add(this.dgvMonitorBiding);
            this.tabMonitorBiding.Location = new System.Drawing.Point(4, 22);
            this.tabMonitorBiding.Name = "tabMonitorBiding";
            this.tabMonitorBiding.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitorBiding.Size = new System.Drawing.Size(715, 317);
            this.tabMonitorBiding.TabIndex = 3;
            this.tabMonitorBiding.Text = "Monitor biding";
            this.tabMonitorBiding.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMonitorBiding
            // 
            this.txtMonitorBiding.Location = new System.Drawing.Point(207, 26);
            this.txtMonitorBiding.Name = "txtMonitorBiding";
            this.txtMonitorBiding.Size = new System.Drawing.Size(308, 20);
            this.txtMonitorBiding.TabIndex = 15;
            this.txtMonitorBiding.TextChanged += new System.EventHandler(this.txtMonitorBiding_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search :";
            // 
            // dgvMonitorBiding
            // 
            this.dgvMonitorBiding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonitorBiding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonitorBiding.Location = new System.Drawing.Point(5, 52);
            this.dgvMonitorBiding.Name = "dgvMonitorBiding";
            this.dgvMonitorBiding.ReadOnly = true;
            this.dgvMonitorBiding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonitorBiding.Size = new System.Drawing.Size(705, 218);
            this.dgvMonitorBiding.TabIndex = 13;
            // 
            // tabSessionResult
            // 
            this.tabSessionResult.Controls.Add(this.btnClose3);
            this.tabSessionResult.Controls.Add(this.txtSearchResult);
            this.tabSessionResult.Controls.Add(this.label3);
            this.tabSessionResult.Controls.Add(this.dgvSessionsResult);
            this.tabSessionResult.Location = new System.Drawing.Point(4, 22);
            this.tabSessionResult.Name = "tabSessionResult";
            this.tabSessionResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabSessionResult.Size = new System.Drawing.Size(715, 317);
            this.tabSessionResult.TabIndex = 2;
            this.tabSessionResult.Text = "SessionsResult";
            this.tabSessionResult.UseVisualStyleBackColor = true;
            // 
            // btnClose3
            // 
            this.btnClose3.Location = new System.Drawing.Point(248, 265);
            this.btnClose3.Name = "btnClose3";
            this.btnClose3.Size = new System.Drawing.Size(166, 36);
            this.btnClose3.TabIndex = 14;
            this.btnClose3.Text = "Close !";
            this.btnClose3.UseVisualStyleBackColor = true;
            this.btnClose3.Click += new System.EventHandler(this.btnClose3_Click);
            // 
            // txtSearchResult
            // 
            this.txtSearchResult.Location = new System.Drawing.Point(207, 15);
            this.txtSearchResult.Name = "txtSearchResult";
            this.txtSearchResult.Size = new System.Drawing.Size(308, 20);
            this.txtSearchResult.TabIndex = 12;
            this.txtSearchResult.TextChanged += new System.EventHandler(this.txtSearchResult_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search :";
            // 
            // dgvSessionsResult
            // 
            this.dgvSessionsResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessionsResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessionsResult.Location = new System.Drawing.Point(5, 41);
            this.dgvSessionsResult.Name = "dgvSessionsResult";
            this.dgvSessionsResult.ReadOnly = true;
            this.dgvSessionsResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessionsResult.Size = new System.Drawing.Size(705, 218);
            this.dgvSessionsResult.TabIndex = 10;
            // 
            // FORM_VIEW_SESSIONS_SELLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 367);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FORM_VIEW_SESSIONS_SELLER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessions";
            this.tabControl1.ResumeLayout(false);
            this.tabSubscribe.ResumeLayout(false);
            this.tabSubscribe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribe)).EndInit();
            this.tabSessionsResult.ResumeLayout(false);
            this.tabSessionsResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMySession)).EndInit();
            this.tabMonitorBiding.ResumeLayout(false);
            this.tabMonitorBiding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitorBiding)).EndInit();
            this.tabSessionResult.ResumeLayout(false);
            this.tabSessionResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionsResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSubscribe;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtSearchSubscribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSubscribe;
        private System.Windows.Forms.TabPage tabSessionsResult;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtMySession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMySession;
        private System.Windows.Forms.TabPage tabSessionResult;
        private System.Windows.Forms.Button btnClose3;
        private System.Windows.Forms.TextBox txtSearchResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSessionsResult;
        private System.Windows.Forms.TabPage tabMonitorBiding;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMonitorBiding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMonitorBiding;
    }
}