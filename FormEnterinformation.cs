using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyBrew
{
    public partial class FormEnterinformation : Form
    {

        private CoffeeFortune fortune = new CoffeeFortune();
        private string pickmood = "";

        public FormEnterinformation()
        {
            InitializeComponent();
            btnpick.Enabled = false;

            btnjoy.CheckedChanged += btn_CheckedChanged;
            btntranquility.CheckedChanged += btn_CheckedChanged;
            btnsad.CheckedChanged += btn_CheckedChanged;
            btnanger.CheckedChanged += btn_CheckedChanged;
            btnfatigue.CheckedChanged += btn_CheckedChanged;
            btnanxiety.CheckedChanged += btn_CheckedChanged;
        }

        private void btn_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                pickmood = ((RadioButton)sender).Text;
                btnpick.Enabled = true;
            }
        }

        private void dailyBrew정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformation form = new FormInformation();
            form.ShowDialog();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = new FormHistory();
            form.Show();
        }

        private void btnpick_Click(object sender, EventArgs e)
        {
            string recommendedcoffee = fortune.GetRecommendedCoffee(pickmood);

            FortuneDate data = fortune.GetFortuneData(recommendedcoffee);

            if (data != null)
            {
                pbCoffeeImg.Image = data.CoffeeImage;
                lbcoffeename.Text = $"{data.CoffeeName}";

                rtbAdvice.Clear();
                Random random = new Random();
                string selectAdivce = data.Advices[random.Next(data.Advices.Count)];
                rtbAdvice.Text = selectAdivce;
                savehistory(data, selectAdivce);
            }
            else
            {
                pbCoffeeImg.Image = null;
                lbcoffeename.Text = "운세 로딩 실패";
                rtbAdvice.Clear();
                rtbAdvice.Text = "추천을 가져오는 데 실패했습니다.";
            }
        }

        private void savehistory(FortuneDate data, string selectAdivce)
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = Path.Combine(downloadsPath, "Downloads", "recommendation_history.txt");
            string content = $" 감정: {pickmood}, 커피: {data.CoffeeName}, 조언: {selectAdivce}\n\n";
            File.AppendAllText(filePath, content);
        }
    }
}
