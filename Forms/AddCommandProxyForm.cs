using System;
using System.Windows.Forms;
using NCatTelnetTool.Models;

namespace NCatTelnetTool.Forms
{
    public partial class AddCommandProxyForm : Form
    {
        public CommandProxy CommandProxy { get; private set; }
        private bool isEditMode = false;

        public AddCommandProxyForm()
        {
            InitializeComponent();
            CommandProxy = new CommandProxy();
            this.Text = "添加命令代理";
        }

        public AddCommandProxyForm(CommandProxy proxy)
        {
            InitializeComponent();
            isEditMode = true;
            CommandProxy = proxy;
            txtChineseName.Text = proxy.ChineseName;
            txtCommand.Text = proxy.Command;
            this.Text = "修改命令代理";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtChineseName.Text.Trim();
            string command = txtCommand.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入中文名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(command))
            {
                MessageBox.Show("请输入命令", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditMode)
            {
                CommandProxy.ChineseName = name;
                CommandProxy.Command = command;
            }
            else
            {
                CommandProxy = new CommandProxy(name, command);
            }
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
