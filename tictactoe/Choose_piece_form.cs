using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Choose_piece_form : Form
    {
        public Choose_piece_form()
        {
            InitializeComponent();
            
        }
        public string firstPlayer;
        
        private void Choice_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            firstPlayer = button.Text;
            Close();
        }

        public void Message(string gameMode)
        {
            if (gameMode == "ai")
                label1.Text = "Choose your game piece";

            else
                label1.Text = "Player 1, choose your game piece";

        }

    }
}
