using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace tictactoe
{
    class Minimax : Form
    {

        Game_form Gameform_Copy = new Game_form();
        public bool gameover = false;
        public string winnersPiece;
        public string ai;
        public string human;
        

        public int[] Ai_bestMove(string[,] copy_Board, Button[,] buttons, string display)                 //best move for AI
        {
            int bestscore = -10000;        //10000
            int[] move = new int[2];
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    
                    if (copy_Board[i, j] == "")
                    {
                        copy_Board[i, j] = display;
                        int score = Minimax_Ai(copy_Board, 0, false, buttons, display);
                        copy_Board[i, j] = "";
                        if (score > bestscore)
                        {
                            bestscore = score;
                            move[0] = i;
                            move[1] = j;

                        }
                    }
                }
            }
            
            return move;
        }



        public int Minimax_Ai(string[,] board3, int depth, bool maxx, Button[,] buttons, string display )       //minimax for Ai
        {
            
            string result = CheckIfgameEnds(buttons, display, board3, true, "");
            
            var ai_scores = new Dictionary<string, int>();


            if (display == "X")             //for "X" minimax
            {
                ai = "X";
                human = "O";
                ai_scores["X"] = 1500;
                ai_scores["O"] = -10;
                ai_scores["Tie"] = 0;
            }
            else {                          //for "O" minimax
                ai = "O";
                human = "X";
               ai_scores["O"] = 15;                          
               ai_scores["X"] = -10;
               ai_scores["Tie"] = 1000;
                }
           
            if (result != null)
            {
               return ai_scores[CheckIfgameEnds(buttons, display, board3, true, "")]; 
            }

            if (maxx)
            {
                int bestscore = -1;                     //finds best move for AI
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board3[i, j] == "")
                        {
                            board3[i, j] = ai;
                            int score = Minimax_Ai(board3, depth + 1, false, buttons, display);
                            board3[i, j] = "";
                            bestscore = Math.Max(score, bestscore);

                        }
                    }
                }
                return bestscore;
            }
            else
            {
                int bestscore = 1;                   //finds worst move for human player
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board3[i, j] == "")
                        {
                            board3[i, j] = human;
                            int score = Minimax_Ai(board3, depth + 1, true, buttons, display);
                            board3[i, j] = "";
                            bestscore = Math.Min(score, bestscore);

                        }
                    }
                }
                return bestscore;
            }
        }
        


        public string CheckIfgameEnds(Button[,] buttons, string display, string[,] evaluation_Board, bool gameType, string playerNumber)
        {
            List<Button> winnerButtons = new List<Button>();
            string winner = null;
            

            //horizontal win for evaluation board 
            for (int i = 0; i < 3; i++)
            {
                if (evaluation_Board[0, i] == evaluation_Board[1, i] && evaluation_Board[0, i] == evaluation_Board[2, i] && evaluation_Board[0, i] != "")
                {
                    winner = evaluation_Board[0, i];
                }
            }
            //vertical win for evaluation board 
            for (int i = 0; i < 3; i++)
            {
                if (evaluation_Board[i, 0] == evaluation_Board[i, 1] && evaluation_Board[i, 0] == evaluation_Board[i, 2] && evaluation_Board[i, 0] != "")
                {
                    winner = evaluation_Board[i, 0];
                }
            }

            //diag right win for evaluation board 

            if (evaluation_Board[1, 1] == evaluation_Board[0, 0] && evaluation_Board[1, 1] == evaluation_Board[2, 2] && evaluation_Board[1, 1] != "")
            {
                winner = evaluation_Board[1, 1];
            }

            //diag2 left win for evaluation board 

            if (evaluation_Board[1, 1] == evaluation_Board[2, 0] && evaluation_Board[1, 1] == evaluation_Board[0, 2] && evaluation_Board[1, 1] != "")
            {
                winner = evaluation_Board[1, 1];
            }

            //vertical win for buttons 
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Text != display)
                    {
                        break;
                    }
                    winnerButtons.Add(buttons[i, j]);
                    if (j == 2)
                    {
                        winnersPiece = buttons[i, j].Text;
                        Gameform_Copy.showwinner(winnerButtons, winnersPiece, playerNumber);
                        gameover = true;
                        return null;

                    }
                }
            }

            //horizontal win for buttons
            for (int i = 0; i < 3; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[j, i].Text != display)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[j, i]);
                    if (j == 2)
                    {
                        winnersPiece = buttons[j, i].Text;
                        Gameform_Copy.showwinner(winnerButtons, winnersPiece, playerNumber);
                        gameover = true;
                        return null;
                    }
                }
            }

            //diagonal right win for buttons
            winnerButtons = new List<Button>();
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (buttons[i, j].Text != display)
                {
                    break;
                }
                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    winnersPiece = buttons[i, j].Text;
                    Gameform_Copy.showwinner(winnerButtons, winnersPiece, playerNumber);
                    gameover = true;
                    return null;
                }
            }
            //diagonal right win for buttons
            winnerButtons = new List<Button>();
            for (int i = 2, j = 0; j < 3; i--, j++)
            {
                if (buttons[i, j].Text != display)
                {
                    break;
                }
                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    winnersPiece = buttons[i, j].Text;
                    Gameform_Copy.showwinner(winnerButtons, winnersPiece, playerNumber);
                    gameover = true;
                    return null;
                }
            }

            if (winner != null)
            {
                return winner;
            }

            
            if (gameType)
            {
                foreach (var button in buttons)
                {
                    if (button.Text == "")
                    {
                        return null;
                    }

                }
                MessageBox.Show("Tie Game!");
                gameover = true;
                return "tie";
            }

            return null;
        }

    }
}
