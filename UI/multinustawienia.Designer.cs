﻿namespace Labirynt
{
    partial class multinustawienia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 106);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 148);
            textBox1.TabIndex = 0;
            textBox1.Text = "Opcje dostępne w następnej aktualizacji:\r\n\r\n1. Mapy:\r\n    - losowe wybieranie mapy\r\n     - wybór z zbioru map\r\n2 Poziom Trudności \r\n     - Czas przejścia\r\n     -  Ilość możliwych pomyłek\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // multinustawienia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Name = "multinustawienia";
            Text = "multinustawienia";
            Load += multinustawienia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}