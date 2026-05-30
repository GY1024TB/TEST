using System;
using System.Windows.Forms;
using NCatTelnetTool.Models;

namespace NCatTelnetTool.Forms
{
    public partial class AddConnectionForm : Form
    {
        public ConnectionInfo ConnectionInfo { get; private set; }

        public AddConnectionForm()
        {
            InitializeComponent();
            ConnectionInfo = new ConnectionInfo();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string host = txtHost.Text.Trim();
            int port;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入连接名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(host))
            {
                MessageBox.Show("请输入主机地址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPort.Text.Trim(), out port) || port < 1 || port > 65535)
            {
                MessageBox.Show("请输入有效的端口号 (1-65535)", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConnectionInfo = new ConnectionInfo(name, host, port);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
