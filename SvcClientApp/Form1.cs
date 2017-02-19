using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace SvcClientApp
{
    public partial class Form1 : Form
    {
        private readonly Uri _svcBaseAddress = new Uri("http://localhost:58949/Svc/");
        private volatile int _syncCounter;
        private volatile int _asyncCounter;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCallSync_Click(object sender, EventArgs e)
        {
            _syncCounter += 1;
            lblSyncResult.Text = _syncCounter.ToString();
            using (var client = new WebClient())
            {
                lbSyncResult.Items.Add(client.DownloadString(new Uri(_svcBaseAddress, "Wait")));
            }
        }

        private async void btnCallAsync_Click(object sender, EventArgs e)
        {
            _asyncCounter += 1;
            lblAsyncCounter.Text = _asyncCounter.ToString();
            using (var client = new WebClient())
            {
                lbAsyncResult.Items.Add(await client.DownloadStringTaskAsync(new Uri(_svcBaseAddress, "WaitAsync")));
            }
        }
    }
}
