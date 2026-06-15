namespace DNS_DoAn
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLookup = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.lblHeaderResult = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.btnLookup);
            this.pnlTop.Controls.Add(this.txtDomain);
            this.pnlTop.Controls.Add(this.lblInput);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(571, 65);
            this.pnlTop.TabIndex = 0;
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnLookup.FlatAppearance.BorderSize = 0;
            this.btnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLookup.ForeColor = System.Drawing.Color.White;
            this.btnLookup.Location = new System.Drawing.Point(398, 18);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(75, 26);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "TRA CỨU";
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.BtnLookup_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDomain.Location = new System.Drawing.Point(122, 18);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(258, 27);
            this.txtDomain.TabIndex = 1;
            this.txtDomain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDomain_KeyDown);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInput.Location = new System.Drawing.Point(15, 20);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(103, 19);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Nhập tên miền:";
            // 
            // lstResult
            // 
            this.lstResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.lstResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstResult.Font = new System.Drawing.Font("Consolas", 11F);
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 18;
            this.lstResult.Location = new System.Drawing.Point(15, 98);
            this.lstResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(523, 254);
            this.lstResult.TabIndex = 1;
            // 
            // lblHeaderResult
            // 
            this.lblHeaderResult.AutoSize = true;
            this.lblHeaderResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderResult.Location = new System.Drawing.Point(15, 77);
            this.lblHeaderResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeaderResult.Name = "lblHeaderResult";
            this.lblHeaderResult.Size = new System.Drawing.Size(195, 19);
            this.lblHeaderResult.TabIndex = 2;
            this.lblHeaderResult.Text = "Kết quả phân giải địa chỉ IP:";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pnlBottom.Controls.Add(this.btnHistory);
            this.pnlBottom.Controls.Add(this.lblStatus);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 357);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(571, 49);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(440, 9);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(98, 28);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "XEM LỊCH SỬ";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Visible = false;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatus.Location = new System.Drawing.Point(15, 16);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Trạng thái...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 406);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lblHeaderResult);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công cụ Tra cứu DNS & IP (Project .NET)";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label lblHeaderResult;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnHistory;
    }
}