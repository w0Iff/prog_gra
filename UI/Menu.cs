namespace Labirynt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamkn¹æ aplikacjê?", "Wyjœcie z Aplikacji", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void GameStart(object sender, EventArgs e)
        {

        }

        private void Settings(object sender, EventArgs e)
        {
            multinustawienia settingsWindow = new multinustawienia();

            settingsWindow.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
