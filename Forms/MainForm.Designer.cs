namespace NCatTelnetTool.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grpConnections = new System.Windows.Forms.GroupBox();
            this.btnDisconnectAll = new System.Windows.Forms.Button();
            this.btnDisconnectSingle = new System.Windows.Forms.Button();
            this.btnConnectAll = new System.Windows.Forms.Button();
            this.btnConnectSingle = new System.Windows.Forms.Button();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.lstConnections = new System.Windows.Forms.ListBox();
            this.grpCommandProxies = new System.Windows.Forms.GroupBox();
            this.btnDeleteCommandProxy = new System.Windows.Forms.Button();
            this.btnEditCommandProxy = new System.Windows.Forms.Button();
            this.btnAddCommandProxy = new System.Windows.Forms.Button();
            this.lstCommandProxies = new System.Windows.Forms.ListBox();
            this.grpTerminal = new System.Windows.Forms.GroupBox();
            this.btnClearTerminal = new System.Windows.Forms.Button();
            this.btnSendCommandToAll = new System.Windows.Forms.Button();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtTerminal = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grpConnections.SuspendLayout();
            this.grpCommandProxies.SuspendLayout();
            this.grpTerminal.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpTerminal);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 600);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grpConnections);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grpCommandProxies);
            this.splitContainer2.Size = new System.Drawing.Size(300, 600);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 0;
            // 
            // grpConnections
            // 
            this.grpConnections.Controls.Add(this.btnDisconnectAll);
            this.grpConnections.Controls.Add(this.btnDisconnectSingle);
            this.grpConnections.Controls.Add(this.btnConnectAll);
            this.grpConnections.Controls.Add(this.btnConnectSingle);
            this.grpConnections.Controls.Add(this.btnAddConnection);
            this.grpConnections.Controls.Add(this.lstConnections);
            this.grpConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpConnections.Location = new System.Drawing.Point(0, 0);
            this.grpConnections.Name = "grpConnections";
            this.grpConnections.Size = new System.Drawing.Size(300, 300);
            this.grpConnections.TabIndex = 0;
            this.grpConnections.TabStop = false;
            this.grpConnections.Text = "连接列表";
            // 
            // btnDisconnectAll
            // 
            this.btnDisconnectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectAll.Location = new System.Drawing.Point(150, 270);
            this.btnDisconnectAll.Name = "btnDisconnectAll";
            this.btnDisconnectAll.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnectAll.TabIndex = 5;
            this.btnDisconnectAll.Text = "断开全部";
            this.btnDisconnectAll.UseVisualStyleBackColor = true;
            this.btnDisconnectAll.Click += new System.EventHandler(this.btnDisconnectAll_Click);
            // 
            // btnDisconnectSingle
            // 
            this.btnDisconnectSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisconnectSingle.Location = new System.Drawing.Point(80, 270);
            this.btnDisconnectSingle.Name = "btnDisconnectSingle";
            this.btnDisconnectSingle.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnectSingle.TabIndex = 4;
            this.btnDisconnectSingle.Text = "断开选中";
            this.btnDisconnectSingle.UseVisualStyleBackColor = true;
            this.btnDisconnectSingle.Click += new System.EventHandler(this.btnDisconnectSingle_Click);
            // 
            // btnConnectAll
            // 
            this.btnConnectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectAll.Location = new System.Drawing.Point(150, 240);
            this.btnConnectAll.Name = "btnConnectAll";
            this.btnConnectAll.Size = new System.Drawing.Size(75, 23);
            this.btnConnectAll.TabIndex = 3;
            this.btnConnectAll.Text = "连接全部";
            this.btnConnectAll.UseVisualStyleBackColor = true;
            this.btnConnectAll.Click += new System.EventHandler(this.btnConnectAll_Click);
            // 
            // btnConnectSingle
            // 
            this.btnConnectSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnectSingle.Location = new System.Drawing.Point(80, 240);
            this.btnConnectSingle.Name = "btnConnectSingle";
            this.btnConnectSingle.Size = new System.Drawing.Size(75, 23);
            this.btnConnectSingle.TabIndex = 2;
            this.btnConnectSingle.Text = "连接选中";
            this.btnConnectSingle.UseVisualStyleBackColor = true;
            this.btnConnectSingle.Click += new System.EventHandler(this.btnConnectSingle_Click);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddConnection.Location = new System.Drawing.Point(10, 240);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(65, 53);
            this.btnAddConnection.TabIndex = 1;
            this.btnAddConnection.Text = "添加连接";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // lstConnections
            // 
            this.lstConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstConnections.FormattingEnabled = true;
            this.lstConnections.Location = new System.Drawing.Point(10, 20);
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.Size = new System.Drawing.Size(280, 212);
            this.lstConnections.TabIndex = 0;
            this.lstConnections.SelectedIndexChanged += new System.EventHandler(this.lstConnections_SelectedIndexChanged);
            // 
            // grpCommandProxies
            // 
            this.grpCommandProxies.Controls.Add(this.btnDeleteCommandProxy);
            this.grpCommandProxies.Controls.Add(this.btnEditCommandProxy);
            this.grpCommandProxies.Controls.Add(this.btnAddCommandProxy);
            this.grpCommandProxies.Controls.Add(this.lstCommandProxies);
            this.grpCommandProxies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCommandProxies.Location = new System.Drawing.Point(0, 0);
            this.grpCommandProxies.Name = "grpCommandProxies";
            this.grpCommandProxies.Size = new System.Drawing.Size(300, 296);
            this.grpCommandProxies.TabIndex = 0;
            this.grpCommandProxies.TabStop = false;
            this.grpCommandProxies.Text = "命令代理";
            // 
            // btnAddCommandProxy
            // 
            this.btnAddCommandProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCommandProxy.Location = new System.Drawing.Point(150, 265);
            this.btnAddCommandProxy.Name = "btnAddCommandProxy";
            this.btnAddCommandProxy.Size = new System.Drawing.Size(75, 23);
            this.btnAddCommandProxy.TabIndex = 1;
            this.btnAddCommandProxy.Text = "添加";
            this.btnAddCommandProxy.UseVisualStyleBackColor = true;
            this.btnAddCommandProxy.Click += new System.EventHandler(this.btnAddCommandProxy_Click);
            // 
            // btnEditCommandProxy
            // 
            this.btnEditCommandProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCommandProxy.Location = new System.Drawing.Point(75, 265);
            this.btnEditCommandProxy.Name = "btnEditCommandProxy";
            this.btnEditCommandProxy.Size = new System.Drawing.Size(75, 23);
            this.btnEditCommandProxy.TabIndex = 2;
            this.btnEditCommandProxy.Text = "修改";
            this.btnEditCommandProxy.UseVisualStyleBackColor = true;
            this.btnEditCommandProxy.Click += new System.EventHandler(this.btnEditCommandProxy_Click);
            // 
            // btnDeleteCommandProxy
            // 
            this.btnDeleteCommandProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCommandProxy.Location = new System.Drawing.Point(10, 265);
            this.btnDeleteCommandProxy.Name = "btnDeleteCommandProxy";
            this.btnDeleteCommandProxy.Size = new System.Drawing.Size(65, 23);
            this.btnDeleteCommandProxy.TabIndex = 3;
            this.btnDeleteCommandProxy.Text = "删除";
            this.btnDeleteCommandProxy.UseVisualStyleBackColor = true;
            this.btnDeleteCommandProxy.Click += new System.EventHandler(this.btnDeleteCommandProxy_Click);
            // 
            // lstCommandProxies
            // 
            this.lstCommandProxies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCommandProxies.FormattingEnabled = true;
            this.lstCommandProxies.Location = new System.Drawing.Point(10, 20);
            this.lstCommandProxies.Name = "lstCommandProxies";
            this.lstCommandProxies.Size = new System.Drawing.Size(280, 212);
            this.lstCommandProxies.TabIndex = 0;
            this.lstCommandProxies.DoubleClick += new System.EventHandler(this.lstCommandProxies_DoubleClick);
            // 
            // grpTerminal
            // 
            this.grpTerminal.Controls.Add(this.btnClearTerminal);
            this.grpTerminal.Controls.Add(this.btnSendCommandToAll);
            this.grpTerminal.Controls.Add(this.btnSendCommand);
            this.grpTerminal.Controls.Add(this.txtCommand);
            this.grpTerminal.Controls.Add(this.txtTerminal);
            this.grpTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTerminal.Location = new System.Drawing.Point(0, 0);
            this.grpTerminal.Name = "grpTerminal";
            this.grpTerminal.Size = new System.Drawing.Size(696, 600);
            this.grpTerminal.TabIndex = 0;
            this.grpTerminal.TabStop = false;
            this.grpTerminal.Text = "终端输出";
            // 
            // btnClearTerminal
            // 
            this.btnClearTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTerminal.Location = new System.Drawing.Point(610, 565);
            this.btnClearTerminal.Name = "btnClearTerminal";
            this.btnClearTerminal.Size = new System.Drawing.Size(75, 23);
            this.btnClearTerminal.TabIndex = 4;
            this.btnClearTerminal.Text = "清空";
            this.btnClearTerminal.UseVisualStyleBackColor = true;
            this.btnClearTerminal.Click += new System.EventHandler(this.btnClearTerminal_Click);
            // 
            // btnSendCommandToAll
            // 
            this.btnSendCommandToAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCommandToAll.Location = new System.Drawing.Point(525, 565);
            this.btnSendCommandToAll.Name = "btnSendCommandToAll";
            this.btnSendCommandToAll.Size = new System.Drawing.Size(80, 23);
            this.btnSendCommandToAll.TabIndex = 3;
            this.btnSendCommandToAll.Text = "发送到全部";
            this.btnSendCommandToAll.UseVisualStyleBackColor = true;
            this.btnSendCommandToAll.Click += new System.EventHandler(this.btnSendCommandToAll_Click);
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendCommand.Location = new System.Drawing.Point(440, 565);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(80, 23);
            this.btnSendCommand.TabIndex = 2;
            this.btnSendCommand.Text = "发送到选中";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.Location = new System.Drawing.Point(10, 567);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(420, 21);
            this.txtCommand.TabIndex = 1;
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            // 
            // txtTerminal
            // 
            this.txtTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTerminal.BackColor = System.Drawing.Color.Black;
            this.txtTerminal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminal.ForeColor = System.Drawing.Color.Lime;
            this.txtTerminal.Location = new System.Drawing.Point(10, 20);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.ReadOnly = true;
            this.txtTerminal.Size = new System.Drawing.Size(676, 540);
            this.txtTerminal.TabIndex = 0;
            this.txtTerminal.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "NCat批量Telnet工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grpConnections.ResumeLayout(false);
            this.grpCommandProxies.ResumeLayout(false);
            this.grpTerminal.ResumeLayout(false);
            this.grpTerminal.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grpConnections;
        private System.Windows.Forms.GroupBox grpCommandProxies;
        private System.Windows.Forms.GroupBox grpTerminal;
        private System.Windows.Forms.ListBox lstConnections;
        private System.Windows.Forms.Button btnAddConnection;
        private System.Windows.Forms.Button btnConnectAll;
        private System.Windows.Forms.Button btnConnectSingle;
        private System.Windows.Forms.ListBox lstCommandProxies;
        private System.Windows.Forms.Button btnAddCommandProxy;
        private System.Windows.Forms.Button btnEditCommandProxy;
        private System.Windows.Forms.Button btnDeleteCommandProxy;
        private System.Windows.Forms.RichTextBox txtTerminal;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.Button btnSendCommandToAll;
        private System.Windows.Forms.Button btnClearTerminal;
        private System.Windows.Forms.Button btnDisconnectAll;
        private System.Windows.Forms.Button btnDisconnectSingle;
    }
}
