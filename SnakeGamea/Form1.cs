namespace SnakeGamea
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        int maxWidth;
        int maxHeight;
        int score;
        int highScore;
        Random rand = new Random();
        bool goLeft, goRight, goDown, goUp;
        public Form1()
        {
            InitializeComponent();
            new Settings();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;
            Snake.Clear();
            btnStart.Enabled = false;
            score = 0;
            txtScore.Text = "Score: " + score;
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);
            for (int i = 0; i < 5; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            gameTimer.Start();
        }

        private void GameOver()
        {
            gameTimer.Stop();
            btnStart.Enabled = true;
            if (score > highScore)
            {
                highScore = score;
                txtHighscore.Text = "High Score: " + Environment.NewLine + highScore;
                txtHighscore.ForeColor = Color.Maroon;
                txtHighscore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
        private void EatFood()
        {
            score += 1;
            txtScore.Text = "Score: " + score;
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body);
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }
        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.direction != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.direction != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.direction != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.direction != "up")
            {
                goDown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;
            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }
                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //SNAKE CONTROLL 
            if (goLeft)
            {
                Settings.direction = "left";
            }
            if (goRight)
            {
                Settings.direction = "right";
            }
            if (goDown)
            {
                Settings.direction = "down";
            }
            if (goUp)
            {
                Settings.direction = "up";
            }


            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }

                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }

            }
            picCanvas.Invalidate();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
