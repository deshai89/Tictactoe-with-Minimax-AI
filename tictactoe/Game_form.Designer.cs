
namespace tictactoe
{
    partial class Game_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerNumber = new System.Windows.Forms.Label();
            this.X_O_display_button = new System.Windows.Forms.Button();
            this.AI_button = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.human_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCounterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Xwinslabel = new System.Windows.Forms.Label();
            this.Owinslabel = new System.Windows.Forms.Label();
            this.Tielabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(118, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // playerNumber
            // 
            this.playerNumber.AutoSize = true;
            this.playerNumber.Location = new System.Drawing.Point(1232, 105);
            this.playerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerNumber.Name = "playerNumber";
            this.playerNumber.Size = new System.Drawing.Size(89, 37);
            this.playerNumber.TabIndex = 1;
            this.playerNumber.Text = "Player";
            // 
            // X_O_display_button
            // 
            this.X_O_display_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X_O_display_button.Location = new System.Drawing.Point(1157, 155);
            this.X_O_display_button.Margin = new System.Windows.Forms.Padding(4);
            this.X_O_display_button.Name = "X_O_display_button";
            this.X_O_display_button.Size = new System.Drawing.Size(232, 226);
            this.X_O_display_button.TabIndex = 2;
            this.X_O_display_button.Text = "X";
            this.X_O_display_button.UseVisualStyleBackColor = true;
            // 
            // AI_button
            // 
            this.AI_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AI_button.Location = new System.Drawing.Point(1024, 512);
            this.AI_button.Margin = new System.Windows.Forms.Padding(4);
            this.AI_button.Name = "AI_button";
            this.AI_button.Size = new System.Drawing.Size(264, 52);
            this.AI_button.TabIndex = 3;
            this.AI_button.Text = "AI Vs. Human";
            this.AI_button.UseVisualStyleBackColor = false;
            this.AI_button.Click += new System.EventHandler(this.ai_button_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(1196, 633);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(4);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(169, 52);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Reset_Click);
            // 
            // human_button
            // 
            this.human_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.human_button.Location = new System.Drawing.Point(1303, 512);
            this.human_button.Margin = new System.Windows.Forms.Padding(4);
            this.human_button.Name = "human_button";
            this.human_button.Size = new System.Drawing.Size(264, 52);
            this.human_button.TabIndex = 6;
            this.human_button.Text = "Human Vs. Human";
            this.human_button.UseVisualStyleBackColor = false;
            this.human_button.Click += new System.EventHandler(this.Human_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1140, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose game type";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.resetCounterToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1618, 45);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 41);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(423, 48);
            this.newToolStripMenuItem.Text = "New Game";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.Reset_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(420, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(423, 48);
            this.saveToolStripMenuItem.Text = "Save Records";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(420, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(423, 48);
            this.openToolStripMenuItem.Text = "Load Records";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(420, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(423, 48);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resetCounterToolStripMenuItem1
            // 
            this.resetCounterToolStripMenuItem1.Name = "resetCounterToolStripMenuItem1";
            this.resetCounterToolStripMenuItem1.Size = new System.Drawing.Size(204, 41);
            this.resetCounterToolStripMenuItem1.Text = "Reset Counter";
            this.resetCounterToolStripMenuItem1.Click += new System.EventHandler(this.resetCounterToolStripMenuItem1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(343, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 65);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(34, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 65);
            this.label4.TabIndex = 12;
            this.label4.Text = "X Wins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(604, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 65);
            this.label5.TabIndex = 13;
            this.label5.Text = "O Wins";
            // 
            // Xwinslabel
            // 
            this.Xwinslabel.AutoSize = true;
            this.Xwinslabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Xwinslabel.Location = new System.Drawing.Point(85, 149);
            this.Xwinslabel.Name = "Xwinslabel";
            this.Xwinslabel.Size = new System.Drawing.Size(67, 81);
            this.Xwinslabel.TabIndex = 14;
            this.Xwinslabel.Text = "0";
            // 
            // Owinslabel
            // 
            this.Owinslabel.AutoSize = true;
            this.Owinslabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Owinslabel.Location = new System.Drawing.Point(652, 147);
            this.Owinslabel.Name = "Owinslabel";
            this.Owinslabel.Size = new System.Drawing.Size(67, 81);
            this.Owinslabel.TabIndex = 15;
            this.Owinslabel.Text = "0";
            // 
            // Tielabel
            // 
            this.Tielabel.AutoSize = true;
            this.Tielabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tielabel.Location = new System.Drawing.Point(355, 147);
            this.Tielabel.Name = "Tielabel";
            this.Tielabel.Size = new System.Drawing.Size(67, 81);
            this.Tielabel.TabIndex = 16;
            this.Tielabel.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Owinslabel);
            this.panel2.Controls.Add(this.Tielabel);
            this.panel2.Controls.Add(this.Xwinslabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(45, 682);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 287);
            this.panel2.TabIndex = 17;
            // 
            // Game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1618, 1016);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.human_button);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AI_button);
            this.Controls.Add(this.X_O_display_button);
            this.Controls.Add(this.playerNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game_form";
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label playerNumber;
        private System.Windows.Forms.Button X_O_display_button;
        private System.Windows.Forms.Button AI_button;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button human_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Xwinslabel;
        private System.Windows.Forms.Label Owinslabel;
        private System.Windows.Forms.Label Tielabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem resetCounterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

