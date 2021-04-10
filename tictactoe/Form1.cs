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
        {                                       // i is the first #, j is 2nd 
            {"", "", ""},                       // 00 10 20
            {"", "", ""},                       // 01 11 21
            {"", "", ""},                       // 02 12 20
        };

        Random random_move = new Random();
        bool gameover;
        bool human_players;
        bool ai_player = false;
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

                    panel1.Controls.Add(buttons[i, j]);

                    

                }
            }
        }      

        void button_c(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if(human_players)                   //2 player button clicks
            {
                if (button.Text != "")
                {
                    return;
                }

                button.Text = X_O_display_button.Text;
                switchPlayer();
                if(gameover == true)
                {
                    
                    gameover = false;
                }
                return;
            }

                                                    //human clicks versus AI
            if(X_O_display_button.Text == human)
            {
                if(button.Text == "")
                {
                    button.Text = human;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (buttons[i, j].Text == human && board[i, j] == "")
                            {
                                board[i, j] = human;
                            }
                        }
                    }
                        switchPlayer();
                    if (ai_player)
                    {
                        best();
                    }
 
                }
            }
                
        }

        private void switchPlayer()
        {
            checkIfgameEnds();

            if(gameover)
                {
                    gameover = false;
                     return;
                }

            if (X_O_display_button.Text == ai && gameover == false)
            {
                X_O_display_button.Text = human;
            }
            else if (X_O_display_button.Text != ai && gameover == false)
            {
                X_O_display_button.Text = ai;
            }

            if (X_O_display_button.Text == ai)
            {
                label2.Text = ai + "'s turn";
            }
            else label2.Text = human + "'s turn";
        }

        private string checkIfgameEnds()
        {
            List<Button> winnerButtons = new List<Button>();
            string winner = null;
            string player_check = X_O_display_button.Text;

            
                                                                    //horizontal
            for(int i = 0; i < 3; i++)
            {
                if(board[0,i] == board[1,i] && board[0,i] == board[2,i] && board[0,i] != "")
                {
                    winner = board[0, i];
                }
            }
                                                                    //vertical
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2] && board[i,0] != "")
                {
                    winner = board[i, 0];
                }
            }

                                                                    //diag right
            
                if (board[1, 1] == board[0, 0] && board[1, 1] == board[2, 2] && board[1,1] != "")
                {
                    winner = board[1,1];
                }

                                                                    //diag2 left

            if (board[1, 1] == board[2, 0] && board[1, 1] == board[0, 2] && board[1,1] != "")
            {
                winner = board[1, 1];
            }
            
                                                                    //vertical win
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Text != X_O_display_button.Text)
                    {
                        break;
                    }
                    winnerButtons.Add(buttons[i, j]);
                    if (j == 2)
                    {
                        showwinner(winnerButtons);
                        return null;

                    }
                }
            }  
            
                                                                    //horizontal win
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();
                for(int j = 0; j < 3; j++)
                {
                    if(buttons[j, i].Text != X_O_display_button.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[j, i]);
                    if(j == 2)
                    {
                        showwinner(winnerButtons);
                        return null;
                    }
                }
            }
           
                                                                    //diagonal win
            winnerButtons = new List<Button>();
            for(int i = 0, j = 0; i < 3; i++, j++)
            {
                if(buttons[i, j].Text != X_O_display_button.Text)
                {
                    break;
                }
                winnerButtons.Add(buttons[i, j]);
                if(j ==2)
                {
                   showwinner(winnerButtons);

                    return null;
                }
            }
                                                                     //diagonal win
            winnerButtons = new List<Button>();
            for (int i = 2, j = 0; j < 3; i--, j++)
            {
                if (buttons[i, j].Text != X_O_display_button.Text)
                {
                    break;
                }
                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                   showwinner(winnerButtons);
                    return null;
                }
            }

            if (winner != null)
            {
                return winner;
            }

            if (human_players || ai_player)
            {
                foreach (var button in buttons)
                {
                    if(button.Text == "")
                    {
                        return null;
                    }
  
                }
                    MessageBox.Show("Tie Game!");
                    Reset();
                    gameover = true;
                    return null;
            }

            return "Tie";
        }
        private void showwinner(List<Button> winnerButtons)
        {
            gameover = true;
            if (X_O_display_button.Text == "X")
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

            MessageBox.Show("Player " + X_O_display_button.Text + " wins");
           Reset();

        }

        private void Reset()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            genButtons();
            
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = "";
                }
            }
            if (human_players)
            {
                human_button.BackColor = SystemColors.MenuHighlight;
                X_O_display_button.Text = ai;
                label2.Text = "X's turn";

            }
            if(ai_player)                           
            {
                AI_button.BackColor = SystemColors.MenuHighlight;
                random_gen();
                switchPlayer();
                //best();
            }
        }

        void best()                             //best move for AI
        {
            int bestscore = -10000;
            int[] move = new int[2];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (board[i, j] == "")
                    {
                        board[i, j] = ai;
                        int score = minimax(board, 0, false);
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
            board[move[0], move[1]] = ai;
            buttons[move[0], move[1]].Text = ai;
            
            switchPlayer();
            
        }

        public void random_gen()
        {
            int random_number1 = random_move.Next(0, 3);               //random first move after activation or reset
            int random_number2 = random_move.Next(0, 3);
            buttons[random_number1, random_number2].Text = ai;
            board[random_number1, random_number2] = ai;

        }

        public int minimax(string[,] board, int depth, bool maxx)       //minimax for Ai if it is player X
        {       
           
            string result = checkIfgameEnds();

            var ai_scores = new Dictionary<string, int>();      
            ai_scores["X"] = 1500;
            ai_scores["O"] = -10;
            ai_scores["Tie"] = 0;

            if (result != null)
            {
                return ai_scores[checkIfgameEnds()];      
            }

            if (maxx) 
            {
                int bestscore = -1;                     //finds best move for AI
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        if(board[i, j] == "")
                        {
                            board[i, j] = ai;
                            //button1.Text = human;
                            int score = minimax(board, depth + 1, false);
                            //buttons[i, j].Text = "";
                            board[i, j] = "";
                            bestscore = Math.Max(score, bestscore);
                            
                        }
                    }
                }
                return bestscore;
            }
            else {
               int bestscore = 1;                   //finds worst move for human
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
                    return bestscore;
            } 
            
        }

        private void button2_Click(object sender, EventArgs e)          //ai activation toggle button
        {
            if(X_O_display_button.Text == ai || !ai_player)
            {
                AI_button.BackColor = SystemColors.MenuHighlight;
                random_gen();
                switchPlayer();
                //best();
            }
            if(ai_player)                                               //turns off ai 
            {
                ai_player = false;
                AI_button.BackColor = SystemColors.ControlLight;
                return;
            }
            ai_player = true;
        }

        private void button3_Click(object sender, EventArgs e)          //reset button
        {
            Reset();
            
        }

        private void human_button_Click(object sender, EventArgs e)     // human vs human toggle button
        {
            if (human_players)
            {
                human_players = false;
                label2.Text = "Choose game type";
                human_button.BackColor = SystemColors.ControlLight;
                return;
            }

            human_players = true;
            label2.Text = "X's turn";
            human_button.BackColor = SystemColors.MenuHighlight;
        }
    }
}
