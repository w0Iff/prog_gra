namespace Labirynt
{
    partial class Ustawienia
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(212, 68);
            label1.Name = "label1";
            label1.Size = new Size(402, 308);
            label1.TabIndex = 0;
            label1.Text = "Opcje dostępne w następnej aktualizacji:\r\n\r\n1. Mapy:\r\n\r\n-  Losowe wybieranie mapy\r\n-  Wybór ze zbioru map\r\n\r\n2. Poziom trudności:\r\n \r\n-  Czas przejścia\r\n-  Ilość możliwych pomyłek\r\n";
            // 
            // Ustawienia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.tlofinal;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "Ustawienia";
            Text = "Ustawienia";
            Load += Ustawienia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}