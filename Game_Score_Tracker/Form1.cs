namespace Game_Score_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Ball_x = 4;
        int Ball_y = 4;
        int score = 0;


        private void Game_over()
        {
            if (score > 17)
            {
                timer1.Stop();
                MessageBox.Show("You Won :)");
            }
            if (ball.Top + ball.Height > ClientSize.Height)
            {
                timer1.Stop();
                MessageBox.Show("Game Over!");

            }
        }
        private void Get_Score()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        Ball_y = -Ball_y;
                        score++;
                        lbl_score.Text = "Score:" + score;
                    }
                }
            }
        }
        private void Ball_Moverment()
        {
            ball.Left += Ball_x;
            ball.Top += Ball_y;
            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                Ball_x = -Ball_x;
            }
            if (ball.Top < 0 || ball.Bounds.IntersectsWith(player.Bounds))
            {
                Ball_y = -Ball_y;
            }
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                player.Left -= 5;
            }

            if (e.KeyCode == Keys.Right && player.Right < 480)
            {
                player.Left += 5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball_Moverment();
            Get_Score();
            Game_over();
        }
    }
}