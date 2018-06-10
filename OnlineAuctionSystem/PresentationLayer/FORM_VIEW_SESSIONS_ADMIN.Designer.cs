namespace OnlineAuctionSystem.PresentationLayer
{
    partial class FORM_VIEW_SESSIONS_ADMIN
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSubscribe = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreateSession = new System.Windows.Forms.Button();
            this.txtSeachCreated = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSessionCreated = new System.Windows.Forms.DataGridView();
            this.tabSessionsResult = new System.Windows.Forms.TabPage();
            this.btnViewSessionDeatils = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSearchSubscribed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSubscribedSession = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnViewBidDeatils = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSearchStarted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStartedSsesions = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabSubscribe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionCreated)).BeginInit();
            this.tabSessionsResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribedSession)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStartedSsesions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSubscribe);
            this.tabControl1.Controls.Add(this.tabSessionsResult);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(14, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 343);
            this.tabControl1.TabIndex = 2;
            // 
            // tabSubscribe
            // 
            this.tabSubscribe.Controls.Add(this.button2);
            this.tabSubscribe.Controls.Add(this.btnCreateSession);
            this.tabSubscribe.Controls.Add(this.txtSeachCreated);
            this.tabSubscribe.Controls.Add(this.label1);
            this.tabSubscribe.Controls.Add(this.dgvSessionCreated);
            this.tabSubscribe.Location = new System.Drawing.Point(4, 22);
            this.tabSubscribe.Name = "tabSubscribe";
            this.tabSubscribe.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubscribe.Size = new System.Drawing.Size(715, 317);
            this.tabSubscribe.TabIndex = 0;
            this.tabSubscribe.Text = "SessionCretaed";
            this.tabSubscribe.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close !";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCreateSession
            // 
            this.btnCreateSession.Location = new System.Drawing.Point(193, 265);
            this.btnCreateSession.Name = "btnCreateSession";
            this.btnCreateSession.Size = new System.Drawing.Size(166, 36);
            this.btnCreateSession.TabIndex = 8;
            this.btnCreateSession.Text = "Create Session";
            this.btnCreateSession.UseVisualStyleBackColor = true;
            this.btnCreateSession.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSeachCreated
            // 
            this.txtSeachCreated.Location = new System.Drawing.Point(207, 15);
            this.txtSeachCreated.Name = "txtSeachCreated";
            this.txtSeachCreated.Size = new System.Drawing.Size(308, 20);
            this.txtSeachCreated.TabIndex = 7;
            this.txtSeachCreated.TextChanged += new System.EventHandler(this.txtSeachCreated_TextChanged);
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
            // dgvSessionCreated
            // 
            this.dgvSessionCreated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessionCreated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessionCreated.Location = new System.Drawing.Point(5, 41);
            this.dgvSessionCreated.Name = "dgvSessionCreated";
            this.dgvSessionCreated.ReadOnly = true;
            this.dgvSessionCreated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessionCreated.Size = new System.Drawing.Size(705, 218);
            this.dgvSessionCreated.TabIndex = 5;
            // 
            // tabSessionsResult
            // 
            this.tabSessionsResult.Controls.Add(this.btnViewSessionDeatils);
            this.tabSessionsResult.Controls.Add(this.button3);
            this.tabSessionsResult.Controls.Add(this.txtSearchSubscribed);
            this.tabSessionsResult.Controls.Add(this.label2);
            this.tabSessionsResult.Controls.Add(this.dgvSubscribedSession);
            this.tabSessionsResult.Location = new System.Drawing.Point(4, 22);
            this.tabSessionsResult.Name = "tabSessionsResult";
            this.tabSessionsResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabSessionsResult.Size = new System.Drawing.Size(715, 317);
            this.tabSessionsResult.TabIndex = 1;
            this.tabSessionsResult.Text = "Subscribed Session";
            this.tabSessionsResult.UseVisualStyleBackColor = true;
            // 
            // btnViewSessionDeatils
            // 
            this.btnViewSessionDeatils.Location = new System.Drawing.Point(177, 265);
            this.btnViewSessionDeatils.Name = "btnViewSessionDeatils";
            this.btnViewSessionDeatils.Size = new System.Drawing.Size(166, 36);
            this.btnViewSessionDeatils.TabIndex = 15;
            this.btnViewSessionDeatils.Text = "View Session Details";
            this.btnViewSessionDeatils.UseVisualStyleBackColor = true;
            this.btnViewSessionDeatils.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Close !";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSearchSubscribed
            // 
            this.txtSearchSubscribed.Location = new System.Drawing.Point(207, 15);
            this.txtSearchSubscribed.Name = "txtSearchSubscribed";
            this.txtSearchSubscribed.Size = new System.Drawing.Size(308, 20);
            this.txtSearchSubscribed.TabIndex = 12;
            this.txtSearchSubscribed.TextChanged += new System.EventHandler(this.txtSearchSubscribed_TextChanged);
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
            // dgvSubscribedSession
            // 
            this.dgvSubscribedSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubscribedSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscribedSession.Location = new System.Drawing.Point(5, 41);
            this.dgvSubscribedSession.Name = "dgvSubscribedSession";
            this.dgvSubscribedSession.ReadOnly = true;
            this.dgvSubscribedSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscribedSession.Size = new System.Drawing.Size(705, 218);
            this.dgvSubscribedSession.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnViewBidDeatils);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.txtSearchStarted);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvStartedSsesions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 317);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Started Sessions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnViewBidDeatils
            // 
            this.btnViewBidDeatils.Location = new System.Drawing.Point(204, 268);
            this.btnViewBidDeatils.Name = "btnViewBidDeatils";
            this.btnViewBidDeatils.Size = new System.Drawing.Size(166, 36);
            this.btnViewBidDeatils.TabIndex = 15;
            this.btnViewBidDeatils.Text = "View Bid Detail";
            this.btnViewBidDeatils.UseVisualStyleBackColor = true;
            this.btnViewBidDeatils.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(389, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 36);
            this.button5.TabIndex = 14;
            this.button5.Text = "Close !";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtSearchStarted
            // 
            this.txtSearchStarted.Location = new System.Drawing.Point(207, 15);
            this.txtSearchStarted.Name = "txtSearchStarted";
            this.txtSearchStarted.Size = new System.Drawing.Size(308, 20);
            this.txtSearchStarted.TabIndex = 12;
            this.txtSearchStarted.TextChanged += new System.EventHandler(this.txtSearchStarted_TextChanged);
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
            // dgvStartedSsesions
            // 
            this.dgvStartedSsesions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStartedSsesions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStartedSsesions.Location = new System.Drawing.Point(5, 41);
            this.dgvStartedSsesions.Name = "dgvStartedSsesions";
            this.dgvStartedSsesions.ReadOnly = true;
            this.dgvStartedSsesions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStartedSsesions.Size = new System.Drawing.Size(705, 218);
            this.dgvStartedSsesions.TabIndex = 10;
            // 
            // FORM_VIEW_SESSIONS_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 380);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FORM_VIEW_SESSIONS_ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessions";
            this.tabControl1.ResumeLayout(false);
            this.tabSubscribe.ResumeLayout(false);
            this.tabSubscribe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionCreated)).EndInit();
            this.tabSessionsResult.ResumeLayout(false);
            this.tabSessionsResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribedSession)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStartedSsesions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSubscribe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreateSession;
        private System.Windows.Forms.TextBox txtSeachCreated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSessionCreated;
        private System.Windows.Forms.TabPage tabSessionsResult;
        private System.Windows.Forms.Button btnViewSessionDeatils;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSearchSubscribed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSubscribedSession;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnViewBidDeatils;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSearchStarted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvStartedSsesions;
    }
}