using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyBrew
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
            this.Load += FormHistory_Load;
            btnnew.Click += Btnnew_Click;
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = Path.Combine(downloadsPath, "Downloads", "recommendation_history.txt");
            rtbhistory.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    rtbhistory.AppendText(line + Environment.NewLine);
                }
            }
            else
            {   
                rtbhistory.Text = "저장된 내역이 없습니다.";
            }
        }
    }
}
