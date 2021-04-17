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
       public string[,] evaluation_Board = new string[,]                            //what ai uses to determine best move
       {                                        // i is the first #, j is 2nd 
            {"", "", ""},                       // 00 10 20
            {"", "", ""},                       // 01 11 21
            {"", "", ""},                       // 02 12 20
       };

        Random random_Move = new Random();
        public bool gameover;
        public bool human_Players;
        public bool ai_Player = false;
        public string ai = "X";                         
        public string human = "O";
        
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
                    buttons[i, j].Click += new EventHandler(button_click_human);

                    panel1.Controls.Add(buttons[i, j]);
                }
            }
            
        }

        void button_click_human(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (human_Players)                   //2 player button clicks
            {
                if (button.Text != "")
                {
                    return;
                }

                button.Text = X_O_display_button.Text;
                switchPlayer();
                if (gameover == true)
                {
                    gameover = false;
                }
                return;
            }

                                                  //human clicks versus AI
            if (X_O_display_button.Text == human)
            {
                if (button.Text == "")
                {
                    button.Text = human;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (buttons[i, j].Text == human && evaluation_Board[i, j] == "")
                            {
                                evaluation_Board[i, j] = human;
                            }
                        }
                    }
                   switchPlayer();
                    if (ai_Player)
                    {
                        minimax ai_minimax = new minimax();
                        int[] ai_move = ai_minimax.best(evaluation_Board, buttons, X_O_display_button.Text);
                        evaluation_Board[ai_move[0], ai_move[1]] = ai;
                        buttons[ai_move[0], ai_move[1]].Text = ai;
                        switchPlayer();

                    }
                    
                }
            }

        }
        
        public void switchPlayer()
        {
            minimax ai_minimax = new minimax();
            if (ai_Player)
            {
                ai_minimax.checkIfgameEnds(buttons, X_O_display_button.Text, evaluation_Board, ai_Player);
            }
            else ai_minimax.checkIfgameEnds(buttons, X_O_display_button.Text, evaluation_Board, human_Players);

            if (ai_minimax.gameover)
            {
                Reset();
                ai_minimax.gameover = false;
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

        public void showwinner(List<Button> winnerButtons, string winner)
        {
            gameover = true;
            if (winner == "X" )
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

            MessageBox.Show("Player " + winner + " wins");
            Reset();
        }

        private void reset_Click(object sender, EventArgs e)          //reset button
        {
            Reset();
        }

        private void Reset()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            genButtons();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    evaluation_Board[i, j] = "";
                }
            }
            if (human_Players)
            {
                human_button.BackColor = SystemColors.MenuHighlight;
                X_O_display_button.Text = ai;
                label2.Text = "X's turn";

            }
            else if (ai_Player)
            {
                AI_button.BackColor = SystemColors.MenuHighlight;
                ai_RandomMove();
                if (X_O_display_button.Text != human)
                {
                    X_O_display_button.Text = human;
                }

            }
        }                       

        

        public void ai_RandomMove()
        {
            int random_Num1 = random_Move.Next(0, 3);               //random first move after activation or reset
            int random_Num2 = random_Move.Next(0, 3);
            foreach (var button in buttons)
            {
                if (button.Text != "")
                {
                    minimax ai_Minimax = new minimax();
                    int[] ai_move = ai_Minimax.best(evaluation_Board, buttons, X_O_display_button.Text);
                    evaluation_Board[ai_move[0], ai_move[1]] = ai;
                    buttons[ai_move[0], ai_move[1]].Text = ai;
                    switchPlayer();
                    return;
                }
            }
            buttons[random_Num1, random_Num2].Text = ai;
            evaluation_Board[random_Num1, random_Num2] = ai;
            switchPlayer();
        }

        private void ai_button_Click(object sender, EventArgs e)          //ai activation toggle button
        {
            minimax ai_Minimax = new minimax();

            if (X_O_display_button.Text == human && ai_Player)
            {
                ai_Player = false;
                AI_button.BackColor = SystemColors.ControlLight;
                return;
            }

            if (X_O_display_button.Text == ai) 
            {
                AI_button.BackColor = SystemColors.MenuHighlight;
                ai_Player = true;
                ai_RandomMove();               
                return;
                
            }
            if (ai_Player)                                               //turns off ai 
            {
                ai_Player = false;
                AI_button.BackColor = SystemColors.ControlLight;
                return;
            }
            ai_Player = true;
            AI_button.BackColor = SystemColors.MenuHighlight;
        }

        

        private void human_button_Click(object sender, EventArgs e)     // human vs human toggle button
        {
            if (human_Players)
            {
                human_Players = false;
                label2.Text = "Choose game type";
                human_button.BackColor = SystemColors.ControlLight;
                return;
            }

            human_Players = true;
            if (X_O_display_button.Text == "X")
            {
                label2.Text = "X's turn";
            }
            
            human_button.BackColor = SystemColors.MenuHighlight;
        }
    }
}
