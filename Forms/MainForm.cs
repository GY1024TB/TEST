using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NCatTelnetTool.Models;

namespace NCatTelnetTool.Forms
{
    public partial class MainForm : Form
    {
        private List<ConnectionInfo> connections;
        private List<CommandProxy> commandProxies;
        private Dictionary<ConnectionInfo, NCatManager> activeConnections;
        private ConnectionInfo selectedConnection;

        public MainForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            connections = new List<ConnectionInfo>();
            commandProxies = new List<CommandProxy>();
            activeConnections = new Dictionary<ConnectionInfo, NCatManager>();
            selectedConnection = null;

            // 添加默认命令代理
            commandProxies.Add(new CommandProxy("查看系统信息", "uname -a"));
            commandProxies.Add(new CommandProxy("查看IP地址", "ip addr"));
            commandProxies.Add(new CommandProxy("查看磁盘空间", "df -h"));
            commandProxies.Add(new CommandProxy("查看内存使用", "free -h"));
            commandProxies.Add(new CommandProxy("查看进程列表", "ps aux"));

            RefreshConnectionList();
            RefreshCommandProxyList();
        }

        private void RefreshConnectionList()
        {
            lstConnections.Items.Clear();
            foreach (var conn in connections)
            {
                lstConnections.Items.Add(conn);
            }
        }

        private void RefreshCommandProxyList()
        {
            lstCommandProxies.Items.Clear();
            foreach (var proxy in commandProxies)
            {
                lstCommandProxies.Items.Add(proxy);
            }
        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            using (var form = new AddConnectionForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    connections.Add(form.ConnectionInfo);
                    RefreshConnectionList();
                }
            }
        }

        private void btnAddCommandProxy_Click(object sender, EventArgs e)
        {
            using (var form = new AddCommandProxyForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    commandProxies.Add(form.CommandProxy);
                    RefreshCommandProxyList();
                }
            }
        }

        private void btnEditCommandProxy_Click(object sender, EventArgs e)
        {
            if (lstCommandProxies.SelectedItem is CommandProxy proxy)
            {
                using (var form = new AddCommandProxyForm(proxy))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        RefreshCommandProxyList();
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择要修改的命令代理", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteCommandProxy_Click(object sender, EventArgs e)
        {
            if (lstCommandProxies.SelectedItem is CommandProxy proxy)
            {
                if (MessageBox.Show(
                    string.Format("确定要删除命令代理 \"{0}\" 吗？", proxy.ChineseName),
                    "确认删除",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    commandProxies.Remove(proxy);
                    RefreshCommandProxyList();
                }
            }
            else
            {
                MessageBox.Show("请先选择要删除的命令代理", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConnectSingle_Click(object sender, EventArgs e)
        {
            if (lstConnections.SelectedItem is ConnectionInfo conn)
            {
                ConnectToConnection(conn);
            }
            else
            {
                MessageBox.Show("请先选择一个连接", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConnectAll_Click(object sender, EventArgs e)
        {
            foreach (var conn in connections)
            {
                ConnectToConnection(conn);
            }
        }

        private void ConnectToConnection(ConnectionInfo conn)
        {
            if (!activeConnections.ContainsKey(conn))
            {
                var manager = new NCatManager();
                manager.OutputReceived += (data) => AppendOutput(conn, data);
                manager.ErrorReceived += (data) => AppendError(conn, data);
                manager.ConnectionClosed += () => OnConnectionClosed(conn);

                if (manager.Connect(conn.Host, conn.Port))
                {
                    conn.IsConnected = true;
                    activeConnections[conn] = manager;
                    AppendOutput(conn, string.Format("[已连接到 {0}:{1}]", conn.Host, conn.Port));
                }
                else
                {
                    MessageBox.Show(string.Format("连接 {0} 失败", conn.Name), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshConnectionList();
        }

        private void OnConnectionClosed(ConnectionInfo conn)
        {
            conn.IsConnected = false;
            if (activeConnections.ContainsKey(conn))
            {
                activeConnections.Remove(conn);
            }
            AppendOutput(conn, "[连接已关闭]");
            if (selectedConnection == conn)
            {
                selectedConnection = null;
            }
            RefreshConnectionList();
        }

        private void AppendOutput(ConnectionInfo conn, string message)
        {
            if (txtTerminal.InvokeRequired)
            {
                txtTerminal.Invoke(new Action(() => AppendOutput(conn, message)));
                return;
            }

            if (selectedConnection == conn || selectedConnection == null)
            {
                txtTerminal.AppendText(string.Format("[{0}] {1}\r\n", conn.Name, message));
            }
        }

        private void AppendError(ConnectionInfo conn, string message)
        {
            if (txtTerminal.InvokeRequired)
            {
                txtTerminal.Invoke(new Action(() => AppendError(conn, message)));
                return;
            }

            txtTerminal.SelectionColor = Color.Red;
            txtTerminal.AppendText(string.Format("[{0}] 错误: {1}\r\n", conn.Name, message));
            txtTerminal.SelectionColor = txtTerminal.ForeColor;
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            string command = txtCommand.Text.Trim();
            if (string.IsNullOrEmpty(command))
            {
                MessageBox.Show("请输入要发送的命令", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SendCommandToSelected(command);
            txtCommand.Clear();
        }

        private void SendCommandToSelected(string command)
        {
            if (selectedConnection != null && activeConnections.ContainsKey(selectedConnection))
            {
                activeConnections[selectedConnection].SendCommand(command);
                AppendOutput(selectedConnection, string.Format("> {0}", command));
            }
            else
            {
                MessageBox.Show("请先选择一个已连接的终端", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSendCommandToAll_Click(object sender, EventArgs e)
        {
            string command = txtCommand.Text.Trim();
            if (string.IsNullOrEmpty(command))
            {
                MessageBox.Show("请输入要发送的命令", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SendCommandToAll(command);
            txtCommand.Clear();
        }

        private void SendCommandToAll(string command)
        {
            foreach (var kvp in activeConnections)
            {
                kvp.Value.SendCommand(command);
                AppendOutput(kvp.Key, string.Format("> {0}", command));
            }
        }

        private void lstConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedConnection = lstConnections.SelectedItem as ConnectionInfo;
        }

        private void lstCommandProxies_DoubleClick(object sender, EventArgs e)
        {
            if (lstCommandProxies.SelectedItem is CommandProxy proxy)
            {
                txtCommand.Text = proxy.Command;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var manager in activeConnections.Values)
            {
                manager.Disconnect();
            }
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnSendCommand_Click(sender, e);
            }
        }

        private void btnClearTerminal_Click(object sender, EventArgs e)
        {
            txtTerminal.Clear();
        }

        private void btnDisconnectSingle_Click(object sender, EventArgs e)
        {
            if (selectedConnection != null && activeConnections.ContainsKey(selectedConnection))
            {
                activeConnections[selectedConnection].Disconnect();
            }
            else
            {
                MessageBox.Show("请先选择一个已连接的终端", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDisconnectAll_Click(object sender, EventArgs e)
        {
            foreach (var manager in activeConnections.Values)
            {
                manager.Disconnect();
            }
        }
    }
}
