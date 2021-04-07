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
        string[,] board = new string[,]
        {
            {"", "", ""},
            {"", "", ""},
            {"", "", ""},
        };

        bool gameover = false;
        int depth;
        string checker;
        string ai = "X";
        string human = "O";

        Button[,] buttons = new Button[3, 3];
        
        private void genButtons()
        {
            for (int i = 0; i < 3; i++)
            { 
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(150, 150);
                    buttons[i, j].Location = new Point(i * 150, j * 150);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 41, FontStyle.Bold);
                    buttons[i, j].Click += new EventHandler(button_c);
                    //buttons[i, j].TextAlign = ContentAlignment.TopCenter;
                    
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
            if (button1.Text == ai && gameover == false)
            {
                button1.Text = human;
            }
            else if (button1.Text != ai && gameover == false)
            {
                button1.Text = ai;
            }

            if (button1.Text == ai)
            {
                label2.Text = ai + "'s turn";
            }
            else label2.Text = human + "'s turn";
        }

        private string checkIfgameEnds()
        {
            List<Button> winnerButtons = new List<Button>();
           string winner = null;

            //vertical win
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(board[i,j] != button1.Text)
                    {
                        break;
                    }
                    winnerButtons.Add(buttons[i, j]);
                    if (j == 2)
                    {
                        //showwinner(winnerButtons);
                        winner = board[0, i];

                    }
                }
            }
            //horizontal win
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();
                for(int j = 0; j < 3; j++)
                {
                    if(board[j, i] != button1.Text)
                    {
                        break;
                    }
                    winnerButtons.Add(buttons[j, i]);
                    if(j == 2)
                    {
                        //showwinner(winnerButtons);
                        winner = board[i, 0];

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
                    winner = board[0,0];

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
                    winner = board[2, 0];
                }
            }

            foreach(var button in buttons)
            {
                if (button.Text == "")
                    return winner;
                    
            }
            
            MessageBox.Show("Tie Game!");
            gameover = true;
            return "Tie";
            //Reset();
            

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
            gameover = false;

            
        }

        void best()
        {
            int bestscore = -0;
            int[] move = { 0, 0 };
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (gameover == true)
                    { return; }
                    if (board[i, j] == "")
                    {
                        board[i, j] = ai;
                        int score = minimax(board, 0, false);
                        //if (score == 0) { return; }
                        board[i, j] = "";
                        if (score > bestscore)
                        {
                            bestscore = score;
                            move[0] = i;
                            move[1] = j;
                        }
                    }
                }
            }
            if (gameover == true)
            { return; }
            board[move[0], move[1]] = ai;
            buttons[move[0], move[1]].Text = ai;
            switchPlayer();
        }

        

        public int minimax(string[,] board, int depth, bool maxx)
        {            
            string result = checkIfgameEnds();

            int bestscore = -0;
            var hello = new Dictionary<string, int>();
            hello["X"] = 10;
            hello["O"] = -10;
            hello["Tie"] = 0;
            
            
            if (result != null)
            {
                return hello[checkIfgameEnds()];      //result comes out as "" which is wrong and causes error
            }

            if (maxx) 
            {
                bestscore = -0;
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        if(board[i, j] == "")
                        {
                            board[i, j] = ai;
                            //button1.Text = human;
                            int score = minimax(board, depth + 1, false);
                            buttons[i, j].Text = "";
                            board[i, j] = "";
                            bestscore = Math.Max(score, bestscore);
                            
                        }
                    }
                }
                return bestscore;
            }
            else {
                bestscore = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == "")
                        {
                            board[i, j] = human;
                            int score = minimax(board, depth + 1, true);
                            board[i, j] = "";
                            bestscore = Math.Min(score, bestscore);

                        }
                    }
                }
            }
            return bestscore;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            best();
            
        }
    }
}
