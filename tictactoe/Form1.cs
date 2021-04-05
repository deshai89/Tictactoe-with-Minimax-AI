using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            genButtons();
        }
        bool gameover = false;

        Button[,] buttons = new Button[3, 3];

        private void genButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(300, 300);
                    buttons[i, j].Location = new Point(i * 300, j * 300);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 80, FontStyle.Bold);
                    buttons[i, j].Click += new EventHandler(button_c);

                    panel1.Controls.Add(buttons[i, j]);

                }
            }
        }

       

        void button_c(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text != "")
            {
                return;
            }

            button.Text = button1.Text;
            switchPlayer();
            if(gameover == true)
            {
                gameover = false;
            }
        }

        private void switchPlayer()
        {
            checkIfgameEnds();
            if (button1.Text == "X" && gameover == false)
            {
                button1.Text = "O";
            }
            else if (button1.Text != "X" && gameover == false)
            {
                button1.Text = "X";
            }
        }

        private void checkIfgameEnds()
        {
            List<Button> winnerButtons = new List<Button>();

            //vertical win
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(buttons[i, j].Text != button1.Text)
                    {
                        break;
                    }
                    winnerButtons.Add(buttons[i, j]);
                    if (j == 2) 
                    {
                        showwinner(winnerButtons);
                        return;
                    }
                }
            }
            //horizontal win
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();
                for(int j = 0; j < 3; j++)
                {
                    if(buttons[j, i].Text != button1.Text)
                    {
                        break;
                    }
                    winnerButtons.Add(buttons[j, i]);
                    if(j == 2)
                    {
                        showwinner(winnerButtons);
                        return;
                    }
                }
            }
            //diagonal win
            winnerButtons = new List<Button>();
            for(int i = 0, j = 0; i < 3; i++, j++)
            {
                if(buttons[i, j].Text != button1.Text)
                {
                    break;
                }
                winnerButtons.Add(buttons[i, j]);
                if(j ==2)
                {
                    showwinner(winnerButtons);
                    return;
                }
            }
            //diagonal win
            winnerButtons = new List<Button>();
            for (int i = 2, j = 0; j < 3; i--, j++)
            {
                if (buttons[i, j].Text != button1.Text)
                {
                    break;
                }
                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    showwinner(winnerButtons);
                    return;
                }
            }

            foreach(var button in buttons)
            {
                if (button.Text == "")
                    return;
            }
            MessageBox.Show("Tie Game!");
            gameover = true;
            Reset();
        }
        private void showwinner(List<Button> winnerButtons)
        {
            gameover = true;
            if (button1.Text == "X")
            {
                foreach (var button in winnerButtons)
                {
                    button.BackColor = Color.Red;
                }
            }
            else foreach (var button in winnerButtons)
                {
                    button.BackColor = Color.Blue;
                }

            MessageBox.Show("Player " + button1.Text + " wins");
            Reset();

        }

        private void Reset()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            genButtons();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2.Text = buttons[2, ].ToString(); [2,2] final square
        }
    }
}
