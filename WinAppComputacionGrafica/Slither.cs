using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinAppComputacionGrafica
{
    public partial class Slither : Form
    {
        private const int gridSize = 20;
        private const int gridWidth = 30;
        private const int gridHeight = 20;
        private List<Point> snake;
        private Point food;
        private Direction direction;
        private bool gameover;
        private Random random;
        private Timer timer;

        public Slither()
        {
            InitializeComponent();
            InitializeGame();
            InitializeTimer();
        }
        private void Slither_Load(object sender, EventArgs e)
        {

        }
        private void InitializeGame()
        {
            snake = new List<Point>();
            snake.Add(new Point(gridWidth / 2, gridHeight / 2));
            direction = Direction.Right;
            gameover = false;
            random = new Random();
            GenerateFood();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 100; // Intervalo de actualización en milisegundos
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void GenerateFood()
        {
            int x = random.Next(0, gridWidth);
            int y = random.Next(0, gridHeight);
            food = new Point(x, y);
        }

        private void MoveSnake()
        {
            Point head = snake.First();
            Point newHead = new Point(head.X, head.Y);

            switch (direction)
            {
                case Direction.Up:
                    newHead.Y--;
                    break;
                case Direction.Down:
                    newHead.Y++;
                    break;
                case Direction.Left:
                    newHead.X--;
                    break;
                case Direction.Right:
                    newHead.X++;
                    break;
            }

            if (newHead.X < 0 || newHead.X >= gridWidth || newHead.Y < 0 || newHead.Y >= gridHeight)
            {
                gameover = true;
                return;
            }

            if (snake.Contains(newHead))
            {
                gameover = true;
                return;
            }

            snake.Insert(0, newHead);

            if (newHead == food)
            {
                GenerateFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (direction != Direction.Down)
                        direction = Direction.Up;
                    break;
                case Keys.Down:
                    if (direction != Direction.Up)
                        direction = Direction.Down;
                    break;
                case Keys.Left:
                    if (direction != Direction.Right)
                        direction = Direction.Left;
                    break;
                case Keys.Right:
                    if (direction != Direction.Left)
                        direction = Direction.Right;
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!gameover)
            {
                MoveSnake();
                Refresh();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Game Over");
                InitializeGame();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics canvas = e.Graphics;
            DrawSnake(canvas);
            DrawFood(canvas);
        }

        private void DrawFood(Graphics canvas)
        {
            Brush brush = new SolidBrush(Color.Red);
            canvas.FillRectangle(brush, food.X * gridSize, food.Y * gridSize, gridSize, gridSize);
        }

        private void DrawSnake(Graphics canvas)
        {
            Brush brush = new SolidBrush(Color.Green);

            foreach (Point segment in snake)
            {
                canvas.FillRectangle(brush, segment.X * gridSize, segment.Y * gridSize, gridSize, gridSize);
            }
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

}
