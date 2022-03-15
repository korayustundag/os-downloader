using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace OSDownloader
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private Os sys;
        private bool isDownloading = false;
        private readonly string GithubList = "https://raw.githubusercontent.com/korayustundag/os-downloader/main/public/List.json";

        private void MainFrm_Load(object sender, EventArgs e)
        {
            string ff = ReadList();
            sys = JsonConvert.DeserializeObject<Os>(ff);
            foreach (string Name in sys.Names)
            {
                listBoxOSList.Items.Add(Name);
            }
            btnDownload.Enabled = false;
        }

        private void listBoxOSList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOSList.SelectedIndex > -1)
            {
                if (!isDownloading)
                {
                    btnDownload.Enabled = true;
                }
            }
            else
            {
                btnDownload.Enabled = false;
            }
        }
        private WebClient client = new WebClient();
        private void Download(string url,string savepath)
        {
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(url), savepath);
            lblBrace.Text = "-";
            isDownloading = true;
            btnDownload.Text = "Cancel";
        }

        static string BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                lblInfo.Text = "Downloading: %" + Math.Truncate(percentage).ToString();
                lblReceive.Text = BytesToString(e.BytesReceived);
                lblTotal.Text = BytesToString(e.TotalBytesToReceive);
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate {
                lblInfo.Text = "Completed";
                btnDownload.Text = "Download";
                lblTotal.Text = "";
                lblReceive.Text = "";
                lblBrace.Text = "";
            });
            isDownloading = false;
        }

        void CancelDownload()
        {
            client.CancelAsync();
            isDownloading = false;
            BeginInvoke((MethodInvoker)delegate
            {
                lblInfo.Text = "Canceled";
                btnDownload.Text = "Download";
                progressBar1.Value = 0;
            });
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (isDownloading)
            {
                CancelDownload();
            }
            else
            {
                string Url = sys.Links[listBoxOSList.SelectedIndex].ToString();
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "ISO Image|*.iso";
                save.FileName = Path.GetFileName(Url);
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Download(Url, save.FileName);
                }
            }
        }

        private string ReadList()
        {
            try
            {
                WebClient wc = new WebClient();
                string json = wc.DownloadString(GithubList);
                return json;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to get list of operating systems from server! Please make sure you are using the latest version.");
                System.Diagnostics.Process.Start("https://github.com/korayustundag/os-downloader", "Operating System Downloader");
                Environment.Exit(1);
                return null;
            }
        }

    }
}
