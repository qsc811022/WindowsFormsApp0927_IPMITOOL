using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0927
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectIpmitool_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 將選定的路徑設定到 TextBox 中
                    txtIpmitoolPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnPowerCycle_Click(object sender, EventArgs e)
        {
            string ipmitoolPath = txtIpmitoolPath.Text;
            string ip = txtIP.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // 確保所有必要的資訊都已經填寫
            if (string.IsNullOrEmpty(ipmitoolPath) || string.IsNullOrEmpty(ip) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請確保所有欄位都已填寫!");
                return;
            }

            try
            {
                // 使用 Process 來執行 ipmitool 的 power cycle
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = ipmitoolPath,
                    Arguments = $"-I lanplus -H {ip} -U {username} -P {password} chassis power cycle", // 更新參數以包含 IP, 用戶名和密碼
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string errorOutput = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(output))
                    {
                        MessageBox.Show(output);
                    }
                    if (!string.IsNullOrEmpty(errorOutput))
                    {
                        MessageBox.Show("錯誤: " + errorOutput);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("執行時發生錯誤: " + ex.Message);
            }
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            string ipmitoolPath = txtIpmitoolPath.Text;
            string ip = txtIP.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // 確保所有必要的資訊都已經填寫
            if (string.IsNullOrEmpty(ipmitoolPath) || string.IsNullOrEmpty(ip) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請確保所有欄位都已填寫!");
                return;
            }

            try
            {
                // 使用 Process 來執行 ipmitool 的 power off
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = ipmitoolPath,
                    Arguments = $"-I lanplus -H {ip} -U {username} -P {password} chassis power off", // 使用 "power off" 命令
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string errorOutput = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(output))
                    {
                        MessageBox.Show(output);
                    }
                    if (!string.IsNullOrEmpty(errorOutput))
                    {
                        MessageBox.Show("錯誤: " + errorOutput);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("執行時發生錯誤: " + ex.Message);
            }
        }

        private void btnPowerOff1_Click(object sender, EventArgs e)
        {
            string ipmitoolPath = txtIpmitoolPath.Text;
            string ip = txtIP.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int times = (int)numTimes.Value;  // 從 NumericUpDown 控件中獲取執行次數
            int delayInSeconds = (int)numDelay.Value;  // 從 NumericUpDown 控件中獲取延遲時間

            // 確保所有必要的資訊都已經填寫
            if (string.IsNullOrEmpty(ipmitoolPath) || string.IsNullOrEmpty(ip) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請確保所有欄位都已填寫!");
                return;
            }

            try
            {
                // 使用 Process 來執行 ipmitool 的 power off
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = ipmitoolPath,
                    Arguments = $"-I lanplus -H {ip} -U {username} -P {password} chassis power off",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                for (int i = 0; i < times; i++)
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;
                        process.Start();

                        string output = process.StandardOutput.ReadToEnd();
                        string errorOutput = process.StandardError.ReadToEnd();
                        process.WaitForExit();

                        if (!string.IsNullOrEmpty(output))
                        {
                            MessageBox.Show($"第 {i + 1} 次執行結果: {output}");
                        }
                        if (!string.IsNullOrEmpty(errorOutput))
                        {
                            MessageBox.Show($"第 {i + 1} 次執行錯誤: " + errorOutput);
                        }
                    }

                    // 如果不是最後一次執行，則延遲指定的秒數
                    if (i < times - 1)
                    {
                        System.Threading.Thread.Sleep(delayInSeconds * 1000);  // 將秒數轉換為毫秒
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("執行時發生錯誤: " + ex.Message);
            }
        }

   
    }
}
