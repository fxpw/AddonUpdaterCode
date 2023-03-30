﻿using AddonUpdater.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void DirectoryDelete(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            try
            {
                if (Directory.Exists(path))
                    directory.Delete(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Предупреждение");
            }
        }

        private Task DownloadAppTask(string link)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadFileTaskAsync(link, "AddonUpdater.zip");
            }
        }
        AddonUpdaterSetting setting;
       

        private void Backup(AddonUpdaterSetting setting)
        {
            if(setting != null)
            if (Directory.Exists("Backup"))
            {
                for (int i = 0; i < setting.Files.Count; i++)
                {
                    if (File.Exists(setting.Files[i])) File.Delete(setting.Files[i]);
                }

                for (int i = 0; i < setting.Files.Count; i++)
                {
                    if (File.Exists($"Backup\\{setting.Files[i]}")) File.Move($"Backup\\{setting.Files[i]}", setting.Files[i]);
                }
                File.Delete("AddonUpdater.zip");
                DirectoryDelete("AddonUpdater-main");
                DirectoryDelete("Backup");
            }
            Application.Exit();
        }

        private void Extract(AddonUpdaterSetting setting)
        {
            ZipFile.ExtractToDirectory("AddonUpdater.zip", Directory.GetCurrentDirectory());

            for (int i = 0; i < setting.Files.Count; i++)
            {
                if (File.Exists($"AddonUpdater-main\\{setting.Files[i]}")) File.Move($"AddonUpdater-main\\{setting.Files[i]}", Directory.GetCurrentDirectory() + $"\\{setting.Files[i]}");
            }
            Process.Start("AddonUpdater.exe");
            File.Delete("AddonUpdater.zip");
            DirectoryDelete("AddonUpdater-main");          
        }

        private void ErrorMsg(int hResult)
        {
            if (hResult == -2146233079)
            {
                MessageBox.Show("Ошибка подключения, повторите попытку позже.", "Ошибка");

            }
            if (hResult == -2147467259)
            {
                MessageBox.Show("Операция была отменена пользователем.", "Ошибка");
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_Resize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public string GetContent(string url)
        {
            string result = null;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            try
            {
                Stream stream = client.OpenRead(url);
                StreamReader reader = new StreamReader(stream);
                result = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                ErrorMsg(ex.HResult);
            }
            return result;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(setting != null)
            {
                if (File.Exists("Backup")) {                   
                    Backup(setting);
                }
               
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Process[] proc = Process.GetProcessesByName("AddonUpdater");
            if (proc.Length > 0) proc[0].Kill();

            try
            {
                string content = GetContent("https://raw.githubusercontent.com/Mr-Dan/AddonUpdaterSettings/main/MainSettings");
                if (content != null)
                {
                    setting = JsonConvert.DeserializeObject<AddonUpdaterSetting>(content);
                    if (Directory.Exists("AddonUpdater-main")) DirectoryDelete("AddonUpdater-main");
                    if (File.Exists("AddonUpdater.zip")) File.Delete("AddonUpdater.zip");
                    await DownloadAppTask("https://github.com/Mr-Dan/AddonUpdater/archive/refs/heads/main.zip");

                    if (File.Exists("Backup")) DirectoryDelete("Backup");
                    Directory.CreateDirectory("Backup");

                    for (int i = 0; i < setting.Files.Count; i++)
                    {
                        if (File.Exists(setting.Files[i])) File.Move(setting.Files[i], $"Backup\\{setting.Files[i]}");
                    }
                    try
                    {
                        Extract(setting);
                    }
                    catch (Exception ex)
                    {
                        ErrorMsg(ex.HResult);
                        Backup(setting);
                    }

                }

            }
            catch (Exception ex)
            {
                ErrorMsg(ex.HResult);
                Backup(setting);
            }


            if (Directory.Exists("Backup")) DirectoryDelete("Backup");

            Application.Exit();
        }
    }
}
