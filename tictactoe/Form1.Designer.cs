
namespace tictactoe
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.X_O_display_button = new System.Windows.Forms.Button();
            this.AI_button = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.human_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(63, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player";
            // 
            // X_O_display_button
            // 
            this.X_O_display_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X_O_display_button.Location = new System.Drawing.Point(617, 84);
            this.X_O_display_button.Margin = new System.Windows.Forms.Padding(2);
            this.X_O_display_button.Name = "X_O_display_button";
            this.X_O_display_button.Size = new System.Drawing.Size(124, 122);
            this.X_O_display_button.TabIndex = 2;
            this.X_O_display_button.Text = "X";
            this.X_O_display_button.UseVisualStyleBackColor = true;
            // 
            // AI_button
            // 
            this.AI_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AI_button.Location = new System.Drawing.Point(580, 277);
            this.AI_button.Margin = new System.Windows.Forms.Padding(2);
            this.AI_button.Name = "AI_button";
            this.AI_button.Size = new System.Drawing.Size(90, 28);
            this.AI_button.TabIndex = 3;
            this.AI_button.Text = "AI";
            this.AI_button.UseVisualStyleBackColor = false;
            this.AI_button.Click += new System.EventHandler(this.ai_button_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(638, 342);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(2);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(90, 28);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_Click);
            // 
            // human_button
            // 
            this.human_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.human_button.Location = new System.Drawing.Point(695, 277);
            this.human_button.Margin = new System.Windows.Forms.Padding(2);
            this.human_button.Name = "human_button";
            this.human_button.Size = new System.Drawing.Size(90, 28);
            this.human_button.TabIndex = 6;
            this.human_button.Text = "Human";
            this.human_button.UseVisualStyleBackColor = false;
            this.human_button.Click += new System.EventHandler(this.human_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose game type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(863, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.human_button);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AI_button);
            this.Controls.Add(this.X_O_display_button);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button X_O_display_button;
        private System.Windows.Forms.Button AI_button;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button human_button;
        private System.Windows.Forms.Label label2;
    }
}

