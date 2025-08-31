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
            throw new NotImplementedException();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            string filePath = "recommendation_history.txt";
            lbhistory.Items.Clear();

            if (File.Exists(filePath))
            {
                // 파일의 모든 줄을 읽어와 리스트박스에 추가
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    lbhistory.Items.Add(line);
                }
            }
            else
            {
                // 파일이 존재하지 않을 경우 메시지 표시
                lbhistory.Items.Add("저장된 내역이 없습니다.");
            }
        }
    }
}
