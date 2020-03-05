using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moded_DirectoryScanner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btn_run_Click(object sender, EventArgs e)
        {
            List<String> dirs = new List<string>();
            dirs.AddRange(File.ReadAllLines("dirs.txt"));

            btn_run.Enabled = false;
            Thread t = new Thread(() =>
            {
                foreach (var d in dirs)
                    Task.Factory.StartNew(() =>
                    {
                        System.Net.HttpStatusCode respStatusCode = FindAdmins(txt_url.Text, d);
                        txt_logs.Invoke((MethodInvoker)delegate { txt_logs.AppendText($"http://{txt_url.Text}/{d} -> {(int)respStatusCode}{Environment.NewLine}"); });
                        if (respStatusCode == System.Net.HttpStatusCode.OK)
                            txt_founded.Invoke((MethodInvoker)delegate { txt_founded.AppendText($"http://{txt_url.Text}/{d} -> {(int)respStatusCode}{Environment.NewLine}"); });
                    });
            });
            t.Start();
        }

        private System.Net.HttpStatusCode FindAdmins(String url, String adminPath)
        {
            var clinet = new RestClient("http://www." + url + "/" + adminPath);
            var req = new RestRequest(Method.GET);

            var resp = clinet.Get(req);
            return resp.StatusCode;
        }
    }
}
