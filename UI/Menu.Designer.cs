﻿namespace Labirynt
{
    partial class Menu
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(301, 61);
            button1.Name = "button1";
            button1.Size = new Size(135, 56);
            button1.TabIndex = 0;
            button1.Text = "Start Gry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GameStart;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(301, 138);
            button2.Name = "button2";
            button2.Size = new Size(135, 56);
            button2.TabIndex = 1;
            button2.Text = "Gra Wielosobowa\r\n(wkróce dostępne)";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(301, 213);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(135, 56);
            button3.TabIndex = 2;
            button3.Text = "Ustawienia";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Settings;
            // 
            // button4
            // 
            button4.Location = new Point(301, 285);
            button4.Name = "button4";
            button4.Size = new Size(135, 56);
            button4.TabIndex = 3;
            button4.Text = "Wyjście";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Exit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 414);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "v. 1.0";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "Szalony Labirynt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}
