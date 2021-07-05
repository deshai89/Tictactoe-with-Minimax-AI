using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Game_form : Form
    {
        public Game_form()
        {
            InitializeComponent();
            genButtons();
            
        }
       public string[,] evaluation_Board = new string[,]                            //what ai uses to determine best move
       {                                        // i is the first #, j is 2nd 
            {"", "", ""},                       // 00 10 20
            {"", "", ""},                       // 01 11 21
            {"", "", ""},                       // 02 12 22
       };

        Random random_Move = new Random();
        public bool gameover;
        public bool human_Players;
        public bool ai_Player = false;
        public string ai;
        public string human;
        public int oWinsCount, xWinsCount, tiesCount = 0;
        public string saveStuff;

        
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
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (buttons[i, j].Text != "")
                        {
                            evaluation_Board[i, j] = buttons[i, j].Text;
                        }
                    }
                }
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
                    if (ai_Player && X_O_display_button.Text == ai)
                    {
                        Minimax ai_minimax = new Minimax();
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
            Minimax ai_minimax = new Minimax();
            if (ai_Player)
            {
                ai_minimax.checkIfgameEnds(buttons, X_O_display_button.Text, evaluation_Board, ai_Player, playerNumber.Text);
            }
            else ai_minimax.checkIfgameEnds(buttons, X_O_display_button.Text, evaluation_Board, human_Players, playerNumber.Text);

            if (ai_minimax.gameover)
            {               
                Win_counter(ai_minimax.winnersPiece);
                Reset();
                ai_minimax.gameover = false;
                return;
            }

            if (X_O_display_button.Text == ai && gameover == false)
            {
                X_O_display_button.Text = human;
                playerNumber.Text = "Player 1";
            }
            else if (X_O_display_button.Text != ai && gameover == false)
            {
                playerNumber.Text = "Player 2";
                X_O_display_button.Text = ai;
            }

            if (X_O_display_button.Text == ai)
            {
                label2.Text = ai + "'s turn";
            }
            else label2.Text = human + "'s turn";
        }

        public void showwinner(List<Button> winnerButtons, string winner, string player)
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
            playerNumber.Text = player;
            
            MessageBox.Show(playerNumber.Text  + " wins");

        }

        private void Win_counter(string winner)
        {
            if (winner == "X")
            {
                xWinsCount++;
                Xwinslabel.Text = xWinsCount.ToString();
            }
            else if (winner == "O")
            {
                oWinsCount++;
                Owinslabel.Text = oWinsCount.ToString();
            }
            else
            {
                tiesCount++;
                Tielabel.Text = tiesCount.ToString();
            }
        }

        private void reset_Click(object sender, EventArgs e)          //reset button
        {           
            Reset();
        }

        private void Reset()
        {
            this.panel1.ResetText();
            panel1.Controls.Clear();
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
                X_O_display_button.Text = "X";
                label2.Text = "X's turn";

            }
            else if (ai_Player)
            {
                AI_button.BackColor = SystemColors.MenuHighlight;
                if(ai == "X")
                    ai_RandomMove();
                if (X_O_display_button.Text != human)
                {
                    X_O_display_button.Text = human;
                }

            }
        }                       

        

        private void ai_RandomMove()
        {
            int random_Num1 = random_Move.Next(0, 3);               //random first move after activation or reset
            int random_Num2 = random_Move.Next(0, 3);
            foreach (var button in buttons)
            {
                if (button.Text != "")
                {
                    Minimax ai_Minimax = new Minimax();
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
            if (human_Players)
            {
                return;     //keeps both buttons from be active
            }

            if (!ai_Player)
            {
                player1Choose("ai");
                if (ai == null)
                    return;
            }

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
            if (ai_Player)
            {
                return;     //keeps both buttons from being active
            }
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
            player1Choose("human");
            human_button.BackColor = SystemColors.MenuHighlight;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.FileName = ".txt";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            bool why = saveFileDialog1.OverwritePrompt;
            
            saveStuff = saveFileDialog1.FileName;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";
            saveRecord(Xwinslabel.Text, Owinslabel.Text, Tielabel.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetCounterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Owinslabel.Text = "0";
            Xwinslabel.Text = "0";
            Tielabel.Text = "0";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            loadRecord(path);
        }

        private void loadRecord(string record)
        {
            string line;
            StreamReader sr = new StreamReader(record);
            line = sr.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                    Xwinslabel.Text = line;
                else if (i == 1)
                    Owinslabel.Text = line;
                else if (i == 2)
                    Tielabel.Text = line;

                line = sr.ReadLine();
            }

            sr.Close();
        }

        private void saveRecord(string X, string O, string Tie)
        {
            string message = X + "\n" + O + "\n" + Tie;
            FileStream maybe = new FileStream(saveStuff, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(maybe);
            writer.BaseStream.Seek(0, SeekOrigin.End);
            writer.Write(message);
            writer.Flush();
            writer.Close();

            MessageBox.Show("File created", "Log", MessageBoxButtons.OK); 
            
            

        }

        private void player1Choose(string gameMode)
        {
            Choose_piece_form shai = new Choose_piece_form();
            shai.message(gameMode);
            shai.ShowDialog();

            if (shai.firstPlayer == null)
                return;

            if (shai.firstPlayer == "X")
            {
                playerNumber.Text = "Player 1";
                ai = "O";
                human = "X";
            }
            else
            {
                playerNumber.Text = "Player 2";
                ai = "X";
                human = "O";
            }
        }
  
    }
}
