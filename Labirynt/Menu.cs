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

        private void Exit(object sender, EventArgs e)                                                                                               // Tworzenie wyjœcia z aplikacji
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamkn¹æ aplikacjê?", "Wyjœcie z Aplikacji", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void GameStart(object sender, EventArgs e)                                                                                          // Uruchamianie drugiego projektu z kodem gry po wciœniêciu przycisku "Start Gry"
        {                                                                                                                                           // Kodujemy tak, ¿eby œcie¿ka by³a pobierana z projektu a nie wpisywana recznie lub z pliku konfiguracyjnego 
            string executablePath = System.Reflection.Assembly.GetExecutingAssembly().Location;                                                     // Z racji ¿e drugi projekt z kodem i sam¹ gr¹ jest w konsoli, uruchamiamy œrodowisko .NET i podajemy argument do wykonania 
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
        //  private void GameStart(object sender, EventArgs e)                                                                                     // Tu by³a inna metoda, z "twardym" zakodowaniem œcie¿ki w kodzie. Nie jest to dobre, wiêc dokona³em zmiany (pamiêtaj¹c Pana uwagi z projektu grupowego gdzie robiliœmy aplikacje).                                                                                  
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
