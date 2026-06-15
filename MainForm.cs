using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace DNS_DoAn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckQuyen();
        }

        private void CheckQuyen()
        {
            if (UserSession.IsLoggedIn)
            {
                lblStatus.Text = "User: " + UserSession.CurrentUser + " (Chủ sở hữu)";
                btnHistory.Visible = true;
            }
            else
            {
                lblStatus.Text = "User: Khách";
                btnHistory.Visible = false;
            }
        }

        private void BtnLookup_Click(object sender, EventArgs e)
        {
            string domain = txtDomain.Text.Trim();
            if (domain == "") return;

            try
            {
                string host = domain;
                if (domain.Contains("://")) host = new Uri(domain).Host;

                IPAddress[] ips = Dns.GetHostAddresses(host);

                lstResult.Items.Clear();
                string log = "";

                foreach (IPAddress ip in ips)
                {
                    lstResult.Items.Add(ip.ToString());
                    log += ip.ToString() + "; ";
                }

                if (UserSession.IsLoggedIn) UserSession.AddHistory(host, log);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void TxtDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLookup_Click(sender, e);
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            var history = UserSession.GetMyHistory();
            if (history.Count == 0) MessageBox.Show("Chưa có lịch sử.");
            else MessageBox.Show(string.Join("\n", history));
        }
    }
}