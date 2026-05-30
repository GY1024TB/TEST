using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace NCatTelnetTool
{
    public class NCatManager
    {
        private Process ncatProcess;
        private StringBuilder outputBuffer;
        private bool isRunning;

        public event Action<string> OutputReceived;
        public event Action<string> ErrorReceived;
        public event Action ConnectionClosed;

        public NCatManager()
        {
            outputBuffer = new StringBuilder();
            isRunning = false;
        }

        public bool Connect(string host, int port)
        {
            try
            {
                if (isRunning)
                {
                    Disconnect();
                }

                ncatProcess = new Process();
                ncatProcess.StartInfo.FileName = "ncat";
                ncatProcess.StartInfo.Arguments = string.Format("{0} {1}", host, port);
                ncatProcess.StartInfo.UseShellExecute = false;
                ncatProcess.StartInfo.RedirectStandardInput = true;
                ncatProcess.StartInfo.RedirectStandardOutput = true;
                ncatProcess.StartInfo.RedirectStandardError = true;
                ncatProcess.StartInfo.CreateNoWindow = true;
                ncatProcess.StartInfo.StandardOutputEncoding = Encoding.GetEncoding("gb2312");
                ncatProcess.StartInfo.StandardErrorEncoding = Encoding.GetEncoding("gb2312");

                ncatProcess.OutputDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        OnOutputReceived(e.Data);
                    }
                };

                ncatProcess.ErrorDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        OnErrorReceived(e.Data);
                    }
                };

                ncatProcess.EnableRaisingEvents = true;
                ncatProcess.Exited += (sender, e) =>
                {
                    isRunning = false;
                    OnConnectionClosed();
                };

                ncatProcess.Start();
                ncatProcess.BeginOutputReadLine();
                ncatProcess.BeginErrorReadLine();
                isRunning = true;

                return true;
            }
            catch (Exception ex)
            {
                OnErrorReceived("连接失败: " + ex.Message);
                return false;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (ncatProcess != null && !ncatProcess.HasExited)
                {
                    ncatProcess.Kill();
                    ncatProcess.WaitForExit();
                    ncatProcess.Dispose();
                }
            }
            catch
            {
            }
            finally
            {
                isRunning = false;
                ncatProcess = null;
            }
        }

        public void SendCommand(string command)
        {
            try
            {
                if (ncatProcess != null && !ncatProcess.HasExited)
                {
                    ncatProcess.StandardInput.WriteLine(command);
                    ncatProcess.StandardInput.Flush();
                }
            }
            catch (Exception ex)
            {
                OnErrorReceived("发送命令失败: " + ex.Message);
            }
        }

        public bool IsConnected
        {
            get { return isRunning; }
        }

        protected virtual void OnOutputReceived(string data)
        {
            if (OutputReceived != null)
            {
                OutputReceived(data);
            }
        }

        protected virtual void OnErrorReceived(string data)
        {
            if (ErrorReceived != null)
            {
                ErrorReceived(data);
            }
        }

        protected virtual void OnConnectionClosed()
        {
            if (ConnectionClosed != null)
            {
                ConnectionClosed();
            }
        }
    }
}
