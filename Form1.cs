using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public struct GameSettings
    {
        public int Count;
        public int Size;
        public Color WinColor;
        public Color LoseColor;
    }

    public partial class Form1 : Form
    {
        public static GameSettings col;

        Button[] mas = new Button[120];

        Random r = new Random();

        int[] dx = new int[120];
        int[] dy = new int[120];

        int createdCount = 0;
        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            buttonCreate.Click += buttonCreate_Click;
            buttonSettings.Click += buttonSettings_Click;
            buttonExit.Click += buttonExit_Click;

            timer1.Tick += timer1_Tick;

            panelResult.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            col.Count = 60;
            col.Size = 15;

            col.WinColor = Color.Blue;
            col.LoseColor = Color.Red;

            labelResult.Text = "";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DestroyParticles();

            panelResult.Visible = false;
            labelResult.Text = "";

            createdCount = col.Count;

            for (int i = 0; i < col.Count; i++)
            {
                Button button = new Button();

                button.Name = "sh" + i;

                button.Width = col.Size;
                button.Height = col.Size;

                int maxX = panelGame.Width - col.Size;
                int maxY = panelGame.Height - col.Size;

                button.Left = r.Next(0, maxX + 1);
                button.Top = r.Next(0, maxY + 1);

                if (r.Next(2) == 0)
                {
                    button.BackColor = col.WinColor;
                }
                else
                {
                    button.BackColor = col.LoseColor;
                }

                button.FlatStyle = FlatStyle.Flat;
                button.Text = "";

                button.MouseClick += MyMethod;

                dx[i] = r.Next(-3, 4);

                if (dx[i] == 0)
                    dx[i] = 1;

                dy[i] = r.Next(-3, 4);

                if (dy[i] == 0)
                    dy[i] = 1;

                button.Parent = panelGame;

                mas[i] = button;
            }

            timer1.Start();
        }

        private void MyMethod(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
                return;

            btn.Visible = false;

            if (btn.BackColor == col.LoseColor)
            {
                timer1.Stop();

                panelResult.Visible = true;
                panelResult.BackColor = Color.Red;
                labelResult.Text = "Вы проиграли!";

                panelGame.Enabled = false;

                DestroyParticles();

                return;
            }

            bool win = true;

            for (int i = 0; i < createdCount; i++)
            {
                if (mas[i] != null &&
                    mas[i].Visible &&
                    mas[i].BackColor == col.WinColor)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                timer1.Stop();

                panelResult.Visible = true;
                panelResult.BackColor = Color.Green;
                labelResult.Text = "Вы выиграли!";

                DestroyParticles();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < createdCount; i++)
            {
                if (mas[i] == null || !mas[i].Visible)
                    continue;

                Button button = mas[i];

                int newX = button.Left + dx[i];
                int newY = button.Top + dy[i];

                if (newX <= 0 || newX + button.Width >= panelGame.ClientSize.Width)
                {
                    dx[i] = -dx[i];
                    newX = button.Left + dx[i];
                }

                if (newY <= 0 || newY + button.Height >= panelGame.ClientSize.Height)
                {
                    dy[i] = -dy[i];
                    newY = button.Top + dy[i];
                }

                button.Left = newX;
                button.Top = newY;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();

            settingsForm.ShowDialog();

            panelGame.Enabled = true;

            panelResult.Visible = false;
            labelResult.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DestroyParticles()
        {
            timer1.Stop();

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] != null)
                {
                    mas[i].Dispose();
                    mas[i] = null;
                }
            }

            createdCount = 0;
            panelGame.Enabled = true;
        }
    }
}

