using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        private enum Move { Stone = 0, Paper = 1, Scissors = 2 }
        private int playerWins = 0;
        private int computerWins = 0;
        private int ties = 0;
        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
            UpdateScoreLabels();
            DrawPlaceholderImages();
        }

        private void DrawPlaceholderImages()
        {
            // Draw simple text placeholders if no images are provided in resources
            DrawTextInPictureBox(playerPictureBox, "玩家\n?", Color.LightBlue);
            DrawTextInPictureBox(computerPictureBox, "電腦\n?", Color.LightCoral);
        }

        private void DrawTextInPictureBox(PictureBox pb, string text, Color backColor)
        {
            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(backColor);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(text, new Font("微軟正黑體", 18), Brushes.Black, new RectangleF(0, 0, bmp.Width, bmp.Height), sf);
            }
            // Dispose previous image
            var old = pb.Image;
            pb.Image = bmp;
            old?.Dispose();
        }

        private Move GetComputerMove()
        {
            return (Move)rng.Next(0, 3);
        }

        private void PlayRound(Move playerMove)
        {
            var computerMove = GetComputerMove();
            // Update picture boxes
            DrawTextInPictureBox(playerPictureBox, "玩家\n" + MoveToString(playerMove), Color.LightBlue);
            DrawTextInPictureBox(computerPictureBox, "電腦\n" + MoveToString(computerMove), Color.LightCoral);

            int result = (3 + (int)playerMove - (int)computerMove) % 3; // 0 tie, 1 win, 2 lose
            if (result == 0)
            {
                ties++;
                resultLabel.Text = "平手!";
            }
            else if (result == 1)
            {
                playerWins++;
                resultLabel.Text = "玩家獲勝!";
            }
            else
            {
                computerWins++;
                resultLabel.Text = "電腦獲勝!";
            }

            UpdateScoreLabels();
        }

        private string MoveToString(Move m)
        {
            switch (m)
            {
                case Move.Stone: return "石頭";
                case Move.Paper: return "布";
                case Move.Scissors: return "剪刀";
                default: return "?";
            }
        }

        private void UpdateScoreLabels()
        {
            playerWinsLabel.Text = $"玩家勝場: {playerWins}";
            computerWinsLabel.Text = $"電腦勝場: {computerWins}";
            tiesLabel.Text = $"平手: {ties}";
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
            PlayRound(Move.Stone);
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            PlayRound(Move.Paper);
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            PlayRound(Move.Scissors);
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            // Show statistics and exit
            string message = $"遊戲結束\n玩家勝場: {playerWins}\n電腦勝場: {computerWins}\n平手: {ties}";
            MessageBox.Show(message, "遊戲統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            playerWins = 0;
            computerWins = 0;
            ties = 0;
            UpdateScoreLabels();
            resultLabel.Text = "已重置，請開始新的遊戲";
            DrawPlaceholderImages();
        }
    }
}
