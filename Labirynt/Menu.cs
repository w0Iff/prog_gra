using System.Diagnostics;
using System.Windows.Forms;
using System;
using System.Reflection;

namespace Labirynt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)                                                                                               // Tworzenie wyj�cia z aplikacji
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamkn�� aplikacj�?", "Wyj�cie z Aplikacji", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void GameStart(object sender, EventArgs e)                                                                                          // Uruchamianie drugiego projektu z kodem gry po wci�ni�ciu przycisku "Start Gry"
        {                                                                                                                                           // Kodujemy tak, �eby �cie�ka by�a pobierana z projektu a nie wpisywana recznie lub z pliku konfiguracyjnego 
            string executablePath = System.Reflection.Assembly.GetExecutingAssembly().Location;                                                     // Z racji �e drugi projekt z kodem i sam� gr� jest w konsoli, uruchamiamy �rodowisko .NET i podajemy argument do wykonania 
            string workingDirectory = System.IO.Path.GetDirectoryName(executablePath);

            ProcessStartInfo konsolagry = new ProcessStartInfo
            {
                FileName = "dotnet.exe",
                Arguments = "run",
                WorkingDirectory = workingDirectory
            };

            Process processs = new Process { StartInfo = konsolagry };
            processs.Start();
        }
        //  private void GameStart(object sender, EventArgs e)                                                                                     // Tu by�a inna metoda, z "twardym" zakodowaniem �cie�ki w kodzie. Nie jest to dobre, wi�c dokona�em zmiany (pami�taj�c Pana uwagi z projektu grupowego gdzie robili�my aplikacje).                                                                                  
        //  {                                                                                                                                            
        //      {
        //          ProcessStartInfo konsolagry = new ProcessStartInfo                                                                                         
        //         {
        //              FileName = "dotnet.exe",
        //             Arguments = "run",
        //             WorkingDirectory = "C:\\Users\\Wolf\\Desktop\\prog_gra\\Labirynt_kod"                                         
        //         };

        //         Process processs = new Process { StartInfo = konsolagry };
        //         processs.Start();
        //     }
        //  }
        private void Settings(object sender, EventArgs e)
        {
            Ustawienia settingsWindow = new Ustawienia();

            settingsWindow.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
